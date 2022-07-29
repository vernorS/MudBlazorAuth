namespace MudblazorAuth.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public int DetailsId { get; set; }
        public string? EducationLevel { get; set; }
        public string? ReferralSource { get; set; }
        public bool Interview { get; set; }
        public bool PlaceOffered { get; set; }
        public bool PlaceAccepted { get; set; }
        public bool RegistredWithBLJC { get; set; }
        public bool GuidanceOfficer { get; set; }
        public bool EngagedWithOtherAgencies { get; set; }
        public bool Responsabilities { get; set; }
        public bool PhotoConsent { get; set; }
        public bool DataConsent { get; set; }
        public bool PersonalPropertyConsent { get; set; }
        public bool StudFiciResn { get; set; }
        public string? Notes { get; set; }

    }
}