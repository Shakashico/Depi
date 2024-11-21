using AutoMapper;
using LMSProject.Data.Models.Models;
using LMSProject.Application.ViewModel.BookStore;

namespace LMSProject.Application.MappingProfile
{
    public class BookStoreProfile : Profile
    {
        public BookStoreProfile()
        {
            CreateMap<BookStoreVM, BookStore>();
            CreateMap<BookStore, BookStoreVM>();
        }
    }
}
