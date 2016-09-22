using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
	public partial class Parser : Form
	{
		System.Threading.Timer timer;
		public static int timescalled = 0;
		public Parser()
		{
			InitializeComponent();
			//TextBox.CheckForIllegalCrossThreadCalls = false;

			timer = new System.Threading.Timer(p =>
			{
				UpdateInfo();
			});
		}
		

		public void UpdateInfo()
		{
			if (InvokeRequired)	{ Invoke(new MethodInvoker(UpdateInfo)); return; }

			int[] parsedinfo = Reader.Parse(textbox1.Text);
			labelNumbersCount.Text = parsedinfo[0].ToString();
			labelLettersCount.Text = parsedinfo[1].ToString();
			LabelOtherCount.Text = parsedinfo[2].ToString();
			LabelWordsCount.Text = parsedinfo[3].ToString();
			LabelLinesCount.Text = parsedinfo[4].ToString();
			labelTotalCount.Text = (parsedinfo[0] + parsedinfo[1] + parsedinfo[2]).ToString();
			timescalled++;
			CalledCount.Text = timescalled.ToString();
		}

		private void textbox1_TextChanged(object sender, EventArgs e)
		{
			timer.Change(400, System.Threading.Timeout.Infinite);
		}
		

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog loadfile = new OpenFileDialog();
			loadfile.Title = "Load text file";
			loadfile.Filter = "Text Files (*.txt,*.rtf,*.doc)|*.txt;*.rtf;*.doc|All Files (*.*)|*.*";
			if (loadfile.ShowDialog() == DialogResult.OK)
			{
				textbox1.Text = System.IO.File.ReadAllText(loadfile.FileName);
				this.Text = loadfile.SafeFileName + "- Parser";
			}
		}

		private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SaveFileDialog savefile = new SaveFileDialog();
			savefile.Title = "Save text file";
			savefile.Filter = "All Files (*.*)|*.*|Text File (*.txt)|*.txt";
			savefile.AddExtension = true;
			savefile.DefaultExt = ".txt";
			savefile.FileName = "Untitled.txt";
			if(savefile.ShowDialog() == DialogResult.OK)
			{
				System.IO.File.WriteAllText(savefile.FileName,textbox1.Text);
			}
		}




		//Make tab actually write a tab in the text box.

		private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == '\t')
			{
				e.Handled = true;
			}
		}
		private void textbox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Tab)
			{
				textbox1.AppendText("\t");
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textbox1.Text = "";
			this.Text = "Untitled - Parcer";
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog savefile = new SaveFileDialog();
			savefile.Title = "Save text file";
			savefile.Filter = "All Files (*.*)|*.*|Text File (*.txt)|*.txt";
			savefile.AddExtension = true;
			savefile.DefaultExt = ".txt";
			savefile.FileName = "Untitled.txt";
			if (savefile.ShowDialog() == DialogResult.OK)
			{
				System.IO.File.WriteAllText(savefile.FileName, textbox1.Text);
			}
		}
	}
}
