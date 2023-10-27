namespace GuestHouse.Web.Models
{
    public class ImageSourceViewModel
    {
        public Guid Id { get; set; }

        public string Path { get; set; }

        public string? Alt { get; set; }

        public Guid RoomId { get; set; }
    }
}
