namespace Kevin_Ma_Lab06_Ex01
{
    partial class AsynchronousProgrammingForm
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
            this.calculateAsynchGroupBox = new System.Windows.Forms.GroupBox();
            this.getFactorialTB = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.getFactorialLbl = new System.Windows.Forms.Label();
            this.checkForEvenOddGroupBox = new System.Windows.Forms.GroupBox();
            this.inputNumberTB = new System.Windows.Forms.TextBox();
            this.checkForEvenOddBtn = new System.Windows.Forms.Button();
            this.inputNumberLbl = new System.Windows.Forms.Label();
            this.displayListAndSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.outputOfValBetwLowAndHighLbl = new System.Windows.Forms.Label();
            this.displayBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.highIndexTB = new System.Windows.Forms.TextBox();
            this.lowIndexTB = new System.Windows.Forms.TextBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.inputHighIndexLbl = new System.Windows.Forms.Label();
            this.inputLowIndexLbl = new System.Windows.Forms.Label();
            this.inputValSearchLbl = new System.Windows.Forms.Label();
            this.generateValuesBtn = new System.Windows.Forms.Button();
            this.charRadioBtn = new System.Windows.Forms.RadioButton();
            this.doublesRadioBtn = new System.Windows.Forms.RadioButton();
            this.intRadioBtn = new System.Windows.Forms.RadioButton();
            this.listDisplayListBox = new System.Windows.Forms.ListBox();
            this.calculateAsynchGroupBox.SuspendLayout();
            this.checkForEvenOddGroupBox.SuspendLayout();
            this.displayListAndSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateAsynchGroupBox
            // 
            this.calculateAsynchGroupBox.Controls.Add(this.getFactorialTB);
            this.calculateAsynchGroupBox.Controls.Add(this.calculateBtn);
            this.calculateAsynchGroupBox.Controls.Add(this.getFactorialLbl);
            this.calculateAsynchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateAsynchGroupBox.Location = new System.Drawing.Point(20, 20);
            this.calculateAsynchGroupBox.Name = "calculateAsynchGroupBox";
            this.calculateAsynchGroupBox.Size = new System.Drawing.Size(263, 120);
            this.calculateAsynchGroupBox.TabIndex = 0;
            this.calculateAsynchGroupBox.TabStop = false;
            this.calculateAsynchGroupBox.Text = "(1) Calculate Asynchronously";
            // 
            // getFactorialTB
            // 
            this.getFactorialTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFactorialTB.Location = new System.Drawing.Point(126, 37);
            this.getFactorialTB.Name = "getFactorialTB";
            this.getFactorialTB.Size = new System.Drawing.Size(124, 22);
            this.getFactorialTB.TabIndex = 1;
            this.getFactorialTB.TabStop = false;
            this.getFactorialTB.TextChanged += new System.EventHandler(this.getFactorialTB_TextChanged);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(10, 80);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(98, 23);
            this.calculateBtn.TabIndex = 1;
            this.calculateBtn.TabStop = false;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // getFactorialLbl
            // 
            this.getFactorialLbl.AutoSize = true;
            this.getFactorialLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFactorialLbl.Location = new System.Drawing.Point(10, 40);
            this.getFactorialLbl.Name = "getFactorialLbl";
            this.getFactorialLbl.Size = new System.Drawing.Size(101, 16);
            this.getFactorialLbl.TabIndex = 0;
            this.getFactorialLbl.Text = "Get Factorial of:";
            // 
            // checkForEvenOddGroupBox
            // 
            this.checkForEvenOddGroupBox.Controls.Add(this.inputNumberTB);
            this.checkForEvenOddGroupBox.Controls.Add(this.checkForEvenOddBtn);
            this.checkForEvenOddGroupBox.Controls.Add(this.inputNumberLbl);
            this.checkForEvenOddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForEvenOddGroupBox.Location = new System.Drawing.Point(20, 150);
            this.checkForEvenOddGroupBox.Name = "checkForEvenOddGroupBox";
            this.checkForEvenOddGroupBox.Size = new System.Drawing.Size(263, 150);
            this.checkForEvenOddGroupBox.TabIndex = 2;
            this.checkForEvenOddGroupBox.TabStop = false;
            this.checkForEvenOddGroupBox.Text = "(2) Check for Even/Odd";
            // 
            // inputNumberTB
            // 
            this.inputNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumberTB.Location = new System.Drawing.Point(115, 37);
            this.inputNumberTB.Name = "inputNumberTB";
            this.inputNumberTB.Size = new System.Drawing.Size(135, 22);
            this.inputNumberTB.TabIndex = 1;
            this.inputNumberTB.TabStop = false;
            this.inputNumberTB.TextChanged += new System.EventHandler(this.inputNumberTB_TextChanged);
            // 
            // checkForEvenOddBtn
            // 
            this.checkForEvenOddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkForEvenOddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForEvenOddBtn.Location = new System.Drawing.Point(90, 80);
            this.checkForEvenOddBtn.Name = "checkForEvenOddBtn";
            this.checkForEvenOddBtn.Size = new System.Drawing.Size(160, 23);
            this.checkForEvenOddBtn.TabIndex = 1;
            this.checkForEvenOddBtn.TabStop = false;
            this.checkForEvenOddBtn.Text = "Check for Even or Odd";
            this.checkForEvenOddBtn.UseVisualStyleBackColor = true;
            // 
            // inputNumberLbl
            // 
            this.inputNumberLbl.AutoSize = true;
            this.inputNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumberLbl.Location = new System.Drawing.Point(10, 40);
            this.inputNumberLbl.Name = "inputNumberLbl";
            this.inputNumberLbl.Size = new System.Drawing.Size(90, 16);
            this.inputNumberLbl.TabIndex = 0;
            this.inputNumberLbl.Text = "Input Number:";
            // 
            // displayListAndSearchGroupBox
            // 
            this.displayListAndSearchGroupBox.Controls.Add(this.listDisplayListBox);
            this.displayListAndSearchGroupBox.Controls.Add(this.richTextBox1);
            this.displayListAndSearchGroupBox.Controls.Add(this.outputOfValBetwLowAndHighLbl);
            this.displayListAndSearchGroupBox.Controls.Add(this.displayBtn);
            this.displayListAndSearchGroupBox.Controls.Add(this.searchBtn);
            this.displayListAndSearchGroupBox.Controls.Add(this.highIndexTB);
            this.displayListAndSearchGroupBox.Controls.Add(this.lowIndexTB);
            this.displayListAndSearchGroupBox.Controls.Add(this.searchTB);
            this.displayListAndSearchGroupBox.Controls.Add(this.inputHighIndexLbl);
            this.displayListAndSearchGroupBox.Controls.Add(this.inputLowIndexLbl);
            this.displayListAndSearchGroupBox.Controls.Add(this.inputValSearchLbl);
            this.displayListAndSearchGroupBox.Controls.Add(this.generateValuesBtn);
            this.displayListAndSearchGroupBox.Controls.Add(this.charRadioBtn);
            this.displayListAndSearchGroupBox.Controls.Add(this.doublesRadioBtn);
            this.displayListAndSearchGroupBox.Controls.Add(this.intRadioBtn);
            this.displayListAndSearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.displayListAndSearchGroupBox.Location = new System.Drawing.Point(303, 20);
            this.displayListAndSearchGroupBox.Name = "displayListAndSearchGroupBox";
            this.displayListAndSearchGroupBox.Size = new System.Drawing.Size(428, 280);
            this.displayListAndSearchGroupBox.TabIndex = 3;
            this.displayListAndSearchGroupBox.TabStop = false;
            this.displayListAndSearchGroupBox.Text = "(3) Display List of Values and Search";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(87, 217);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(328, 49);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // outputOfValBetwLowAndHighLbl
            // 
            this.outputOfValBetwLowAndHighLbl.AutoSize = true;
            this.outputOfValBetwLowAndHighLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputOfValBetwLowAndHighLbl.Location = new System.Drawing.Point(87, 194);
            this.outputOfValBetwLowAndHighLbl.Name = "outputOfValBetwLowAndHighLbl";
            this.outputOfValBetwLowAndHighLbl.Size = new System.Drawing.Size(282, 16);
            this.outputOfValBetwLowAndHighLbl.TabIndex = 4;
            this.outputOfValBetwLowAndHighLbl.Text = "Output of values between Low and High:";
            // 
            // displayBtn
            // 
            this.displayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.displayBtn.Location = new System.Drawing.Point(340, 144);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 23);
            this.displayBtn.TabIndex = 14;
            this.displayBtn.TabStop = false;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchBtn.Location = new System.Drawing.Point(340, 80);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.TabStop = false;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // highIndexTB
            // 
            this.highIndexTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.highIndexTB.Location = new System.Drawing.Point(234, 163);
            this.highIndexTB.Name = "highIndexTB";
            this.highIndexTB.Size = new System.Drawing.Size(100, 22);
            this.highIndexTB.TabIndex = 13;
            this.highIndexTB.TabStop = false;
            this.highIndexTB.TextChanged += new System.EventHandler(this.highIndexTB_TextChanged);
            // 
            // lowIndexTB
            // 
            this.lowIndexTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lowIndexTB.Location = new System.Drawing.Point(234, 123);
            this.lowIndexTB.Name = "lowIndexTB";
            this.lowIndexTB.Size = new System.Drawing.Size(100, 22);
            this.lowIndexTB.TabIndex = 12;
            this.lowIndexTB.TabStop = false;
            this.lowIndexTB.TextChanged += new System.EventHandler(this.lowIndexTB_TextChanged);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchTB.Location = new System.Drawing.Point(234, 80);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 22);
            this.searchTB.TabIndex = 11;
            this.searchTB.TabStop = false;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // inputHighIndexLbl
            // 
            this.inputHighIndexLbl.AutoSize = true;
            this.inputHighIndexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.inputHighIndexLbl.Location = new System.Drawing.Point(123, 166);
            this.inputHighIndexLbl.Name = "inputHighIndexLbl";
            this.inputHighIndexLbl.Size = new System.Drawing.Size(105, 16);
            this.inputHighIndexLbl.TabIndex = 10;
            this.inputHighIndexLbl.Text = "Input High Index:";
            // 
            // inputLowIndexLbl
            // 
            this.inputLowIndexLbl.AutoSize = true;
            this.inputLowIndexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.inputLowIndexLbl.Location = new System.Drawing.Point(127, 126);
            this.inputLowIndexLbl.Name = "inputLowIndexLbl";
            this.inputLowIndexLbl.Size = new System.Drawing.Size(101, 16);
            this.inputLowIndexLbl.TabIndex = 9;
            this.inputLowIndexLbl.Text = "Input Low Index:";
            // 
            // inputValSearchLbl
            // 
            this.inputValSearchLbl.AutoSize = true;
            this.inputValSearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.inputValSearchLbl.Location = new System.Drawing.Point(87, 83);
            this.inputValSearchLbl.Name = "inputValSearchLbl";
            this.inputValSearchLbl.Size = new System.Drawing.Size(141, 16);
            this.inputValSearchLbl.TabIndex = 4;
            this.inputValSearchLbl.Text = "Input Value for Search:";
            // 
            // generateValuesBtn
            // 
            this.generateValuesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateValuesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.generateValuesBtn.Location = new System.Drawing.Point(270, 37);
            this.generateValuesBtn.Name = "generateValuesBtn";
            this.generateValuesBtn.Size = new System.Drawing.Size(145, 23);
            this.generateValuesBtn.TabIndex = 7;
            this.generateValuesBtn.TabStop = false;
            this.generateValuesBtn.Text = "Generate Values";
            this.generateValuesBtn.UseVisualStyleBackColor = true;
            this.generateValuesBtn.Click += new System.EventHandler(this.generateValuesBtn_Click);
            // 
            // charRadioBtn
            // 
            this.charRadioBtn.AutoSize = true;
            this.charRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.charRadioBtn.Location = new System.Drawing.Point(173, 38);
            this.charRadioBtn.Name = "charRadioBtn";
            this.charRadioBtn.Size = new System.Drawing.Size(54, 20);
            this.charRadioBtn.TabIndex = 6;
            this.charRadioBtn.Text = "Char";
            this.charRadioBtn.UseVisualStyleBackColor = true;
            this.charRadioBtn.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // doublesRadioBtn
            // 
            this.doublesRadioBtn.AutoSize = true;
            this.doublesRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.doublesRadioBtn.Location = new System.Drawing.Point(90, 38);
            this.doublesRadioBtn.Name = "doublesRadioBtn";
            this.doublesRadioBtn.Size = new System.Drawing.Size(77, 20);
            this.doublesRadioBtn.TabIndex = 5;
            this.doublesRadioBtn.Text = "Doubles";
            this.doublesRadioBtn.UseVisualStyleBackColor = true;
            this.doublesRadioBtn.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // intRadioBtn
            // 
            this.intRadioBtn.AutoSize = true;
            this.intRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.intRadioBtn.Location = new System.Drawing.Point(10, 38);
            this.intRadioBtn.Name = "intRadioBtn";
            this.intRadioBtn.Size = new System.Drawing.Size(74, 20);
            this.intRadioBtn.TabIndex = 4;
            this.intRadioBtn.Text = "Integers";
            this.intRadioBtn.UseVisualStyleBackColor = true;
            this.intRadioBtn.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // listDisplayListBox
            // 
            this.listDisplayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.listDisplayListBox.FormattingEnabled = true;
            this.listDisplayListBox.ItemHeight = 16;
            this.listDisplayListBox.Location = new System.Drawing.Point(16, 68);
            this.listDisplayListBox.Name = "listDisplayListBox";
            this.listDisplayListBox.Size = new System.Drawing.Size(55, 196);
            this.listDisplayListBox.TabIndex = 16;
            this.listDisplayListBox.DataSourceChanged += new System.EventHandler(this.listDisplayListBox_DataSourceChanged);
            // 
            // AsynchronousProgrammingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 316);
            this.Controls.Add(this.displayListAndSearchGroupBox);
            this.Controls.Add(this.checkForEvenOddGroupBox);
            this.Controls.Add(this.calculateAsynchGroupBox);
            this.Name = "AsynchronousProgrammingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asynchronous Programming";
            this.Load += new System.EventHandler(this.AsynchronousProgrammingForm_Load);
            this.calculateAsynchGroupBox.ResumeLayout(false);
            this.calculateAsynchGroupBox.PerformLayout();
            this.checkForEvenOddGroupBox.ResumeLayout(false);
            this.checkForEvenOddGroupBox.PerformLayout();
            this.displayListAndSearchGroupBox.ResumeLayout(false);
            this.displayListAndSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calculateAsynchGroupBox;
        private System.Windows.Forms.Label getFactorialLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox getFactorialTB;
        private System.Windows.Forms.GroupBox checkForEvenOddGroupBox;
        private System.Windows.Forms.TextBox inputNumberTB;
        private System.Windows.Forms.Button checkForEvenOddBtn;
        private System.Windows.Forms.Label inputNumberLbl;
        private System.Windows.Forms.GroupBox displayListAndSearchGroupBox;
        private System.Windows.Forms.RadioButton charRadioBtn;
        private System.Windows.Forms.RadioButton doublesRadioBtn;
        private System.Windows.Forms.RadioButton intRadioBtn;
        private System.Windows.Forms.Button generateValuesBtn;
        private System.Windows.Forms.Label inputValSearchLbl;
        private System.Windows.Forms.Label inputLowIndexLbl;
        private System.Windows.Forms.Label inputHighIndexLbl;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.TextBox highIndexTB;
        private System.Windows.Forms.TextBox lowIndexTB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Label outputOfValBetwLowAndHighLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listDisplayListBox;
    }
}

