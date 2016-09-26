using System;
using System.Linq;
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
            string currentLine = null;
     
            StringReader stringreader = new StringReader(text);
            currentLine = stringreader.ReadLine();
            while (currentLine != null)
            {
                linecount++;
                lettercount = text.Count(char.IsLetter);
                numbercount = text.Count(char.IsDigit);
                wordcount = text.Split().Length;
                foreach(char charType in currentLine)
                {
                    if (char.IsLetterOrDigit(charType) == false)
                    {
                        if(char.IsWhiteSpace(charType) == false)
                            othercount++;
                    }
                }
                currentLine = stringreader.ReadLine();
            }
           return new int[] { numbercount, lettercount, othercount, wordcount, linecount };
        }
    }
}
