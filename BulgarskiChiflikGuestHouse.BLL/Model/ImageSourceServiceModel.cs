using GuestHouse.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHouse.BLL.Model
{
    public class ImageSourceServiceModel
    {
        public Guid Id { get; set; }

        public string Path { get; set; }

        public string? Alt { get; set; }

        public Guid RoomId { get; set; }
    }
}
