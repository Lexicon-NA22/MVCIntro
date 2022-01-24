using System.ComponentModel.DataAnnotations;

namespace MVCIntro.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Förnamn")]
        [StringLength(30, ErrorMessage="Namn får endast ha 30 bokstäver!")]
        public string Name { get; set; }

        [Range(18,100)]
        public int Age { get; set; }
        public int Salary { get; set; }

        //[EmailAddress]
        public string Department { get; set; }
        //public bool Senior { get; set; }

    }
}
