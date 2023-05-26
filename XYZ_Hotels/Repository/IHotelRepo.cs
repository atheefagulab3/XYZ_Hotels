using Library.Models;

namespace XYZ_Hotels.Repository
{
    public interface IHotelRepo
    {
        public IEnumerable<Hotels> GetHotels();
        public Hotels GetHotelsById(int Hid);
        public Hotels PostHotels(Hotels hotel);
        public Hotels PutHotels(int HotelId, Hotels hotel);
        public Hotels DeleteHotels(int HotelId);


    }
}
