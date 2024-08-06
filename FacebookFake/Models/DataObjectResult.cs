namespace FacebookFake.Models
{
    public class DataObjectResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Html { get; set; }
        public string Object { get; set; }
        public List<string> ArrayObject { get; set; }
        public DataObjectResult()
        {
            Message = string.Empty;
            Html = string.Empty;
            Object = string.Empty;
            Success = false;
            ArrayObject = new List<string>();
        }
    }
}
