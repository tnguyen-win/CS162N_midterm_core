using System;

namespace ProfessorClasses {
	public class Student {
		private string lNumber;
		private string nameFirst;
		private string nameLast;
		private string major;
		private string birthDate;

		public Student() => lNumber = nameFirst = nameLast = major = birthDate;

		public Student(string studentLNUMBER, string studentNameFirst, string studentNameLast, string studentMajor, string studentBirthDate) {
			lNumber = studentLNUMBER;
			nameFirst = studentNameFirst;
			nameLast = studentNameLast;
			major = studentMajor;
			birthDate = studentBirthDate;
		}

		public string LNUMBER {
			get => lNumber;
			set {
				if (value.Length == 9) lNumber = value;
				else throw new ArgumentException("LNUMBER value must be exactly 9 characters long.");
			}
		}

		public string NameFirst {
			get => nameFirst;
			set => nameFirst = value;
		}

		public string NameLast {
			get => nameLast;
			set => nameLast = value;
		}

		public string Major {
			get => major;
			set => major = value;
		}

		public string BirthDate {
			get => birthDate;
			set => birthDate = value;
		}

		public override string ToString() {
			return $"LNUMBER: [{lNumber}] | NameFirst: [{nameFirst}] | NameLast: [{nameLast}] | Major: [{major}] | BirthDate: [{birthDate}]";
		}
	}
}