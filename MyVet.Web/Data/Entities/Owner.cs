using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required] //Make mandatory the field
        [MaxLength(30)] //Max lenght of the fild
        public string Document { get; set; }

        [Required] //Make mandatory the field
        [MaxLength(50)] //Max lenght of the fild
        [Display(Name = "First Name")] //Like I whant that the user see it
        public string FirstName { get; set; }

        [Required] //Make mandatory the field
        [MaxLength(50)] //Max lenght of the fild
        [Display(Name = "Last Name")] //Like I whant that the user see it
        public string LastName { get; set; }

        [MaxLength(20)] //Max lenght of the fild
        [Display(Name = "Fixed Phone")] //Like I whant that the user see it
        public string FixedPhone { get; set; }

        [Required] //Make mandatory the field
        [MaxLength(20)] //Max lenght of the fild
        [Display(Name = "Cell Phone")] //Like I whant that the user see it
        public string CellPhone { get; set; }

        [MaxLength(100)] //Max lenght of the fild
        public string Address { get; set; }

        [Display(Name = "Owner")] //Like I whant that the user see it
        public string FullName => $"{FirstName} {LastName}"; //Lecture propiety that link variables

        [Display(Name = "Owner")] //Like I whant that the user see it
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}"; //Lecture propiety that link variables


    }
}
