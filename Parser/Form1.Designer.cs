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
			this.buttonParse = new System.Windows.Forms.Button();
			this.CalledCount = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelTotalCount = new System.Windows.Forms.Label();
			this.LabelTotal = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textbox1
			// 
			this.textbox1.Location = new System.Drawing.Point(40, 30);
			this.textbox1.Name = "textbox1";
			this.textbox1.Size = new System.Drawing.Size(600, 500);
			this.textbox1.TabIndex = 0;
			this.textbox1.Text = "";
			this.textbox1.TextChanged += new System.EventHandler(this.textbox1_TextChanged);
			// 
			// LabelLetters
			// 
			this.LabelLetters.AutoSize = true;
			this.LabelLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelLetters.Location = new System.Drawing.Point(37, 549);
			this.LabelLetters.Name = "LabelLetters";
			this.LabelLetters.Size = new System.Drawing.Size(60, 17);
			this.LabelLetters.TabIndex = 1;
			this.LabelLetters.Text = "Letters: ";
			// 
			// LabelNumbers
			// 
			this.LabelNumbers.AutoSize = true;
			this.LabelNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelNumbers.Location = new System.Drawing.Point(37, 566);
			this.LabelNumbers.Name = "LabelNumbers";
			this.LabelNumbers.Size = new System.Drawing.Size(69, 17);
			this.LabelNumbers.TabIndex = 2;
			this.LabelNumbers.Text = "Numbers:";
			// 
			// LabelWords
			// 
			this.LabelWords.AutoSize = true;
			this.LabelWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelWords.Location = new System.Drawing.Point(37, 618);
			this.LabelWords.Name = "LabelWords";
			this.LabelWords.Size = new System.Drawing.Size(53, 17);
			this.LabelWords.TabIndex = 3;
			this.LabelWords.Text = "Words:";
			// 
			// LabelLines
			// 
			this.LabelLines.AutoSize = true;
			this.LabelLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelLines.Location = new System.Drawing.Point(37, 635);
			this.LabelLines.Name = "LabelLines";
			this.LabelLines.Size = new System.Drawing.Size(46, 17);
			this.LabelLines.TabIndex = 4;
			this.LabelLines.Text = "Lines:";
			// 
			// LabelOther
			// 
			this.LabelOther.AutoSize = true;
			this.LabelOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelOther.Location = new System.Drawing.Point(37, 584);
			this.LabelOther.Name = "LabelOther";
			this.LabelOther.Size = new System.Drawing.Size(48, 17);
			this.LabelOther.TabIndex = 5;
			this.LabelOther.Text = "Other:";
			// 
			// labelLettersCount
			// 
			this.labelLettersCount.AutoSize = true;
			this.labelLettersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelLettersCount.Location = new System.Drawing.Point(112, 549);
			this.labelLettersCount.Name = "labelLettersCount";
			this.labelLettersCount.Size = new System.Drawing.Size(16, 17);
			this.labelLettersCount.TabIndex = 6;
			this.labelLettersCount.Text = "0";
			// 
			// labelNumbersCount
			// 
			this.labelNumbersCount.AutoSize = true;
			this.labelNumbersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelNumbersCount.Location = new System.Drawing.Point(112, 566);
			this.labelNumbersCount.Name = "labelNumbersCount";
			this.labelNumbersCount.Size = new System.Drawing.Size(16, 17);
			this.labelNumbersCount.TabIndex = 7;
			this.labelNumbersCount.Text = "0";
			// 
			// LabelOtherCount
			// 
			this.LabelOtherCount.AutoSize = true;
			this.LabelOtherCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelOtherCount.Location = new System.Drawing.Point(112, 584);
			this.LabelOtherCount.Name = "LabelOtherCount";
			this.LabelOtherCount.Size = new System.Drawing.Size(16, 17);
			this.LabelOtherCount.TabIndex = 8;
			this.LabelOtherCount.Text = "0";
			// 
			// LabelLinesCount
			// 
			this.LabelLinesCount.AutoSize = true;
			this.LabelLinesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelLinesCount.Location = new System.Drawing.Point(112, 635);
			this.LabelLinesCount.Name = "LabelLinesCount";
			this.LabelLinesCount.Size = new System.Drawing.Size(16, 17);
			this.LabelLinesCount.TabIndex = 9;
			this.LabelLinesCount.Text = "0";
			// 
			// LabelWordsCount
			// 
			this.LabelWordsCount.AutoSize = true;
			this.LabelWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelWordsCount.Location = new System.Drawing.Point(112, 618);
			this.LabelWordsCount.Name = "LabelWordsCount";
			this.LabelWordsCount.Size = new System.Drawing.Size(16, 17);
			this.LabelWordsCount.TabIndex = 10;
			this.LabelWordsCount.Text = "0";
			// 
			// buttonParse
			// 
			this.buttonParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.buttonParse.Location = new System.Drawing.Point(353, 566);
			this.buttonParse.Name = "buttonParse";
			this.buttonParse.Size = new System.Drawing.Size(202, 69);
			this.buttonParse.TabIndex = 11;
			this.buttonParse.Text = "Parse";
			this.buttonParse.UseVisualStyleBackColor = true;
			this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
			// 
			// CalledCount
			// 
			this.CalledCount.AutoSize = true;
			this.CalledCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.CalledCount.Location = new System.Drawing.Point(297, 566);
			this.CalledCount.Name = "CalledCount";
			this.CalledCount.Size = new System.Drawing.Size(16, 17);
			this.CalledCount.TabIndex = 13;
			this.CalledCount.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(202, 566);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Times Called";
			// 
			// labelTotalCount
			// 
			this.labelTotalCount.AutoSize = true;
			this.labelTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelTotalCount.Location = new System.Drawing.Point(112, 601);
			this.labelTotalCount.Name = "labelTotalCount";
			this.labelTotalCount.Size = new System.Drawing.Size(16, 17);
			this.labelTotalCount.TabIndex = 15;
			this.labelTotalCount.Text = "0";
			// 
			// LabelTotal
			// 
			this.LabelTotal.AutoSize = true;
			this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LabelTotal.Location = new System.Drawing.Point(37, 601);
			this.LabelTotal.Name = "LabelTotal";
			this.LabelTotal.Size = new System.Drawing.Size(40, 17);
			this.LabelTotal.TabIndex = 14;
			this.LabelTotal.Text = "Total";
			// 
			// Parser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 661);
			this.Controls.Add(this.labelTotalCount);
			this.Controls.Add(this.LabelTotal);
			this.Controls.Add(this.CalledCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonParse);
			this.Controls.Add(this.LabelWordsCount);
			this.Controls.Add(this.LabelLinesCount);
			this.Controls.Add(this.LabelOtherCount);
			this.Controls.Add(this.labelNumbersCount);
			this.Controls.Add(this.labelLettersCount);
			this.Controls.Add(this.LabelOther);
			this.Controls.Add(this.LabelLines);
			this.Controls.Add(this.LabelWords);
			this.Controls.Add(this.LabelNumbers);
			this.Controls.Add(this.LabelLetters);
			this.Controls.Add(this.textbox1);
			this.Name = "Parser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parser";
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
		private System.Windows.Forms.Button buttonParse;
		private System.Windows.Forms.Label CalledCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTotalCount;
		private System.Windows.Forms.Label LabelTotal;
	}
}

