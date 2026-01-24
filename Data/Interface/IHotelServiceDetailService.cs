using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IHotelServiceDetailService
    {
        Task<HotelServiceDetailDTO> AddServiceDetailAsync(HotelServiceDetailDTO request);
        Task<HotelServiceDetailDTO> GetServiceDetailAsync(int id);
        Task<IEnumerable<HotelServiceDetailDTO>> GetAllServiceDetailsAsync();
        Task DeleteServiceDetailAsync(int id);
        Task<HotelServiceDetailDTO> UpdateServiceDetailAsync(int id, HotelServiceDetailDTO request);

        Task<IEnumerable<HotelServiceDetailDTO>> GetFeaturedServiceDetailsAsync();
    }
}
