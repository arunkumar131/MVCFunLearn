using AutoMapper;
using MVCFunLearn.Dtos;
using MVCFunLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFunLearn.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}