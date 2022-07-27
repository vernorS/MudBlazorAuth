namespace MudblazorAuth.Models
{
    public class PersonalDetailsModel
    {
        public int DetailsId { get; set; }
        public string PPSN { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DoB { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string EirCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; } 
    }
}
