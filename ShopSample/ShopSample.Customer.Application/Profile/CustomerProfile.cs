using AutoMapper;
using ShopSample.Customer.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSample.Customer.Application
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Domain.Entity.Customer, CustomerDto>().ReverseMap();
        }
    }
}
