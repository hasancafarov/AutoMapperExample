﻿using AutoMapper;
using AutoMapperExample.Models;

namespace AutoMapperExample.MapperProfiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(destination => destination.Name, operation => operation.MapFrom(source => source.FirstName + " " + source.LastName))
                .ForMember(destination => destination.Status, operation => operation.MapFrom(source => ((UserStatusEnum)source.Status).ToString()));
        }
    }
}
