using System.ComponentModel.DataAnnotations;

namespace XR_Wards.CommonTypes {
    public class Registration {

        [Required]
        [MaxLength(200)]
        public string FirstName {get;set;}

        [Required]
        [MaxLength(200)]
        public string LastName {get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}

        [Required]
        public bool ConfirmStoringEmail {get; set;}
    }
}
