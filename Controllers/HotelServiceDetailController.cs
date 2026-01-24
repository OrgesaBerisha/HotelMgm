using HotelMgm.Data.DTO;
using HotelMgm.Data.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelMgm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelServiceDetailController : ControllerBase
    {
        private readonly IHotelServiceDetailService _service;

        public HotelServiceDetailController(IHotelServiceDetailService service)
        {
            _service = service;
        }

        [HttpPost("AddServiceDetail")]
        public async Task<IActionResult> AddServiceDetail([FromBody] HotelServiceDetailDTO request)
        {
            try
            {
                var result = await _service.AddServiceDetailAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetServiceDetail/{id}")]
        public async Task<IActionResult> GetServiceDetail(int id)
        {
            try
            {
                var result = await _service.GetServiceDetailAsync(id);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllServiceDetails")]
        public async Task<IActionResult> GetAllServiceDetails()
        {
            try
            {
                var result = await _service.GetAllServiceDetailsAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateServiceDetail/{id}")]
        [Authorize(Roles = "Admin,ServiceManager")]
        public async Task<IActionResult> UpdateServiceDetail(int id, [FromBody] HotelServiceDetailDTO request)
        {
            try
            {
                var result = await _service.UpdateServiceDetailAsync(id, request);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteServiceDetail/{id}")]
        [Authorize(Roles = "Admin,ServiceManager")]
        public async Task<IActionResult> DeleteServiceDetail(int id)
        {
            try
            {
                await _service.DeleteServiceDetailAsync(id);
                return Ok(new { message = $"Service detail with ID {id} deleted successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("featured")]
        public async Task<IActionResult> GetFeaturedServiceDetails()
        {
            var featuredServices = await _service.GetFeaturedServiceDetailsAsync();
            return Ok(featuredServices);
        }
    }
}
