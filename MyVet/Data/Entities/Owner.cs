using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")] //Make mandatory the field
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")] //Max lenght of the fild
        public string Document { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")] //Make mandatory the field
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")] //Max lenght of the fild
        [Display(Name = "First Name")] //Like I whant that the user see it
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")] //Make mandatory the field
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")] //Max lenght of the fild
        [Display(Name = "Last Name")] //Like I whant that the user see it
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")] //Max lenght of the fild
        [Display(Name = "Fixed Phone")] //Like I whant that the user see it
        public string FixedPhone { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")] //Make mandatory the field
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")] //Max lenght of the fild
        [Display(Name = "Cell Phone")] //Like I whant that the user see it
        public string CellPhone { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")] //Max lenght of the fild
        public string Address { get; set; }

        [Display(Name = "Owner")] //Like I whant that the user see it
        public string FullName => $"{FirstName} {LastName}"; //Lecture propiety that link variables

        [Display(Name = "Owner")] //Like I whant that the user see it
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}"; //Lecture propiety that link variables

        public ICollection<Pet> Pets { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
