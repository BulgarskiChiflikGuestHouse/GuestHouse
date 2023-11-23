using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHouse.DAL.Models
{
    public class RoomType
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
