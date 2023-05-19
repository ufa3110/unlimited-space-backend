namespace UnlimitedSpaceService.ChatSection.Model
{
    public class ChatMessage
    {
        public string Id { get; set; }

        public string Text { get; set; } = null!; 

        public DateTime Added { get; set; }

        public string AuthorId { get; set; } = null!;

        public string AuthorName { get; set; } = null!;
    }
}
