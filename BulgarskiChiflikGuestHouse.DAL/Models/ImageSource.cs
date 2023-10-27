using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuestHouse.DAL.Models
{
    public class ImageSource
    {
        public Guid Id { get; set; }

        [Required]
        public string Path { get; set; }

        public string? Alt { get; set; }

        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
    }
}
