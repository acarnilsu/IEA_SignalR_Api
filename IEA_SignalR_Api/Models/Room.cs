using System.Collections.Generic;

namespace IEA_SignalR_Api.Models
{
    public class Room
    {
        public Room()
        {
            Users = new List<User>();
        }

        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public List<User> Users { get; set; }
    }
}
