using Sudoku.Breaker.ImageOcr.Impl.Services;
using Sudoku.Breaker.ImageOcrForm.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku.Breaker.ImageOcrForm
{
    public partial class FormMain : Form
    {
        private ImageContext _imageCtx = new ImageContext();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            var importDialog = new OpenFileDialog();
            importDialog.CheckFileExists = true;
            importDialog.CheckPathExists = true;
            importDialog.Multiselect = false;
            importDialog.RestoreDirectory = true;

            if(importDialog.ShowDialog(this) == DialogResult.OK)
            {
                _imageCtx.FileName = importDialog.FileName;
                pictureBoxSrc.Image = new System.Drawing.Bitmap(_imageCtx.FileName);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if(_imageCtx.Bounds.Width>0 && _imageCtx.Bounds.Height>0)
            {
                var engine = new TesseractProcessImage();
                using (var g = pictureBoxSrc.CreateGraphics())
                {
                    var result = engine.Process(_imageCtx.FileName, _imageCtx.Bounds, g);
                    labelResult.Text = result;
                }
            }
        }

        private void pictureBoxSrc_MouseDown(object sender, MouseEventArgs e)
        {
            buttonProcess.Enabled = false;
            _imageCtx.X0 = e.X;
            _imageCtx.Y0 = e.Y;
            _imageCtx.Drag = true;
        }

        private void pictureBoxSrc_MouseMove(object sender, MouseEventArgs e)
        {
            if(_imageCtx.Drag)
            {
                //using (var g = pictureBoxSrc.CreateGraphics())
                //{
                //    g.DrawRectangle(Pens.Cyan, _imageCtx.X0, _imageCtx.Y0, e.X - _imageCtx.X0, e.Y - _imageCtx.Y0);
                //}
            }
        }

        private void pictureBoxSrc_MouseUp(object sender, MouseEventArgs e)
        {
            if(_imageCtx.Drag)
            {
                _imageCtx.X1 = e.X;
                _imageCtx.Y1 = e.Y;
                _imageCtx.Bounds = new Rectangle(_imageCtx.X0, _imageCtx.Y0, _imageCtx.X1 - _imageCtx.X0, _imageCtx.Y1 - _imageCtx.Y0);
                buttonProcess.Enabled = true;
            }
            _imageCtx.Drag = false;
        }

        private void buttonByHand01_Click(object sender, EventArgs e)
        {
            var frm = new FormByHand01();
            frm.Show(this);
        }
    }
}
