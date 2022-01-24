using System.ComponentModel;

namespace MVCIntro.Models.ViewModels
{
    public class EmployeeIndexViewModel
    {
        public int Id { get; set; }

        [DisplayName("Förnamn")]
        public string Name { get; set; }

        [DisplayName("Avdelning")]
        public string Department { get; set; }
    }
}
