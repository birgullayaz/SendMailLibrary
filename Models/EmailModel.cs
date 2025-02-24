namespace Library.Models
{
    public class EmailModel
    {
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public string Topic { get; set; }
        public string Detail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}