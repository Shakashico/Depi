using AutoMapper;
using LMSProject.Application.ViewModel.Penalty;

namespace LMSProject.Application.MappingProfile
{
    public class Penalty: Profile
    {
        public Penalty()
        {
            CreateMap<AddPenaltyVM, Penalty>();
            CreateMap<Penalty, AddPenaltyVM>();
        }
    }
}
