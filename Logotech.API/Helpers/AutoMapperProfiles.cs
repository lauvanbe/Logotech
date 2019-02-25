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

            CreateMap<Patient, PatientForListDto>();
            CreateMap<Patient, PatientForDetailDto>();

            CreateMap<PatientForUpdateDto, Patient>();
        }
    }
}