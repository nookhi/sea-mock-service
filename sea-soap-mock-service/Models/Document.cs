namespace Models
{
    public class Document : SysObject
    {
        public string creatorName { get; set; }
        public string[] sourceSystemCodes { get; set; }
        public string balanceUnitCode { get; set; }
        public bool electronicSignature { get; set; }
        public AttributeValue[] extAttrValues { get; set; }
    }
}