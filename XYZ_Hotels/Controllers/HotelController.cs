using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XYZ_Hotels.Repository;

namespace XYZ_Hotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepo hot;
        public HotelController(IHotelRepo hot)
        {
            this.hot = hot;
        }
        [HttpGet]
        public IEnumerable<Hotels>? Get()
        {
            return hot.GetHotels();
        }

        [HttpGet("{id}")]
        public Hotels GetById(int HotelId)
        {
            return hot.GetHotelsById(HotelId);
        }

        [HttpPost]
        public Hotels PostHotels(Hotels hotel)
        {
            return hot.PostHotels(hotel);
        }
        [HttpPut("{id}")]
        public Hotels PutHotels(int HotelId, Hotels hotel)
        {
            return hot.PutHotels(HotelId, hotel);
        }
        [HttpDelete("{id}")]
        public Hotels DeleteHotels(int HotelId)
        {
            return hot.DeleteHotels(HotelId);
        }

    }
}

