using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CustomXaml
{
	class Program
	{
		static void Main(string[] args)
		{
			var s = typeof(Program).Assembly.GetManifestResourceStream("CustomXaml.Person.xaml");

			var p = XamlReader.Load(s) as Person;

			Console.WriteLine($"p.FullName={p.FullName} p.Salary={p.Salary} p.Birthday={p.Birthday}");
			Console.WriteLine($"Father.FullName={p.Father.FullName} Mother.FullName={p.Mother.FullName}");

			Console.ReadKey();
		}
	}
}
