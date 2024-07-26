namespace MultipleDatabase.DTOs
{
    public class RevenueDTO
    {
        public int ID { get; set; }
        public int MallID { get; set; }
        public int? ParkingID { get; set; }
        public int VihicleTypeID { get; set; }
        public int RegistrationTypeID { get; set; }
        public double CashAmount { get; set; }
        public double VoucherValue { get; set; }
        public int AccessTimes { get; set; }
        public int NumberOfVourcher { get; set; }
        public double LostCardFee { get; set; }
        public double Revenue { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
