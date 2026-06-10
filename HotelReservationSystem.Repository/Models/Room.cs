using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Repository.Models;

public class Room
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public Hotel Hotel { get; set; } = null!;

    public string RoomNumber { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public decimal PricePerNight { get; set; }

    public bool IsAvailable { get; set; } = true;

    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}