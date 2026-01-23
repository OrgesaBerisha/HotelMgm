using HotelMgm.Data.DTO;
using HotelMgm.Models;

namespace HotelMgm.Data.Interface
{
    public interface ICleaningAssignmentService
    {
        Task<CleaningAssignment> AddAssignment(CleaningAssignmentDTO request);
        Task<CleaningAssignmentDTO> GetAssignment(int id);
        Task<IEnumerable<CleaningAssignmentDTO>> GetAllAssignments();
        Task<bool> UpdateAssignment(int assignmentId, CleaningAssignmentDTO dto);
        Task DeleteAssignment(int id);
        Task<bool> StartAssignment(int id);
        Task<bool> MarkAssignmentCompleted(int id);
        Task<bool> CancelAssignment(int id);
        Task<IEnumerable<CleaningAssignmentDTO>> GetAssignmentsByStaffName(string fullName);

    }
}
