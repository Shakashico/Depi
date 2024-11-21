using LMSProject.Application.ViewModel.Borrow;
using LMSProject.Application.ViewModel.Member;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMSProject.Application.ViewModel.ReturnBook
{
    public class ReturnBooksViewModel
    {
        public MemberDetailsVM MemberDetails { get; set; }
        public IEnumerable<BorrowedBookDetailsVM> BorrowedBooks { get; set; }
        public List<SelectListItem> MemberList { get; set; }
    }
}
