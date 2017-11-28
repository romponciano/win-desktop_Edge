namespace edge
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passoAPassoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChosenFile = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelMsg = new System.Windows.Forms.TableLayoutPanel();
            this.msg = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnomeAlg = new System.Windows.Forms.Label();
            this.ibCanny = new Emgu.CV.UI.ImageBox();
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.tab_lay_imgs = new System.Windows.Forms.TableLayoutPanel();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.panelMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCanny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            this.tab_lay_imgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.tipoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            resources.ApplyResources(this.menuPrincipal, "menuPrincipal");
            this.menuPrincipal.Name = "menuPrincipal";
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passoAPassoToolStripMenuItem,
            this.diretoToolStripMenuItem});
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            resources.ApplyResources(this.tipoToolStripMenuItem, "tipoToolStripMenuItem");
            // 
            // passoAPassoToolStripMenuItem
            // 
            this.passoAPassoToolStripMenuItem.Checked = true;
            this.passoAPassoToolStripMenuItem.CheckOnClick = true;
            this.passoAPassoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.passoAPassoToolStripMenuItem.Name = "passoAPassoToolStripMenuItem";
            resources.ApplyResources(this.passoAPassoToolStripMenuItem, "passoAPassoToolStripMenuItem");
            this.passoAPassoToolStripMenuItem.Click += new System.EventHandler(this.passoAPassoToolStripMenuItem_Click);
            // 
            // diretoToolStripMenuItem
            // 
            this.diretoToolStripMenuItem.CheckOnClick = true;
            this.diretoToolStripMenuItem.Name = "diretoToolStripMenuItem";
            resources.ApplyResources(this.diretoToolStripMenuItem, "diretoToolStripMenuItem");
            this.diretoToolStripMenuItem.Click += new System.EventHandler(this.diretoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            resources.ApplyResources(this.sobreToolStripMenuItem, "sobreToolStripMenuItem");
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblChosenFile
            // 
            resources.ApplyResources(this.lblChosenFile, "lblChosenFile");
            this.lblChosenFile.Name = "lblChosenFile";
            this.lblChosenFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMsg
            // 
            resources.ApplyResources(this.panelMsg, "panelMsg");
            this.panelMsg.Controls.Add(this.msg, 0, 0);
            this.panelMsg.Controls.Add(this.lblmsg, 1, 0);
            this.panelMsg.Controls.Add(this.label1, 0, 1);
            this.panelMsg.Controls.Add(this.lblnomeAlg, 1, 1);
            this.panelMsg.Name = "panelMsg";
            // 
            // msg
            // 
            resources.ApplyResources(this.msg, "msg");
            this.msg.Name = "msg";
            // 
            // lblmsg
            // 
            resources.ApplyResources(this.lblmsg, "lblmsg");
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblnomeAlg
            // 
            resources.ApplyResources(this.lblnomeAlg, "lblnomeAlg");
            this.lblnomeAlg.Name = "lblnomeAlg";
            // 
            // ibCanny
            // 
            resources.ApplyResources(this.ibCanny, "ibCanny");
            this.ibCanny.Name = "ibCanny";
            this.ibCanny.TabStop = false;
            // 
            // ibOriginal
            // 
            resources.ApplyResources(this.ibOriginal, "ibOriginal");
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.TabStop = false;
            // 
            // tab_lay_imgs
            // 
            resources.ApplyResources(this.tab_lay_imgs, "tab_lay_imgs");
            this.tab_lay_imgs.Controls.Add(this.ibOriginal, 0, 0);
            this.tab_lay_imgs.Controls.Add(this.ibCanny, 1, 0);
            this.tab_lay_imgs.Controls.Add(this.panelMsg, 0, 1);
            this.tab_lay_imgs.Name = "tab_lay_imgs";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            resources.ApplyResources(this.abrirToolStripMenuItem, "abrirToolStripMenuItem");
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click_1);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChosenFile);
            this.Controls.Add(this.tab_lay_imgs);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmMain";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panelMsg.ResumeLayout(false);
            this.panelMsg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCanny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            this.tab_lay_imgs.ResumeLayout(false);
            this.tab_lay_imgs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diretoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passoAPassoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lblChosenFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tab_lay_imgs;
        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibCanny;
        private System.Windows.Forms.Label lblnomeAlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.TableLayoutPanel panelMsg;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    }
}

