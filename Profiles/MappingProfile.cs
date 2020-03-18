using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Profiles
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Customer, CustomerDto>();
      CreateMap<CustomerDto, Customer>();
      CreateMap<Movie, MovieDto>();
      CreateMap<MembershipType, MembershipTypeDto>();
      CreateMap<MembershipTypeDto, MembershipType>();

      CreateMap<CustomerDto, Customer>().ForMember(c => c.CustomerID, opt => opt.Ignore());

      CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
    }
  }
}