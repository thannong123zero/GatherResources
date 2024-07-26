using Microsoft.EntityFrameworkCore.Storage;

namespace MultipleDatabase.DTOs
{
    public class ParkingHistoryDTO : BaseDTO
    {
        public int ID { get; set; }
        public int MallID { get; set; }
        public int? ParkingID { get; set; }
        public string EntryEmployee { get; set; }
        public string ExitEmployee { get; set; }
        public string VisitorName { get; set; }
        public string CardNumber { get; set; }
        public string CardCode { get; set; }
        public string RegisterdLicensePlate { get; set; }
        public string EntryLicensePlate { get; set; }
        public string ExitLicensePlate { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public int VehicleTypeID { get; set; }
        public string TotalTime { get; set; }
        public double Fare { get; set; }
        public string? VoucherType { get; set; }
        public string? VoucherCode { get; set; }
        public double? VoucherValue { get; set; }
        public double TotalAmount { get; set; }
    }
}
