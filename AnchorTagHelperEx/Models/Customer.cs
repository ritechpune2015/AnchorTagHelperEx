using System;

namespace AnchorTagHelperEx.Models
{
	public class Customer
	{
		public Int64 CustomerID  { get; set; }
		public string CustomerName { get; set; }
		public string Address { get; set; }
		public Int64 CityID { get; set; }
		public string Email { get; set; }
		public bool IsActive { get; set; }
		public string Password { get; set; }
	}
}
