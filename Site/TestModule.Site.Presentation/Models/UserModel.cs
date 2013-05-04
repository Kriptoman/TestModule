using System.ComponentModel.DataAnnotations;
using TestModule.Site.Common.Resources;

namespace TestModule.Site.Presentation.Models
{
    public class UserRegistrationModel
    {
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Messages), Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Messages), Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Messages), Name = "RePassword")]
        public string RePassword { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Messages), Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Messages), Name = "LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Messages), Name = "Email")]
        public string Email { get; set; }
    }
}
