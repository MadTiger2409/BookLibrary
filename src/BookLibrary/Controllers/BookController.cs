using AutoMapper;
using BookLibrary.Infrastructure.Commands.Book;
using BookLibrary.Infrastructure.Dto;
using BookLibrary.Infrastructure.Services.Interfaces;
using BookLibrary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    [Authorize]
    [Route("books")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IReservationService reservationService, IMapper mapper)
        {
            _bookService = bookService;
            _reservationService = reservationService;
            _mapper = mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> Books()
        {
            var books = await _bookService.GetAllAsync();
            var booksDto = _mapper.Map<IEnumerable<BookUserIdsDto>>(books);

            return View(booksDto);
        }

        [HttpGet("add-book")]
        public async Task<IActionResult> NewBook()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBook command)
        {
            if (!ModelState.IsValid)
            {
                return View("NewBook", command);
            }

            var success = await _bookService.CreateAsync(command);

            if (!success)
                return View("NewBook", command);

            return RedirectToAction("Books");
        }

        [HttpPost("reserve")]
        public async Task<IActionResult> ReserveBook(int bookId)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Books");
            }

            try
            {
                var userId = int.Parse(HttpContext.User.Claims.ToList()[1].Value);
                await _reservationService.CreateAsync(userId, bookId);
                return RedirectToAction("Books");
            }
            catch (Exception)
            {
                return RedirectToAction("Books");
            }
        }

        [HttpGet("{bookId}")]
        public async Task<IActionResult> Details(int bookId)
        {
            var bookDto = _mapper.Map<BookShortDto>(await _bookService.GetByIdAsync(bookId));
            var reservationDtos = _mapper.Map<List<ReservationDto>>(await _reservationService.GetAllByBookId(bookId));

            return View(new BookDetailsViewModel { Book = bookDto, Reservations = reservationDtos });
        }

        [HttpGet("{bookId}/edit")]
        public async Task<IActionResult> EditBook(int bookId)
        {
            var bookDto = _mapper.Map<BookDto>(await _bookService.GetByIdAsync(bookId));
            var command = new UpdateBook(bookDto);

            return View(command);
        }

        [HttpPost("edit")]
        public async Task<IActionResult> UpdateBook(UpdateBook command)
        {
            if (!ModelState.IsValid)
            {
                return View("EditBook", command);
            }

            var success = await _bookService.UpdateAsync(command);

            if (!success)
                return View("EditBook", command);

            return RedirectToAction("Books");
        }
    }
}