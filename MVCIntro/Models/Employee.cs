using System.ComponentModel.DataAnnotations;

namespace MVCIntro.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name="Förnamn")]
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        //public bool Senior { get; set; }

    }
}
