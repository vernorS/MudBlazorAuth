namespace MudblazorAuth.Models
{
    public class StudentDetailsModel
    {
        public PersonalDetailsModel? personalDetails { get; set; }
        public StudentModel? studentModel { get; set; }
        public StudentDetailsModel()
        {
            personalDetails = new();
            studentModel = new();
        }

    }
}
