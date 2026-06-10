using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Repository.Models;

public class Hotel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public int StarRating { get; set; }

    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}