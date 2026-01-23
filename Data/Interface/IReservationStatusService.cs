using HotelMgm.Models;
using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IReservationStatusService
    {
        Task<ReservationStatus> AddReservationStatus(ReservationStatusDTO request);
        Task<ReservationStatus> GetReservationStatus(int id);
        Task<IEnumerable<ReservationStatus>> GetAllReservationStatuses();
        Task DeleteReservationStatus(int id);
        Task<ReservationStatus> UpdateReservationStatus(int id, ReservationStatusDTO request);
    }
}
