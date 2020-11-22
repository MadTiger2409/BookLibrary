using AutoMapper;
using BookLibrary.Domain.Models;
using BookLibrary.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibrary.Infrastructure.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<Book, BookShortDto>();
            CreateMap<Book, BookUserIdsDto>().ForMember(dto => dto.UserIds, opt => opt.MapFrom(x => x.Users.Select(y => y.Id).AsEnumerable()));
        }
    }
}