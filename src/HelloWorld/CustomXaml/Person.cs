using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomXaml
{
	public class Person
	{
		public DateTime Birthday { get; private set; }

		public string FullName { get; set; }

		public int Salary { get; set; }

		public Person Father { get; set; }

		public Person Mother { get; set; }

		public Person()
		{
			Birthday = DateTime.Now;
		}
	}
}
