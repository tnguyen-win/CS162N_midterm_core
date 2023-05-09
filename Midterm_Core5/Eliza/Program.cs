using System;

namespace Eliza {
	class Program {
		static void Main() {
			string promptStatement = Console.ReadLine();

			Console.WriteLine($"\n\n{CreateElizaResponse(promptStatement)}\n");
		}
		static string CreateElizaResponse(string promptStatement) {
			string[] keywords = { "my", "love", "hate" };
			string[] default_replies = { "Please go on.", "Tell me more.", "Continue." };
			int r = new Random().Next(0, 2);

			for (int i = 0; i < keywords.Length; i++) {
				if (promptStatement.Contains(keywords[i])) {
					switch (Array.IndexOf(keywords, keywords[i])) {
						case 0:
							promptStatement = $"Tell me more about your {promptStatement.Substring(promptStatement.IndexOf(keywords[i]) + keywords.Length)}.";
							break;
						case 1:
						case 2:
							promptStatement = "You have strong feelings about that!";
							break;
						default:
							break;
					}
				}

				if (i == promptStatement.Length) promptStatement = $"{default_replies[r]}";
			}

			return promptStatement;
		}
	}
}