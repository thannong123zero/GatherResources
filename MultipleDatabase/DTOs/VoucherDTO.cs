namespace MultipleDatabase.DTOs
{
    public class VoucherDTO : BaseDTO
    {
        public int ID { get; set; }
        public int VoucherTypeID { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public bool IsUsed { get; set; }
    }
}
