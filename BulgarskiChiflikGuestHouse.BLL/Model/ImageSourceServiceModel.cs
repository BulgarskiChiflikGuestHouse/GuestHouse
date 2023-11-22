namespace GuestHouse.BLL.Model
{
	public class ImageSourceServiceModel
    {
        public Guid Id { get; set; }

        public string Path { get; set; }

        public Guid RoomId { get; set; }

        public string? Alt { get; set; }
    }
}
