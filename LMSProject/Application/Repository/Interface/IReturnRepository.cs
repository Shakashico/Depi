using LMSProject.Data.Models.Models;
using LMSProject.Application.ViewModel.Borrow;
using LMSProject.Application.ViewModel.Member;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMSProject.Application.Repository.Interface
{
    public interface IReturnRepository
    {
        Task<IEnumerable<Member>> GetMembersAsync();
        Task<Member> GetMemberByIdAsync(int memberId);
        Task<IEnumerable<Borrow>> GetBorrowsByMemberIdAsync(int memberId);
        Task<Borrow> GetBorrowByIdAsync(int borrowId);
        Task SaveAsync();
    }
}
