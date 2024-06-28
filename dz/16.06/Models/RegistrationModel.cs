namespace _16._06.Models
{
    public class RegistrationModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public bool HobbyCricket { get; set; }
        public bool HobbyDancing { get; set; }
        public bool HobbyDrawing { get; set; }
        public string Course { get; set; }
        public List<string> Skills { get; set; }
    }

}
