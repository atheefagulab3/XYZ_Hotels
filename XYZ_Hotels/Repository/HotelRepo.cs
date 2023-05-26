using Library.Models;
using Microsoft.EntityFrameworkCore;
using XYZ_Hotels.Models;

namespace XYZ_Hotels.Repository
{
    public class HotelRepo :IHotelRepo
    {
        private readonly HotelContext _hotelContext;
        public HotelRepo(HotelContext con)
        {
            _hotelContext = con;
        }
        public IEnumerable<Hotels> GetHotels()
        {
            return _hotelContext.Hotels.Include(x=>x.Rooms).ToList();
        }
        public Hotels GetHotelsById(int Hid)
        {
            return _hotelContext.Hotels.FirstOrDefault(x => x.Hid == Hid);
        }

        public Hotels PostHotels(Hotels hotel)
        {


            _hotelContext.Hotels.Add(hotel);
            _hotelContext.SaveChanges();
            return hotel;
        }

        public Hotels PutHotels(int HotelId, Hotels hotel)
        {

            _hotelContext.Entry(hotel).State = EntityState.Modified;
            _hotelContext.SaveChangesAsync();
            return hotel;
        }

        public Hotels DeleteHotels(int Hid)
        {

            var hot = _hotelContext.Hotels.Find(Hid);


            _hotelContext.Hotels.Remove(hot);
            _hotelContext.SaveChanges();

            return hot;
        }
    }
}
