using Library.Models;
using Microsoft.EntityFrameworkCore;
using XYZ_Hotels.DB;

namespace XYZ_Hotels.Repository
{
    public class HotelRepo : IHotelRepo
    {
        private readonly HotelContext _hotelContext;
        public HotelRepo(HotelContext con)
        {
            _hotelContext = con;
        }
        public IEnumerable<hotels> GetHotels()
        {
            return _hotelContext.Hotels.Include(x=>x.Rooms).ToList();
        }
        public hotels GetHotelsbyId(int Hid)
        {
            return _hotelContext.Hotels.FirstOrDefault(x => x.Hid == Hid);
        }

        public hotels PostHotels(hotels hotel)
        {


            _hotelContext.Hotels.Add(hotel);
            _hotelContext.SaveChanges();
            return hotel;
        }

        public hotels PutHotels(int HotelId, hotels hotel)
        {

            _hotelContext.Entry(hotel).State = EntityState.Modified;
            _hotelContext.SaveChangesAsync();
            return hotel;
        }

        public hotels DeleteHotels(int Hid)
        {

            var hot = _hotelContext.Hotels.Find(Hid);


            _hotelContext.Hotels.Remove(hot);
            _hotelContext.SaveChanges();

            return hot;
        }
        public object Count(int Hid)
        {
            int c = _hotelContext.Rooms.Count(room => room.Hid == Hid && room.Room_Status == "Available");
            var result = new { Count = c + " Rooms available in " + Hid };
            return result;
        }
        public object RoomList()
        {
            var list = _hotelContext.Rooms.Select(a => new { a.Hotels.HName, a.Rid }).ToList();
            int count = _hotelContext.Rooms.Count();
            var result = new { Count = count + " Rooms and their details ;", Hotels = list };
            return result;
        }

        public object GetHotelsByLocation(string Location)
        {
            return _hotelContext.Hotels.Where(hotel => hotel.Location.ToLower() == Location).ToList();

        }
    }
}
