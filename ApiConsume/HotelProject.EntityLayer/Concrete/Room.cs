using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Room
    {
        public int RoomID { get; set; }

        public string RoomCoverImage { get; set; } //Kapak fotoğrafı

        public string RoomNumber { get; set; } 

        public int RoomPrice{ get; set;}

        public string Title { get; set;}

        public string BedCount { get; set;}
        
        public string BathCount { get; set; } // banyo sayısı
        
        public string Wifi { get; set; }

        public string Description { get; set; }
    }
}
