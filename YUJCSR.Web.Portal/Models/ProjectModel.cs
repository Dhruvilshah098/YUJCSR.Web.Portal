namespace YUJCSR.Web.Portal.Models
{
    public class ProjectModel
    {
        public string? ProjectID { get; set; }
        public string? RefID { get; set; }
        public string? Title { get; set; }
        public string? AreOfInterest { get; set; }
        public string? DevelopmentGoal { get; set; }
        public string? ProjectDescription { get; set; }
        public string? Location { get; set; }
        public decimal? TotalBudget { get; set; }
        public decimal? DurationInMonths { get; set; }
        public string? ExpectedOutcome { get; set; }
        public string? Amenities { get; set; }
        public string? Experts { get; set; }
    }

    public class CompanyModelResult
   {
        public List<CompanyModel> result { get; set; }
    }

    public class CompanyModel
    {
        public string? companyID { get; set; }
        public string? companyCode { get; set; }
        public string? companyName { get; set; }
        public string? emailID { get; set; }
        public string? website { get; set; }
        public string? contactDetails { get; set; }
        public string? state { get; set; }
        public string? contactPerson { get; set; }
        public string? annualCSRFund { get; set; }
        public string? industry { get; set; }
        public string? fieldOfWork { get; set; }
        public string? pastCSRActivities { get; set; }
        public string? yearAdded { get; set; }
        public string? appointmentDate { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }
        public string? approvalStatus { get; set; }
        public string? communicationRemarks { get; set; }
        public Boolean activeStatus { get; set; }
        public string? createdBy { get; set; }
        public string? modifiedBy { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
    }


}
