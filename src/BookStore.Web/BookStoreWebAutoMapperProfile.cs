using BookStore.Authors;
using AutoMapper;
using BookStore.Books;

namespace BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel, CreateAuthorDto>();
        CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel, UpdateAuthorDto>();
    }
}