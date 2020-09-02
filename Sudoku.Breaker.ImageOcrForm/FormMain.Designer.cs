namespace Sudoku.Breaker.ImageOcrForm
{
    partial class FormMain
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
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.pictureBoxSrc = new System.Windows.Forms.PictureBox();
            this.labelResult = new System.Windows.Forms.TextBox();
            this.buttonByHand01 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(713, 12);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Text = "Import...";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Enabled = false;
            this.buttonProcess.Location = new System.Drawing.Point(713, 42);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseMnemonic = false;
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // pictureBoxSrc
            // 
            this.pictureBoxSrc.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxSrc.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSrc.Name = "pictureBoxSrc";
            this.pictureBoxSrc.Size = new System.Drawing.Size(695, 441);
            this.pictureBoxSrc.TabIndex = 3;
            this.pictureBoxSrc.TabStop = false;
            this.pictureBoxSrc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseDown);
            this.pictureBoxSrc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseMove);
            this.pictureBoxSrc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseUp);
            // 
            // labelResult
            // 
            this.labelResult.Enabled = false;
            this.labelResult.Location = new System.Drawing.Point(713, 163);
            this.labelResult.Multiline = true;
            this.labelResult.Name = "labelResult";
            this.labelResult.ReadOnly = true;
            this.labelResult.Size = new System.Drawing.Size(75, 275);
            this.labelResult.TabIndex = 5;
            // 
            // buttonByHand01
            // 
            this.buttonByHand01.Location = new System.Drawing.Point(714, 101);
            this.buttonByHand01.Name = "buttonByHand01";
            this.buttonByHand01.Size = new System.Drawing.Size(75, 23);
            this.buttonByHand01.TabIndex = 6;
            this.buttonByHand01.Text = "By hand";
            this.buttonByHand01.UseVisualStyleBackColor = true;
            this.buttonByHand01.Click += new System.EventHandler(this.buttonByHand01_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonByHand01);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.pictureBoxSrc);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonImport);
            this.Name = "FormMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.PictureBox pictureBoxSrc;
        private System.Windows.Forms.TextBox labelResult;
        private System.Windows.Forms.Button buttonByHand01;
    }
}

