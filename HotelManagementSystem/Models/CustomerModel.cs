using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
	public class CustomerModel: IdentityUser
	{
		public int CustomerId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}
		public string PhoneNumber { get; set; }
		public string PostalCode { get; set; }
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string Country { get; set; }			

	}
}
