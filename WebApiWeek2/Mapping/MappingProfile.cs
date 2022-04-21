using AutoMapper;
using WebApiWeek2.Dtos;
using WebApiWeek2.Models;

namespace WebApiWeek2.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
