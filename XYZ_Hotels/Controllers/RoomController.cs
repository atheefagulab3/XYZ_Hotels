using Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XYZ_Hotels.Repository;

namespace XYZ_Hotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
            try
            {
                return hot.GetRooms();

            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public Rooms? GetById(int Rid)
        {
            try
            {
                return hot.GetRoomsById(Rid);
            }
            catch (Exception ex)
            {
                throw new Exception("nott" + ex.Message);

            }
            
        }

        [HttpPost]
        public Rooms? PostRooms(Rooms rooms)
        {
            try
            {
                return hot.PostRooms(rooms);
            }
            catch(Exception )
            {
                return null;

            }
            
        }
        [HttpPut("{id}")]
        public Rooms? PutRooms(int Rid, Rooms rooms)
        {

            try
            {
                return hot.PutRooms(Rid, rooms);
            }
            catch(Exception )
            {
                return null;
            }
         

       

        }
        [HttpDelete("{id}")]
        public Rooms? DeleteRooms(int Rid)
        {
            try
            {
                return hot.DeleteRooms(Rid);
            }
            catch(Exception ex)
            {
                throw new Exception("nott" + ex.Message);
            }
            
        }

    }
}
