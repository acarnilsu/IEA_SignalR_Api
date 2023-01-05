using System.Collections.Generic;

namespace IEA_SignalR_Api.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public List<User> Users { get; set; }
    }
}
