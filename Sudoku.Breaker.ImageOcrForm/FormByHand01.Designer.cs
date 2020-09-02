namespace Sudoku.Breaker.ImageOcrForm
{
    partial class FormByHand01
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.panelInputs.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelMain.Location = new System.Drawing.Point(13, 13);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(414, 414);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            this.panelMain.Layout += new System.Windows.Forms.LayoutEventHandler(this.panelMain_Layout);
            this.panelMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseClick);
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.tableLayoutPanel1);
            this.panelInputs.Location = new System.Drawing.Point(578, 13);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(210, 112);
            this.panelInputs.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button01, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button02, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button03, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button04, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button05, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button06, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button07, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button08, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button09, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRun, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(3, 3);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(44, 23);
            this.button01.TabIndex = 0;
            this.button01.Text = "1";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(53, 3);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(44, 23);
            this.button02.TabIndex = 0;
            this.button02.Text = "2";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // button03
            // 
            this.button03.Location = new System.Drawing.Point(103, 3);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(44, 23);
            this.button03.TabIndex = 0;
            this.button03.Text = "3";
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.button03_Click);
            // 
            // button04
            // 
            this.button04.Location = new System.Drawing.Point(3, 35);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(44, 23);
            this.button04.TabIndex = 0;
            this.button04.Text = "4";
            this.button04.UseVisualStyleBackColor = true;
            this.button04.Click += new System.EventHandler(this.button04_Click);
            // 
            // button05
            // 
            this.button05.Location = new System.Drawing.Point(53, 35);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(44, 23);
            this.button05.TabIndex = 0;
            this.button05.Text = "5";
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.button05_Click);
            // 
            // button06
            // 
            this.button06.Location = new System.Drawing.Point(103, 35);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(44, 23);
            this.button06.TabIndex = 0;
            this.button06.Text = "6";
            this.button06.UseVisualStyleBackColor = true;
            this.button06.Click += new System.EventHandler(this.button06_Click);
            // 
            // button07
            // 
            this.button07.Location = new System.Drawing.Point(3, 67);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(44, 23);
            this.button07.TabIndex = 0;
            this.button07.Text = "7";
            this.button07.UseVisualStyleBackColor = true;
            this.button07.Click += new System.EventHandler(this.button07_Click);
            // 
            // button08
            // 
            this.button08.Location = new System.Drawing.Point(53, 67);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(44, 23);
            this.button08.TabIndex = 0;
            this.button08.Text = "8";
            this.button08.UseVisualStyleBackColor = true;
            this.button08.Click += new System.EventHandler(this.button08_Click);
            // 
            // button09
            // 
            this.button09.Location = new System.Drawing.Point(103, 67);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(44, 23);
            this.button09.TabIndex = 0;
            this.button09.Text = "9";
            this.button09.UseVisualStyleBackColor = true;
            this.button09.Click += new System.EventHandler(this.button09_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(153, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(44, 23);
            this.buttonDel.TabIndex = 0;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(153, 67);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(44, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(578, 141);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(210, 286);
            this.textBoxMessages.TabIndex = 2;
            // 
            // FormByHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.panelMain);
            this.Name = "FormByHand";
            this.Text = "By Hand";
            this.panelInputs.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxMessages;
    }
}