using AspNetAngularAuth.Dtos;
using AspNetAngularAuth.Models;
using AutoMapper;

namespace AspNetAngularAuth.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TblBook, BookListDto>();
            CreateMap<LoginDto, TblUser>();
            CreateMap<RegisterDto, TblUser>();
        }
    }
}