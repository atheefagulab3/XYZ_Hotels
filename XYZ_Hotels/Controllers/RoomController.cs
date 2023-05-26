using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XYZ_Hotels.Repository;

namespace XYZ_Hotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepo hot;
        public RoomController(IRoomRepo hot)
        {
            this.hot = hot;
        }
        [HttpGet]
        public IEnumerable<Rooms>? Get()
        {
            return hot.GetRooms();
        }

        [HttpGet("{id}")]
        public Rooms GetById(int Rid)
        {
            return hot.GetRoomsById(Rid);
        }

        [HttpPost]
        public Rooms PostRooms(Rooms rooms)
        {
            return hot.PostRooms(rooms);
        }
        [HttpPut("{id}")]
        public Rooms PutRooms(int Rid, Rooms rooms)
        {
            return hot.PutRooms(Rid,rooms);
        }
        [HttpDelete("{id}")]
        public Rooms DeleteRooms(int Rid)
        {
            return hot.DeleteRooms(Rid);
        }

    }
}
