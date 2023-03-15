﻿using AutoMapper;
using Domain.Entities;
using Repository.Entities;

namespace Controller
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            #region Repository

            CreateMap<User, UserEntity>().ReverseMap();

            #endregion

            #region Controller

            #endregion
        }
    }
}