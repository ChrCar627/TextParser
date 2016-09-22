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
				String[] words = System.Text.RegularExpressions.Regex.Split(currentline, "( |\\t)+");//currentline.Split(' ');
				foreach (String s in words)
				{
					if (System.String.IsNullOrWhiteSpace(s)) { continue; }
					wordcount++;
					foreach (char c in s)
					{
						switch (IdentifyChar(c))
						{
							case CharType.Types.Number:
								numbercount++;
								break;
							case CharType.Types.Letter:
								lettercount++;
								break;
							case CharType.Types.Other:
								othercount++;
								break;
							default:
								break;
						}
					}
				}
				currentline = stringreader.ReadLine();
			}

			return new int[] { numbercount, lettercount, othercount, wordcount, linecount};

		}

		public static CharType.Types IdentifyChar(char c)
		{
			if (System.Char.IsDigit(c)) { return CharType.Types.Number; }
			else if (System.Char.IsLetter(c)) { return CharType.Types.Letter; }
			else if (System.Char.IsWhiteSpace(c)) { return CharType.Types.Whitespace; }
			else { return CharType.Types.Other; }
		}
	}
}
