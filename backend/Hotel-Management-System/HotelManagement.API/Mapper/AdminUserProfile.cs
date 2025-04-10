
using AutoMapper;
using HotelManagement.API.Model;

namespace HotelManagement.API.Mapper
{
    public class AdminUserProfile : Profile
    {
        public AdminUserProfile()
        {
            CreateMap<AdminUser, AdminUserDto>();

        }
    }
}
