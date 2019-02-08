using AutoMapper;
using Logotech.API.Dtos;
using Logotech.API.Models;

namespace Logotech.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Praticien, PraticienForListDto>();
            CreateMap<Praticien, PraticienForDetailDto>();

            CreateMap<Patient, PatientForListDto>();
            CreateMap<Patient, PatientForDetailDto>();
        }
    }
}