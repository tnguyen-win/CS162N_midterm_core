using System;

namespace Palindrome {
	class Program {
		static void Main() {
			Console.Write("Enter a word/phrase to see if it's a palindrome: ");

			string promptText = Console.ReadLine();
			string finalText = "";

			foreach (char s in promptText) if (!char.IsPunctuation(s) && !char.IsWhiteSpace(s)) finalText += s.ToString().ToLower();

			promptText = finalText;

			finalText = IsPalindrome(finalText);

			Console.WriteLine($"\n\nThe word/phrase you entered is a palindrome : {promptText == finalText}\n");
		}

		static string IsPalindrome(string finalText) {
			return finalText.Length > 0 ? finalText[^1] + IsPalindrome(finalText[0..^1]) : finalText;
		}
	}
}