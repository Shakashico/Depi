using LMSProject.Data.Models.Models;

namespace LMSProject.Application.Repository.Interface
{
    public interface IPenaltyRepository
    {
        Task<Borrow?> GetBorrowRecordAsync(int borrowId);
        Task<Penalitie?> GetOrCreatePenaltyRecordAsync(int borrowId, int penaltyDays, float penaltyValue);
    }
}