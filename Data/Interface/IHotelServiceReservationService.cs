using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IHotelServiceReservationService
    {
        Task<IEnumerable<HotelServiceReservationDTO>> GetAllReservationsAsync();
        Task<HotelServiceReservationDTO?> GetReservationByIdAsync(int reservationId);
        Task<int> CreateReservationAsync(HotelServiceReservationDTO reservationDto);
        Task<bool> UpdateReservationAsync(HotelServiceReservationDTO reservationDto);
        Task<bool> DeleteReservationAsync(int reservationId);
    }
}
