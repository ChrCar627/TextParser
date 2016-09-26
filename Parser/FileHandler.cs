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

		//-----------------------------------------------------------------
		// Name: SaveFile()
		// Author: Chris Carucci
		// Date: 9-26-16
		// Description: Saves the text in the parameter to a text file.
		//-----------------------------------------------------------------
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

		//-----------------------------------------------------------------
		// Name: LoadFile()	
		// Author: Chris Carucci
		// Date: 9-26-16
		// Description: Opens an OpenFileDialog window to load a file.
		// Return: The OpenFileDialog that was opened. The file can then be accessed through filename
		//-----------------------------------------------------------------
		public static OpenFileDialog LoadFile(String title = "Load File", String filter = "Text Files (*.txt,*.rtf,*.doc)|*.txt;*.rtf;*.doc|All Files (*.*)|*.*")
		{
			OpenFileDialog loadfile = new OpenFileDialog();
			loadfile.Title = title;
			loadfile.Filter = filter;
			DialogResult result = loadfile.ShowDialog();
			if (result == DialogResult.OK)
			{
				return loadfile;
			}
			return null;
		}
	}
}
