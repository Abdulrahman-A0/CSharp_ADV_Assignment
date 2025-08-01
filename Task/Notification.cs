namespace Task
{
    public class Notification
    {
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"Message: {Message}, Date: {CreatedAt}";
        }
    }
}
