namespace FreshBoard.Data
{
    public class ApplicationPeriodData
    {
        public string? ApplicationId { get; set; }
        public virtual Application? Application { get; set; }

        public int DataTypeId { get; set; }
        public virtual ApplicationPeriodDataType? DataType { get; set; }

        public string? Value { get; set; }
    }
}
