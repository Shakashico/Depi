

using LMSProject.Application.ViewModel.Borrow;
using LMSProject.Application.ViewModel.Member;

namespace LMSProject.Application.ViewModel.ReturnBook
{
    public class ReturnBookVM
    {
        public DateOnly SelectedDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        //public DateTime? ReturnDate { get; set; }
        public int? SelectedMemberId { get; set; }
        public IEnumerable<MemberDetailsVM>? Members { get; set; }
        //public IEnumerable<BorrowedBookDetailsVM>? BorrowedBooks
        //{
        //    get; set;

        //}
    }
}
