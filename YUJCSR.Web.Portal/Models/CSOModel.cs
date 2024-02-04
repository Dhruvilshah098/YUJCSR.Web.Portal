namespace YUJCSR.Web.Portal.Models
{
    public class CSOResultModel
    {
        public List<CSOModel> result { get; set; }
    }

    public class CSOModel
    {
        public string csoid { get; set; }
        public string csoName { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string orgType { get; set; }
        public string website { get; set; }
        public string founder { get; set; }
        public string contactPerson { get; set; }
        public string phoneNumber { get; set; }
        public string emailId { get; set; }
        public string aim { get; set; }
        public string vision { get; set; }
        public string mission { get; set; }
        public string objective { get; set; }
        public string coreAreas { get; set; }
        public string fundRaisedLastYear { get; set; }
        public string otherInfo { get; set; }
        public string approvalStatus { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string activeStatus { get; set; }
        public string createdBy { get; set; }
    }
}
