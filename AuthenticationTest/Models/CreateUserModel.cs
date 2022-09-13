using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationTest.Models
{
    public class CreateUserModel
    {
        public CreateUserModel()
        {
            Password = String.Empty;
            UserName = String.Empty;
            Email = String.Empty;
        }

        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
