using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
	public class UserAccount
	{
		[Key]
		public int UserID { get; set;}

		[Required(ErrorMessage ="First Name is required")]
		public string FirstName { get; set; }

		[Required(ErrorMessage ="Last Name is required")]
		public string LastName { get; set; }

		[Required(ErrorMessage ="Email is required")]
		[RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Please Enter valid email")]
		public string Email { get; set; }

		[Required(ErrorMessage ="Gener is required")]
		public string Gender { get; set; }

		[Required(ErrorMessage ="Password is required")]
		public string Password { get; set; }
	}
}