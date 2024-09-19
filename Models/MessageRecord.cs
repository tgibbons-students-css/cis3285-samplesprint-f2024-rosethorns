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
            get;
            private set;
        }

        public string Text
        {
            //UserStory 2A: As a message poster, I want to send markdown text that will be correctly formatted.
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
