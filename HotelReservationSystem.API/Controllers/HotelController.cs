using Asp.Versioning;
using HotelReservationSystem.Business.HotelBusiness;
using HotelReservationSystem.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationSystem.API.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/hotel")]
public class HotelController(IHotelBusiness hotelBusiness) : ControllerBase
{
    [HttpGet]
    [Route("get-hotel-list")]
    public async Task<IActionResult> GetList()
    {
        var listDetails = await hotelBusiness.GetHotelsAsync();
        return Ok(listDetails);
    }

    [HttpGet]
    [Route("get-hotel-details/{hotelId}")]
    public async Task<IActionResult> GetDetails([FromQuery] int hotelId)
    {
        var itemDetails = await hotelBusiness.GetHotelByIdAsync(hotelId);
        return Ok(itemDetails);
    }

    [HttpPost]
    [Route("create-hotel")]
    public async Task<IActionResult> GetDetails([FromBody] CreateHotelDto createHotelDto)
    {
        var createResponse = await hotelBusiness.CreateHotelAsync(createHotelDto);
        return Ok(createResponse);
    }

    [HttpPut]
    [Route("update-hotel")]
    public async Task<IActionResult> GetDetails([FromBody] UpdateHotelDto updateHotelDto)
    {
        var updateResponse = await hotelBusiness.UpdateHotelAsync(updateHotelDto);
        return Ok(updateResponse);
    }
}