namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            //TAKU: "As a system administrator, I want to serve hundreds of users concurrently."
            get;
            private set;
        }

        public string Text
        {
            //UserStory 2A: YUP
            get;
            private set;
        }

        public string AuthorName
        {
            //RoseThorns again!
            get;
            private set;
        }
    }
}
