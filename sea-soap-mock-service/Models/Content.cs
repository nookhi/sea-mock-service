namespace Models
{
    public class Content
    {
        public string renditionType { get; set; } // CLIENT / SERVER / PRIMARY
        public string intentModifier { get; set; } // SET / INSERT / REMOVE
        public string format { get; set; }
        public int pageNumber { get; set; }
        public string pageModifier { get; set; }
        public string contentTransferMode { get; set; } // BASE64 / MTOM / UCF
    }
}