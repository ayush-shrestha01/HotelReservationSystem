using HotelReservationSystem.Shared;
using HotelReservationSystem.Shared.Dtos;

namespace HotelReservationSystem.Business.RoomBusiness;

public interface IRoomBusiness
{
    Task<ApiResponse<List<RoomDto>>> GetRoomsAsync();
    Task<ApiResponse<RoomDto>> GetRoomByIdAsync(int id);
    Task<ApiResponse<RoomDto>> CreateRoomAsync(CreateRoomDto roomDto);
    Task<ApiResponse<RoomDto>> UpdateRoomAsync(UpdateRoomDto roomDto);
    Task<ApiResponse<RoomDto>> UpdateRoomStatusAsync(UpdateRoomDto updateRoomDto);
}