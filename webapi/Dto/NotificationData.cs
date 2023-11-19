namespace webapi.Dto
{
    public class NotificationData
    {
        public string? SourceAlias { get; set; }
        public string? SourceAccountNumber { get; set; }

        public string? TargetAlias { get; set; }
        public string? PayeeAccountNumber { get; set; }
        public string? Note { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? SourceBranch { get; set; }
        public string? PayeeBranch { get; set; }
        public decimal FeeAmount { get; set; }
        public string? FeeCurrencyCode { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
    }
}
