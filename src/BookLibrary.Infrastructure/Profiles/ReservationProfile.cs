using AutoMapper;
using BookLibrary.Domain.Models;
using BookLibrary.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Profiles
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<Reservation, ReservationDto>().ForMember(dto => dto.UserLogin, opt => opt.MapFrom(x => x.User.Login));
        }
    }
}