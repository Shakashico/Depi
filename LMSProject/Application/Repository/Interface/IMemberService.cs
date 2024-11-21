using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMSProject.Application.Repository.Interface
{
    public interface IMemberService
    {
    public    List<SelectListItem> GetMembersForDropdown();

    }
}
