using System;
using ProfessorClasses;

namespace ProfessorTests {
	class Program {
		static void Main() {
			TestStudentConstructors();
			TestStudentPropertyGetters();
			TestStudentPropertySetters();
			TestStudentPropertySettersWithExceptions();
			TestStudentToString();
		}

		static void TestStudentConstructors() {
			Student s1 = new();
			Student s2 = new("L01234567", "John", "Smith", "Computer Programming", "1/01/1991");

			Console.WriteLine("[Testing both constructors]");

			Console.WriteLine("Default constructor -");
			Console.WriteLine("Expecting: default values (LNUMBER: [] | NameFirst: [] | NameLast: [] | Major: [] | BirthDate: [])");
			Console.WriteLine($"Got: {s1}");

			Console.WriteLine("Overloaded constructor -");
			Console.WriteLine("Expecting: LNUMBER: [L01234567] | NameFirst: [John] | NameLast: [Smith] | Major: [Computer Programming] | BirthDate: [1/01/1991]");
			Console.WriteLine($"Got: {s2}\n\n");
		}

		static void TestStudentPropertyGetters() {
			Student s = new("L01234567", "John", "Smith", "Computer Programming", "1/01/1991");

			Console.WriteLine("[Testing getters]");

			Console.WriteLine($"LNUMBER -");
			Console.WriteLine($"Expecting: [L01234567]");
			Console.WriteLine($"Got: [{s.LNUMBER}]");

			Console.WriteLine($"NameFirst -");
			Console.WriteLine($"Expecting: [John]");
			Console.WriteLine($"Got: [{s.NameFirst}]");

			Console.WriteLine($"NameLast -");
			Console.WriteLine($"Expecting: [Smith]");
			Console.WriteLine($"Got: [{s.NameLast}]");

			Console.WriteLine($"Major -");
			Console.WriteLine($"Expecting: [Computer Programming]");
			Console.WriteLine($"Got: [{s.Major}]");

			Console.WriteLine($"BirthDate -");
			Console.WriteLine($"Expecting: [1/01/1991]");
			Console.WriteLine($"Got: [{s.BirthDate}]\n\n");
		}

		static void TestStudentPropertySetters() {
			Student s = new("L01234567", "John", "Smith", "Computer Programming", "1/01/1991");

			Console.WriteLine("[Testing setters]");

			s.LNUMBER = "L76543210";
			s.NameFirst = "Jane";
			s.NameLast = "Doe";
			s.Major = "Cybersecurity";
			s.BirthDate = "12/12/2012";

			Console.WriteLine("Expecting: LNUMBER: [L76543210] | NameFirst: [Jane] | NameLast: [Doe] | Major: [Cybersecurity] | BirthDate: [12/12/2012]");
			Console.WriteLine($"Got: {s}\n\n");
		}

		static void TestStudentPropertySettersWithExceptions() {
			Student s = new("L01234567", "John", "Smith", "Computer Programming", "1/01/1991");

			Console.WriteLine("[Testing invalid setter values]");

			try {
				s.LNUMBER = "1";
			}
			catch {
				Console.WriteLine("(LNUMBER = 1) Threw an exception when [LNUMBER] wasn't exactly 9 characters long -");
				Console.WriteLine($"Expecting: [L01234567]");
				Console.WriteLine($"Got: [{s.LNUMBER}]");
			}

			try {
				s.LNUMBER = "0123456789";
			}
			catch {
				Console.WriteLine("(LNUMBER = 0123456789) Threw an exception when [LNUMBER] wasn't exactly 9 characters long -");
				Console.WriteLine($"Expecting: [L01234567]");
				Console.WriteLine($"Got: [{s.LNUMBER}]");
			}

			Console.WriteLine("\n");
		}

		static void TestStudentToString() {
			Student s = new("L01234567", "John", "Smith", "Computer Programming", "1/01/1991");

			Console.WriteLine("[Testing ToString]");

			Console.WriteLine("Expecting: LNUMBER: [L01234567] | NameFirst: [John] | NameLast: [Smith] | Major: [Computer Programming] | BirthDate: [1/01/1991]");
			Console.WriteLine($"Got: {s}\n");
		}
	}
}