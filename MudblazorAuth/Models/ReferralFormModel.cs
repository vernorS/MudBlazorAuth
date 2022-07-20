namespace MudblazorAuth.Models
{
    public class ReferralFormModel
    {
        public int Id { get; set; }
        public string? RefName { get; set; }
        public DateTime RefDob { get; set; }
        public string? RefAddress1 { get; set; }
        public string? RefAddress2 { get; set; }
        public string? RefAddress3 { get; set; }
        public string? RefAddress4 { get; set; }
        public string? RefContact1 { get; set; }
        public string? RefContact2 { get; set; }
        public string? RefPPS { get; set; }
        public string? RefNameReferring { get; set; }
        public string? RefNameReferrer { get; set; }
        public string? RefBackground { get; set; }
        public string? RefMedical { get; set; }
        public string? RefKin { get; set; }
        public DateTime DateReferral { get; set; }
    }
}
