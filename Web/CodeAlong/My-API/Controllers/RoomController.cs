using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_API;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {

    //private readonly List<Room> roomList = new List<Room>
    //    {
    //        new Room { Id = 1, Type = "Deluxe", PricePerNight = 1500.00f, IsAvailable = false },
    //        new Room { Id = 2, Type = "Standard", PricePerNight = 1000.00f, IsAvailable = true },
    //        new Room { Id = 3, Type = "Suite", PricePerNight = 2500.00f, IsAvailable = true }
    //    };
            
        // GET: api/<RoomController>
        [HttpGet(Name = "GetRoomInfo")]
        public IEnumerable<Room> Get()
        {
            using var db = new SQLITEContext();
            var roomList = db.Room.ToList();
            return roomList;
        }

        // GET api/<RoomController>/5
        [HttpGet("{id}")]
        public Room Get(int id)
        {
            using var db = new SQLITEContext();
            var roomList = db.Room.ToList();
            var emptyRoom = new Room() { Id = 0, Type = "", PricePerNight = 0.00, IsAvailable = false };

            var room = roomList.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                return emptyRoom;
            }
            return room;
        }

        [HttpGet("available")]
        public IEnumerable<Room> GetAvailableRooms()
        {
            using var db = new SQLITEContext();
            var roomList = db.Room.ToList();
            return roomList.Where(r => r.IsAvailable);
        }

    }

}
