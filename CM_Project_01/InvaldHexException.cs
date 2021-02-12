using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
	public class Invalid_Hex_Exception : Exception
	{
		public Invalid_Hex_Exception(string message) : base(message) { }
	}
}