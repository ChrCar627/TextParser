namespace Parser
{
	partial class Parser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textbox1 = new System.Windows.Forms.RichTextBox();
			this.LabelLetters = new System.Windows.Forms.Label();
			this.LabelNumbers = new System.Windows.Forms.Label();
			this.LabelWords = new System.Windows.Forms.Label();
			this.LabelLines = new System.Windows.Forms.Label();
			this.LabelOther = new System.Windows.Forms.Label();
			this.labelLettersCount = new System.Windows.Forms.Label();
			this.labelNumbersCount = new System.Windows.Forms.Label();
			this.LabelOtherCount = new System.Windows.Forms.Label();
			this.LabelLinesCount = new System.Windows.Forms.Label();
			this.LabelWordsCount = new System.Windows.Forms.Label();
			this.CalledCount = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelTotalCount = new System.Windows.Forms.Label();
			this.LabelTotal = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textbox1
			// 
			this.textbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textbox1.EnableAutoDragDrop = true;
			this.textbox1.Location = new System.Drawing.Point(0, 27);
			this.textbox1.Name = "textbox1";
			this.textbox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.textbox1.Size = new System.Drawing.Size(684, 569);
			this.textbox1.TabIndex = 0;
			this.textbox1.TabStop = false;
			this.textbox1.Text = "";
			this.textbox1.WordWrap = false;
			this.textbox1.TextChanged += new System.EventHandler(this.textbox1_TextChanged);
			this.textbox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox1_KeyDown);
			this.textbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox1_KeyPress);
			// 
			// LabelLetters
			// 
			this.LabelLetters.AutoSize = true;
			this.LabelLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelLetters.Location = new System.Drawing.Point(12, 4);
			this.LabelLetters.Name = "LabelLetters";
			this.LabelLetters.Size = new System.Drawing.Size(60, 17);
			this.LabelLetters.TabIndex = 1;
			this.LabelLetters.Text = "Letters: ";
			// 
			// LabelNumbers
			// 
			this.LabelNumbers.AutoSize = true;
			this.LabelNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelNumbers.Location = new System.Drawing.Point(12, 21);
			this.LabelNumbers.Name = "LabelNumbers";
			this.LabelNumbers.Size = new System.Drawing.Size(69, 17);
			this.LabelNumbers.TabIndex = 2;
			this.LabelNumbers.Text = "Numbers:";
			// 
			// LabelWords
			// 
			this.LabelWords.AutoSize = true;
			this.LabelWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelWords.Location = new System.Drawing.Point(127, 21);
			this.LabelWords.Name = "LabelWords";
			this.LabelWords.Size = new System.Drawing.Size(53, 17);
			this.LabelWords.TabIndex = 3;
			this.LabelWords.Text = "Words:";
			// 
			// LabelLines
			// 
			this.LabelLines.AutoSize = true;
			this.LabelLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelLines.Location = new System.Drawing.Point(127, 38);
			this.LabelLines.Name = "LabelLines";
			this.LabelLines.Size = new System.Drawing.Size(46, 17);
			this.LabelLines.TabIndex = 4;
			this.LabelLines.Text = "Lines:";
			// 
			// LabelOther
			// 
			this.LabelOther.AutoSize = true;
			this.LabelOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelOther.Location = new System.Drawing.Point(12, 39);
			this.LabelOther.Name = "LabelOther";
			this.LabelOther.Size = new System.Drawing.Size(48, 17);
			this.LabelOther.TabIndex = 5;
			this.LabelOther.Text = "Other:";
			// 
			// labelLettersCount
			// 
			this.labelLettersCount.AutoSize = true;
			this.labelLettersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelLettersCount.Location = new System.Drawing.Point(87, 4);
			this.labelLettersCount.Name = "labelLettersCount";
			this.labelLettersCount.Size = new System.Drawing.Size(16, 17);
			this.labelLettersCount.TabIndex = 6;
			this.labelLettersCount.Text = "0";
			// 
			// labelNumbersCount
			// 
			this.labelNumbersCount.AutoSize = true;
			this.labelNumbersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelNumbersCount.Location = new System.Drawing.Point(87, 21);
			this.labelNumbersCount.Name = "labelNumbersCount";
			this.labelNumbersCount.Size = new System.Drawing.Size(16, 17);
			this.labelNumbersCount.TabIndex = 7;
			this.labelNumbersCount.Text = "0";
			// 
			// LabelOtherCount
			// 
			this.LabelOtherCount.AutoSize = true;
			this.LabelOtherCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelOtherCount.Location = new System.Drawing.Point(87, 39);
			this.LabelOtherCount.Name = "LabelOtherCount";
			this.LabelOtherCount.Size = new System.Drawing.Size(16, 17);
			this.LabelOtherCount.TabIndex = 8;
			this.LabelOtherCount.Text = "0";
			// 
			// LabelLinesCount
			// 
			this.LabelLinesCount.AutoSize = true;
			this.LabelLinesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelLinesCount.Location = new System.Drawing.Point(202, 38);
			this.LabelLinesCount.Name = "LabelLinesCount";
			this.LabelLinesCount.Size = new System.Drawing.Size(16, 17);
			this.LabelLinesCount.TabIndex = 9;
			this.LabelLinesCount.Text = "0";
			// 
			// LabelWordsCount
			// 
			this.LabelWordsCount.AutoSize = true;
			this.LabelWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelWordsCount.Location = new System.Drawing.Point(202, 21);
			this.LabelWordsCount.Name = "LabelWordsCount";
			this.LabelWordsCount.Size = new System.Drawing.Size(16, 17);
			this.LabelWordsCount.TabIndex = 10;
			this.LabelWordsCount.Text = "0";
			// 
			// CalledCount
			// 
			this.CalledCount.AutoSize = true;
			this.CalledCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.CalledCount.Location = new System.Drawing.Point(339, 39);
			this.CalledCount.Name = "CalledCount";
			this.CalledCount.Size = new System.Drawing.Size(16, 17);
			this.CalledCount.TabIndex = 13;
			this.CalledCount.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(240, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Times Called:";
			// 
			// labelTotalCount
			// 
			this.labelTotalCount.AutoSize = true;
			this.labelTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelTotalCount.Location = new System.Drawing.Point(202, 4);
			this.labelTotalCount.Name = "labelTotalCount";
			this.labelTotalCount.Size = new System.Drawing.Size(16, 17);
			this.labelTotalCount.TabIndex = 15;
			this.labelTotalCount.Text = "0";
			// 
			// LabelTotal
			// 
			this.LabelTotal.AutoSize = true;
			this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelTotal.Location = new System.Drawing.Point(127, 4);
			this.LabelTotal.Name = "LabelTotal";
			this.LabelTotal.Size = new System.Drawing.Size(40, 17);
			this.LabelTotal.TabIndex = 14;
			this.LabelTotal.Text = "Total";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(684, 24);
			this.menuStrip1.TabIndex = 16;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.saveToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loadToolStripMenuItem.Text = "Open...";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			this.saveToolStripMenuItem1.Visible = false;
			this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.LabelTotal);
			this.panel1.Controls.Add(this.CalledCount);
			this.panel1.Controls.Add(this.labelTotalCount);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.LabelLetters);
			this.panel1.Controls.Add(this.LabelNumbers);
			this.panel1.Controls.Add(this.LabelWords);
			this.panel1.Controls.Add(this.LabelLines);
			this.panel1.Controls.Add(this.LabelWordsCount);
			this.panel1.Controls.Add(this.LabelOther);
			this.panel1.Controls.Add(this.LabelLinesCount);
			this.panel1.Controls.Add(this.labelLettersCount);
			this.panel1.Controls.Add(this.LabelOtherCount);
			this.panel1.Controls.Add(this.labelNumbersCount);
			this.panel1.Location = new System.Drawing.Point(12, 602);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(660, 54);
			this.panel1.TabIndex = 17;
			// 
			// Parser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 661);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textbox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Parser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Untitled - Parser";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox textbox1;
		private System.Windows.Forms.Label LabelLetters;
		private System.Windows.Forms.Label LabelNumbers;
		private System.Windows.Forms.Label LabelWords;
		private System.Windows.Forms.Label LabelLines;
		private System.Windows.Forms.Label LabelOther;
		private System.Windows.Forms.Label labelLettersCount;
		private System.Windows.Forms.Label labelNumbersCount;
		private System.Windows.Forms.Label LabelOtherCount;
		private System.Windows.Forms.Label LabelLinesCount;
		private System.Windows.Forms.Label LabelWordsCount;
		private System.Windows.Forms.Label CalledCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTotalCount;
		private System.Windows.Forms.Label LabelTotal;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
	}
}

