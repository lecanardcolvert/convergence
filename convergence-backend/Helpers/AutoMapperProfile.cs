using AutoMapper;
using convergence_backend.Entities;
using convergence_backend.Models.Users;

namespace convergence_backend.Helpers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // Users
        CreateMap<RegisterRequest, User>();
        CreateMap<AuthenticateRequest, User>();
    }
}
