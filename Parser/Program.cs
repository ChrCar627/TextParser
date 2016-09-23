using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
	static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Config.LoadConfig(Environment.CurrentDirectory + "/TestConfig.conf");
			Parser parser = new Parser();
			parser.Size = new System.Drawing.Size(Config.DefaultWidth, Config.DefaultHeight);
			Application.Run(parser);
		}
	}
}
