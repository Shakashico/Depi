using AutoMapper;
using LMSProject.Application.ViewModel.Author;
using LMSProject.Data.Models.Models;
using LMSProject.Application.ViewModel.Member;


namespace LMSProject.Application.MappingProfile
{
    public class MemberProfile:Profile
    {
        public MemberProfile()
        {
            ////MemberVM
            CreateMap<MemberDetailsVM, Member>();
            CreateMap<Member, MemberDetailsVM>();

            CreateMap<MemberVM, Member>();
            CreateMap<Member, MemberVM>();
        }
    }
}
