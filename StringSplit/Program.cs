using System;

namespace StringSplit
{
	internal class HomeWork_207
	{
		static void Main(string[] args)
		{
			string words = "Дана строка с текстом, используя метод строки String.Split() получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.";
			string[] arrayWords;
			char delimiter = ' ';

			arrayWords = words.Split(new char[] { delimiter });

			foreach (string word in arrayWords)
			{
				Console.WriteLine(word);
			}
		}
	}
}