using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
	//-----------------------------------------------------------------
	// Name: Config
	// Author: Chris Carucci
	// Date: 9-26-16
	// Description: Holds application parameters and manages configuration loading
	//-----------------------------------------------------------------
	class Config
	{
		public static int PrintResolution;
		public static bool LogAllTransaction;
		public static String WorkingPath;
		public static String ErrorLogPath;
		public static String DefaultResolution;
		public static int DefaultWidth = 680;
		public static int DefaultHeight = 600;

		
		public static void LoadConfig()
		{
			LoadConfig(FileHandler.LoadFile().FileName);
		}

		//-----------------------------------------------------------------
		// Name: LoadConfig()
		// Author: Chris Carucci
		// Date: 9-26-16
		// Description: Loads a configuration file and sets the application parameters
		//-----------------------------------------------------------------
		public static void LoadConfig(String filename)
		{
			String text = "";
			try
			{
				text = System.IO.File.ReadAllText(filename);
			}
			catch (System.IO.FileNotFoundException)
			{
				System.Windows.MessageBox.Show("Config file not found.");
			}
			System.IO.StringReader reader = new System.IO.StringReader(text);
			String currentline = reader.ReadLine();
			while (currentline != null)
			{
				bool iscomment = false;
				if (System.String.IsNullOrWhiteSpace(currentline)) { currentline = reader.ReadLine(); continue; }
				if (currentline[0] == '/' && currentline[1] == '*') { iscomment = true; }
				if (currentline[0] == '/' && currentline[1] == '/') { iscomment = true; }
				if (iscomment) { iscomment = false; currentline = reader.ReadLine(); continue; }

				//All tests passed. Working with a proper config line now.
				String[] Splitconfig = currentline.Split('=');
				String paramname = Splitconfig[0].Trim(' ');
				String paramvalue = ReplaceValues(Splitconfig[1].Trim(' '));

				try
				{
					switch (paramname)
					{
						case "PrintResolution":
							PrintResolution = int.Parse(paramvalue);
							break;
						case "LogAllTransaction":
							LogAllTransaction = bool.Parse(paramvalue);
							break;
						case "WorkingPath":
							WorkingPath = paramvalue;
							break;
						case "ErrorLogPath":
							ErrorLogPath = paramvalue;
							break;
						case "DefaultResolution":
							DefaultResolution = paramvalue;
							String[] splitres = paramvalue.Split('x');
							DefaultWidth = int.Parse(splitres[0]);
							DefaultHeight = int.Parse(splitres[1]);
							break;
						default:
							throw new UnknownParameterException("Unknown parameter: \""+paramname+"\"");
					}
				}
				catch(Exception e)
				{
					System.Windows.MessageBox.Show(e.ToString());
				}
				//System.Windows.MessageBox.Show(currentline);
				currentline = reader.ReadLine();

			}
			//System.Windows.MessageBox.Show("PrintResolution: " + PrintResolution + "\n" + "LogAllTransaction: " + LogAllTransaction + "\n" + "WorkingPath: " + WorkingPath + "\n" + "ErrorLogPath: " + ErrorLogPath + "\n" + "Default Resolution: " + DefaultResolution);

		}

		//-----------------------------------------------------------------
		// Name: ReplaceValues()
		// Author: Chris Carucci
		// Date: 9-26-16
		// Description: Replaces macros from a text file with appropriate values
		// Return: An identical string, but with the values replaces
		//-----------------------------------------------------------------
		public static string ReplaceValues(string s)
		{
			StringBuilder newstring = new StringBuilder(s);
			newstring.Replace("@apppath", Environment.CurrentDirectory);
			//newstring.Replace("@bestresolution","1600x900");
			if (s.IndexOf('?') != -1)
			{
				string[] splitstr = newstring.ToString().Split('?');
				if (splitstr[0].IndexOf('@') != -1) // Value was replaced
				{
					newstring.Clear();
					newstring.Append(splitstr[1]);
				}
				else // Value was not replaced
				{
					newstring.Clear();
					newstring.Append(splitstr[0]);
				}
			}
			return newstring.ToString();
		}
		
	}
}
