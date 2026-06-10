using HotelReservationSystem.Shared;
using HotelReservationSystem.Shared.Dtos;

namespace HotelReservationSystem.Business.HotelBusiness;

public interface IHotelBusiness
{
    Task<ApiResponse<List<HotelDto>>> GetHotelsAsync();
    Task<ApiResponse<HotelDto>> GetHotelByIdAsync(int id);
    Task<ApiResponse<HotelDto>> CreateHotelAsync(CreateHotelDto hotelDto);
    Task<ApiResponse<HotelDto>> UpdateHotelAsync(UpdateHotelDto hotelDto);
}