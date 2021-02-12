using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
	public class InvalidArgException : Exception
	{
		public InvalidArgException(string message) : base(message) { }
	}
}