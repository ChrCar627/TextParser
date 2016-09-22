using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Parser
{
	class FileHandler
	{
		public static void SaveFile(String text)
		{
			SaveFileDialog savefile = new SaveFileDialog();
			savefile.Title = "Save text file";
			savefile.Filter = "All Files (*.*)|*.*|Text File (*.txt)|*.txt";
			savefile.AddExtension = true;
			savefile.DefaultExt = ".txt";
			savefile.FileName = "Untitled.txt";
			if (savefile.ShowDialog() == DialogResult.OK)
			{
				System.IO.File.WriteAllText(savefile.FileName, text);
			}
		}
		public static void LoadFile(Parser parser)
		{
			OpenFileDialog loadfile = new OpenFileDialog();
			loadfile.Title = "Load text file";
			loadfile.Filter = "Text Files (*.txt,*.rtf,*.doc)|*.txt;*.rtf;*.doc|All Files (*.*)|*.*";
			if (loadfile.ShowDialog() == DialogResult.OK)
			{

				parser.TextboxText = System.IO.File.ReadAllText(loadfile.FileName);
				parser.Text = loadfile.SafeFileName + "- Parser";
			}
		}
	}
}
