using System;
using System.ComponentModel.DataAnnotations;

namespace AnchorTagHelperEx.Models
{
	public class EvenVal:ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			decimal d = Convert.ToDecimal(value);
			if (d % 2 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
