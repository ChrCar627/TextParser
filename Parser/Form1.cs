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

		private void buttonParse_Click(object sender, EventArgs e)
		{
			UpdateInfo();
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
	}
}
