using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IServiceReservationStatusService
    {
        Task<IEnumerable<ServiceReservationStatusDTO>> GetAllStatusesAsync();
        Task<ServiceReservationStatusDTO?> GetStatusByIdAsync(int statusId);
        Task<int> CreateStatusAsync(ServiceReservationStatusDTO statusDto);
        Task<bool> UpdateStatusAsync(ServiceReservationStatusDTO statusDto);
        Task<bool> DeleteStatusAsync(int statusId);
    }
}
