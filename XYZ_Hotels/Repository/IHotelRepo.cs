using Library.Models;
using XYZ_Hotels.Migrations;

namespace XYZ_Hotels.Repository
{
    public interface IHotelRepo
    {
        public IEnumerable<hotels> GetHotels();
        public hotels GetHotelsbyId(int Hid);
        public hotels PostHotels(hotels hotel);
        public hotels PutHotels(int HotelId, hotels hotel);
        public hotels DeleteHotels(int HotelId);

        public object Count(int Rid);
        public object RoomList();

        public object GetHotelsByLocation(string Location);
       
    }
}
