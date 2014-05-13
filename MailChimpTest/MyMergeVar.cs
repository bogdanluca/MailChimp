using MailChimp.Lists;

namespace MailChimpTest
{
    public class MyMergeVar : MergeVar
    {
        public string CoCode { get; set; }
        public string CurCode { get; set; }
        public string LangCode { get; set; }
        public string Country { get; set; }
        public string Key { get; set; }
        public string SiteID { get; set; }
        public string Domain { get; set; }
        public string SiteGroup { get; set; }
    }
}