using Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XYZ_Hotels.Migrations;
using XYZ_Hotels.Repository;

namespace XYZ_Hotels.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepo hot;
        public HotelController(IHotelRepo hot)
        {

            this.hot = hot;
        }
        [HttpGet]
        public IEnumerable<hotels>? Get()
        {
            try
            {
                return hot.GetHotels();
            }
            catch(Exception)
            {
                return null;
            }
            
        }

      

        [HttpPost]
        public hotels? PostHotels(hotels hotel)
        {
            try
            {
                return hot.PostHotels(hotel);
            }
            catch(Exception)
            {
                return null;
            }
            
        }
        [HttpPut("{id}")]
        public hotels? PutHotels(int HotelId, hotels hotel)
        {
            try
            {
                return hot.PutHotels(HotelId, hotel);
            }
            catch(Exception)
            {
                return null;
            }
            
        }
        [HttpDelete("{id}")]
        public hotels? DeleteHotels(int HotelId)
        {
            try
            {
                return hot.DeleteHotels(HotelId);
            }
            catch
            {
                return null;
            }
           
        }
        [HttpGet("/count/{Rid}")]
        public ActionResult<object>? Count(int Rid)
        {
            try
            {
                var result = hot.Count(Rid);
                return Ok(result);
            }
            catch(Exception)
            {
                return null;
            }
           
        }
        [HttpGet("/room/list")]
        public ActionResult<object>? CountList()
        {
            try
            {
                var result = hot.RoomList();
                return Ok(result);
            }
            catch
            {
                return null;
            }
           
        }
        [HttpGet("/filter/Location")]

        public ActionResult<object> HotelsByLocation(string Location)
        {
            var h = hot.GetHotelsByLocation(Location.ToLower());
            return Ok(h);
        }

    }
}

