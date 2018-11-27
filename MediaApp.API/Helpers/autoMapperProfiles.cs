using System.Linq;
using AutoMapper;
using MediaApp.API.Dtos;
using MediaApp.API.Models;

namespace MediaApp.API.Helpers
{
    public class autoMapperProfiles : Profile
    {
        public autoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.VideoUrl, opt => {
                    opt.MapFrom(src => src.Videos.FirstOrDefault(v => v.IsFavorite).Url);
                });
            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.VideoUrl, opt => {
                    opt.MapFrom(src => src.Videos.FirstOrDefault(v => v.IsFavorite).Url);
                });
            CreateMap<Video, VideosForDetailedDto>();
            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<Video, VideoForReturnDto>();
            CreateMap<VideoForCreationDto, Video>();
        }
    }
}