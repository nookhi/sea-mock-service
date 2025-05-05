using System;

namespace Models
{
    public class SysObject : TypedObject
    {
        public string chronicleId { get; set; }
        public string objectName { get; set; }
        public string title { get; set; }
        public DateTime? creationDate { get; set; }
        public string objectType { get; set; }
        public int contentSize { get; set; }
        public string contentType { get; set; }
        public DateTime? modifyDate { get; set; }
        public string modifier { get; set; }
        public string[] versionLabels { get; set; }
        public int pageCnt { get; set; }
        public string lockOwner { get; set; }
    }
}