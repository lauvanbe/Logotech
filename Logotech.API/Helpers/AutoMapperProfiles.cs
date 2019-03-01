using System.Linq;
using AutoMapper;
using Logotech.API.Dtos;
using Logotech.API.Models;

namespace Logotech.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Docteur, DocteurForListDto>();
            CreateMap<Docteur, DocteurForDetailDto>();

            CreateMap<Patient, PatientForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                });
            CreateMap<Patient, PatientForDetailDto>()
                .ForMember(dest => dest.PhotoUrl, opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                });
            CreateMap<PatientForUpdateDto, Patient>();

            CreateMap<Photo, PhotoForDetailDto>();

            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
        }
    }
}