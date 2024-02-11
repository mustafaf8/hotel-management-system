using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRezervasyonSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelManagementSystem hotelSystem = new HotelManagementSystem();

            // Örnek odaları oluşturma
            Room room1 = new Room { Number = 101, Type = "Standart", IsOccupied = false };
            Room room2 = new Room { Number = 102, Type = "Suit", IsOccupied = true };
            Room room3 = new Room { Number = 103, Type = "Standart", IsOccupied = false };

            // Odaları sisteme ekleme
            hotelSystem.AddRoom(room1);
            hotelSystem.AddRoom(room2);
            hotelSystem.AddRoom(room3);

            // Mevcut boş odaları gösterme
            hotelSystem.ShowAvailableRooms();

            // Oda rezervasyonu yapma
            hotelSystem.BookRoom(101);
            hotelSystem.BookRoom(102);
            hotelSystem.BookRoom(104); // Olmayan bir oda numarası
        }
    
    }
}
