namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name, int roomId)
        {
            //Oh YEAHHH ROSE THORNS IS AWESOME
            Name = name;
            RoomId1 = roomId;
        }
        //TAKU: "As a system admin, I want to be able to set a limit to the number of users in any one room."
        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            //TAKU: "As a system administrator, I want to serve hundreds of users concurrently."
            get;
            private set;
        }
    }
}
