namespace MultipleDatabase.DTOs
{
    public class ParkingDTO : BaseDTO
    {
        public int ID { get; set; }
        public int MallID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
    }
}
