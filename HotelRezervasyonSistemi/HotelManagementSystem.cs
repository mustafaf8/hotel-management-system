using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRezervasyonSistemi
{
    internal class HotelManagementSystem
    {
     
    private List<Room> rooms;

        public HotelManagementSystem()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
            Console.WriteLine($"Oda {room.Number} başarıyla eklendi.");
        }

        public void ShowAvailableRooms()
        {
            Console.WriteLine("Mevcut Boş Odalar:");
            foreach (var room in rooms)
            {
                if (!room.IsOccupied)
                {
                    Console.WriteLine($"Oda Numarası: {room.Number}, Türü: {room.Type}");
                }
            }
        }

        public void BookRoom(int roomNumber)
        {
            Room room = rooms.Find(r => r.Number == roomNumber);
            if (room != null)
            {
                if (!room.IsOccupied)
                {
                    room.IsOccupied = true;
                    Console.WriteLine($"Oda {room.Number} başarıyla rezerve edildi.");
                }
                else
                {
                    Console.WriteLine($"Üzgünüz, oda {room.Number} şu anda dolu.");
                }
            }
            else
            {
                Console.WriteLine($"Hata: Oda {roomNumber} bulunamadı.");
            }
        }
    }


}
