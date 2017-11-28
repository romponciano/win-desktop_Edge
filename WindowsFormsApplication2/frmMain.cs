using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;                  //
using Emgu.CV.CvEnum;           // usual Emgu Cv imports
using Emgu.CV.Structure;        //
using Emgu.CV.UI;               //
using WindowsFormsApplication2;

namespace edge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // ------------------------------- DECLARANDO FORMS ---------------------------------------------------
        // formulario Sobre.cs
        private frmSobre varfrmSobre = null;
        // --------------------------- FIM DECLARANDO FORMS ---------------------------------------------------
        // ------------------------------- DECLARANDO VARIAVEIS GLOBAIS ---------------------------------------
        public bool canny = true;
        public bool sobel = false;
        public bool mudar = false;
        Mat imgOriginal;
        // --------------------------- FIM DECLARANDO VARIAVEIS GLOBAIS ---------------------------------------


        // -------------------------------------------- MENU --------------------------------------------------
        // abrir imagem
        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult drChosenFile;

            drChosenFile = ofdOpenFile.ShowDialog();

            if (drChosenFile != DialogResult.OK || ofdOpenFile.FileName == "")
            {
                lblmsg.Text = "file not chosen";
                return;
            }

            try
            {
                imgOriginal = new Mat(ofdOpenFile.FileName, LoadImageType.Color);
                lblmsg.Text = "imagem aberta com sucesso!";
            }
            catch (Exception ex)
            {
                lblmsg.Text = "unable to open image, error: " + ex.Message;
                return;
            }

            if (imgOriginal == null)
            {
                lblmsg.Text = "unable to open image";
                return;
            }

            // aparecer img original
            ibOriginal.Image = imgOriginal;

            if (canny)
            {
                AlgoritmoCanny(imgOriginal);
                lblnomeAlg.Text = "Algoritmo de Canny";
            }
            else if (sobel)
            {
                AlgoritmoSobel(imgOriginal);
                lblnomeAlg.Text = "Operador de Sobel";

            }
        }

        // sair 
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Deseja encerrar a aplicação?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // tipo canny
        private void passoAPassoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.varfrmSobre = new frmSobre();
            this.varfrmSobre.TopLevel = false;
            this.varfrmSobre.Visible = true;
            this.Controls.Add(this.varfrmSobre);
            this.AjustarTamanhoForm();
            passoAPassoToolStripMenuItem.Checked = true;
            diretoToolStripMenuItem.Checked = false;
            canny = true;
            sobel = false;
        }

        // tipo sobel
        private void diretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.varfrmSobre = new frmSobre();
            this.varfrmSobre.TopLevel = false;
            this.varfrmSobre.Visible = true;
            this.Controls.Add(this.varfrmSobre);
            this.AjustarTamanhoForm();
            diretoToolStripMenuItem.Checked = true;
            passoAPassoToolStripMenuItem.Checked = false;
            canny = false;
            sobel = true;
        }

        // menu salvar
        private void salverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        // ---------------------------------------- FIM MENU --------------------------------------------------


        // ---------------------------------------- FUNÇÕES E MÉTODOS -----------------------------------------
        // bugs para ajustar 
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        // fim bugs para ajustar

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            this.AjustarTamanhoForm();
        }

        private void AjustarTamanhoForm()
        {
            this.varfrmSobre.Location = new Point(
                    this.ClientSize.Width - this.varfrmSobre.Width,
                    this.ClientSize.Height - this.varfrmSobre.Height + 16
                );
        }

        // funcao canny
        private void AlgoritmoCanny(Mat img)
        {
            Mat imgGrayscale = new Mat(img.Size, DepthType.Cv8U, 1);
            Mat imgBlurred = new Mat(img.Size, DepthType.Cv8U, 1);
            // morph
            Mat kernel1 = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(1, 1));
            Mat imgMorph = new Mat(img.Size, DepthType.Cv8U, 1);
            // end morph
            Mat imgCanny = new Mat(img.Size, DepthType.Cv8U, 1);

            
            CvInvoke.CvtColor(img, imgGrayscale, ColorConversion.Bgr2Gray);
            CvInvoke.GaussianBlur(imgGrayscale, imgBlurred, new Size(5, 5), 2000, 2000, BorderType.Replicate);
            CvInvoke.MorphologyEx(imgBlurred, imgMorph, MorphOp.Dilate, kernel1, new Point(-1, -1), 1, BorderType.Replicate, new MCvScalar());

            CvInvoke.Canny(imgBlurred, imgCanny, 150, 20, 3, true);

            ibCanny.Image = imgCanny;
        }

        // funcao sobel
        private void AlgoritmoSobel(Mat img)
        {
            Image<Gray, byte> iSobel;
            Mat imgBlurred = new Mat(img.Size, DepthType.Cv8U, 1);
            Mat imgGrayscale = new Mat(img.Size, DepthType.Cv8U, 1);

            CvInvoke.GaussianBlur(img, imgBlurred, new Size(3, 3), 0, 0);
            CvInvoke.CvtColor(imgBlurred, imgGrayscale, ColorConversion.Bgr2Gray);
            iSobel = imgGrayscale.ToImage<Gray, byte>();

            Image<Gray, float> sobel = iSobel.Sobel(0, 1, 3).Add(iSobel.Sobel(1, 0, 3)).AbsDiff(new Gray(0.0));
            ibCanny.Image = new Image<Bgr, Byte>(sobel.ToBitmap());

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }
        // ------------------------------------- FIM FUNÇÕES E MÉTODOS -----------------------------------------


    } // end class


}   // end namespace