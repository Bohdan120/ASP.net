namespace dz_7._06_.Models
{
    public class SummaryViewModel
    {
        public int Id { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public ProfessionalSkills ProfessionalSkills { get; set; }
        public List<TestQuestion> TestQuestions { get; set; }
    }

}
