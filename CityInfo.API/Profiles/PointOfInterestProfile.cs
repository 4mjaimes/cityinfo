﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDTO>();
            CreateMap<Models.PointsOfInterestForCreationDTO, Entities.PointOfInterest>();
            CreateMap<Models.PointsOfInterestForUpdateDTO, Entities.PointOfInterest>()
                .ReverseMap();
        }
    }
}
