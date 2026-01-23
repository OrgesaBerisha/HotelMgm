using HotelMgm.Data.DTO;
using HotelMgm.Models;

namespace HotelMgm.Data.Interface
{
    public interface ICleaningStaffService
    {
        Task<object> AddCleaningStaff(CleaningStaffDTO dto);
        Task<CleaningStaffDTO> GetCleaningStaff(int id);
        Task<IEnumerable<CleaningStaffDTO>> GetAllCleaningStaff();
        Task DeleteCleaningStaff(int id);
        Task<CleaningStaff> UpdateCleaningStaff(int id, CleaningStaffDTO request);

        Task<IEnumerable<CleaningStaffDTO>> GetByShift(string shift);
        Task<IEnumerable<CleaningStaffDTO>> GetAllActive();
        Task<bool> ChangeShift(int id, string newShift);


    }
}
