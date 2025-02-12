using System.ComponentModel.DataAnnotations.Schema;

namespace My_API;

public class Booking {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{ get; set; }
    public int CustomerId {get; set;}
    public int RoomId { get; set; }

    public DateOnly CheckInDate { get; set; }
    public DateOnly CheckOutDate { get; set; }
}