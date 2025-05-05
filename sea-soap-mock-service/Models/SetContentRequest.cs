namespace Models
{
    public class SetContentRequest
    {
        public string documentId { get; set; }
        public DmrContent content { get; set; }
        public bool createVersion { get; set; }
    }
}