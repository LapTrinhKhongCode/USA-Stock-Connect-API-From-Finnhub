using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
	public class LoginDTO
	{
		[Required(ErrorMessage = "UserName cant't be blank")]
		public string? UserName { get; set; }


		[Required(ErrorMessage = "Password can't be blank")]
		[DataType(DataType.Password)]
		public string? Password { get; set; }
	}
}
