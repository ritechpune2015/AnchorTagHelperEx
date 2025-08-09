using AnchorTagHelperEx.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace AnchorTagHelperEx.Models
{
	public class Customer
	{
		public Int64 CustomerID  { get; set; }
		//[DataType(DataType.DateTime)]
		[Display(Name ="Full Name")]
		[Required(ErrorMessage ="Please Input Customer Name")]
		public string CustomerName { get; set; }
		[Required(ErrorMessage ="Address Required")]
		[StringLength(12,MinimumLength =5,ErrorMessage ="Invalid Address Length")]
		public string Address { get; set; }
		[Display(Name ="Select City")]
		[Required(ErrorMessage ="Please Select City")]
		public Int64 CityID { get; set; }
		[Required(ErrorMessage ="Please Input Email")]
		[EmailAddress(ErrorMessage ="Please Input Valid Email Address")]
		public string Email { get; set; }
		[Display(Name="Select Category")]
		[Required(ErrorMessage ="Please Select Category")]
		public CustomerCategoryEnum Category { get; set; }
		public bool IsActive { get; set; }
		[Required(ErrorMessage ="Please Input Mobile No")]
		[RegularExpression(@"^\d{10}$",ErrorMessage ="Please Input 10 Digits!")]
		public string MobileNo { get; set; }

		[DataType(DataType.Password)]
		[Required(ErrorMessage ="Password Required")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Compare("Password",ErrorMessage ="Password and Confirm Password are not Same!")]
		public string ConfirmPassword { get; set; }
	}
}
