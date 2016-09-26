using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parser
{
	class Reader
	{

		//-----------------------------------------------------------------
		// Name: Parse()
		// Author: Chris Carucci
		// Date: 9-26-16
		// Description: Parses the text passed to it
		// Return: An array of integers containing {numbercount, lettercount, othercount, wordcount, linecount}
		//-----------------------------------------------------------------
		public static int[] Parse(String text)
		{
			int linecount = 0;
			int wordcount = 0;
			int lettercount = 0;
			int numbercount = 0;
			int othercount = 0;

			System.IO.StringReader stringreader = new System.IO.StringReader(text);

			String currentline = stringreader.ReadLine();
			while (currentline != null)
			{
				linecount++;


				//Find all words in the current line

				//Regex method:
				//String[] words = System.Text.RegularExpressions.Regex.Split(currentline, "( |\\t)+");//currentline.Split(' ');

				//Custom:
				List<String> words = new List<String>();
				StringBuilder currentword = new StringBuilder();
				int charcount = 0;
				foreach (char c in currentline)
				{
					charcount++;
					switch (IdentifyChar(c))
					{
						case CharType.Types.Whitespace:
							if (currentword.Length >= 1) { words.Add(currentword.ToString()); }
							currentword.Remove(0, currentword.Length);
							break;
						case CharType.Types.Letter:
							lettercount++;
							goto default;
						case CharType.Types.Number:
							numbercount++;
							goto default;
						case CharType.Types.Other:
							othercount++;
							goto default;
						default:
							currentword.Append(c);
							if(charcount == currentline.Length) { words.Add(currentword.ToString()); }
							break;
					}
				}
				wordcount += words.Count;
				
				currentline = stringreader.ReadLine();
			}

			return new int[] { numbercount, lettercount, othercount, wordcount, linecount};

		}


		//-----------------------------------------------------------------
		// Name: IdentifyChar()
		// Author: Chris Carucci
		// Date: 9-26-16
		// Description: Identifies the type of character that was passed to the function.
		// Return: An enumeration of CharType.Types representing the character type.
		//-----------------------------------------------------------------
		public static CharType.Types IdentifyChar(char c)
		{
			if (System.Char.IsDigit(c)) { return CharType.Types.Number; }
			else if (System.Char.IsLetter(c)) { return CharType.Types.Letter; }
			else if (System.Char.IsWhiteSpace(c)) { return CharType.Types.Whitespace; }
			else { return CharType.Types.Other; }
		}
	}
}
