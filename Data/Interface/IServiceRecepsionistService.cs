using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IServiceRecepsionistService
    {
        Task<IEnumerable<ServiceRecepsionistDTO>> GetAllRecepsionistsAsync();
        Task<ServiceRecepsionistDTO?> GetRecepsionistByIdAsync(int recepsionistId);
        Task<int> CreateRecepsionistAsync(ServiceRecepsionistDTO recepsionistDto);
        Task<bool> UpdateRecepsionistAsync(ServiceRecepsionistDTO recepsionistDto);
        Task<bool> DeleteRecepsionistAsync(int recepsionistId);
    }
}
