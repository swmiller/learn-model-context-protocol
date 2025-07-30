public class Message
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }

    public Message(int id, string content)
    {
        Id = id;
        Content = content;
        Timestamp = DateTime.UtcNow;
    }
}