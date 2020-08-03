using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserListDto>().ForMember(
                dest => dest.PhotoUrl, 
                opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url)
            ).ForMember(
                dest => dest.Age, 
                opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge())
            );
            CreateMap<User, UserDetailDto>().ForMember(
                dest => dest.PhotoUrl, 
                opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url)
            ).ForMember(
                dest => dest.Age, 
                opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge())
            );
            CreateMap<Photo, PhotoDetailsDto>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<Photo, ReturnPhotoDto>();
            CreateMap<NewPhotoDto, Photo>();
            CreateMap<UserCredsRegisterDto, User>();
            CreateMap<CreateNewMessageDto, Message>().ReverseMap();
            CreateMap<Message, ReturnMessageDto>()
                .ForMember(
                    m => m.SenderPhotoUrl, 
                    opt => opt.MapFrom(u => u.Sender.Photos.FirstOrDefault(p => p.IsMain).Url)
                ).ForMember(
                    m => m.RecipientPhotoUrl, 
                    opt => opt.MapFrom(u => u.Recipient.Photos.FirstOrDefault(p => p.IsMain).Url)
                );
        }
    }
}