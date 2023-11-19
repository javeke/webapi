namespace webapi.Dto
{
    public class NotificationRequest
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset ModifiedDateTime { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public string? AdditionalData { get; set; }
        public NotificationData? Data { get; set; }
        public bool Seen { get; set; }
        public long EntityId { get; set; }
        public int UserId { get; set; }
        public int? MediaId { get; set; }
        public DateTimeOffset? SeenDateTime { get; set; }
    }
}
