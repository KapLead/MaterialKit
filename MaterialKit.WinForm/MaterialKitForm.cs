using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using MaterialKit.WinForm.Action;
using MaterialKit.WinForm.GraphicsDraws;
using MaterialKit.WinForm.Properties;
using MaterialKit.WinForm.Themes;

namespace MaterialKit.WinForm
{
    public partial class MaterialKitForm : Form
    {

        /// <summary> Иконка окна </summary>
        [Category("Kit")]
        public Image IconKit 
        {
            get => pictureBox1.BackgroundImage;
            set=> pictureBox1.BackgroundImage = value;
        }    
        

        private System.ComponentModel.IContainer components = null;
        private Panel panelTitleHeader;
        private Panel panelTitleName;
        private Panel panel3;
        public Button buttonCloseForm;
        public Button buttonMinimizeForm;
        public Button buttonNormalForm;
        private PictureBox pictureBox1;
        private MoveControl moved;

        public MaterialKitForm()
        {
            InitializeComponent();
            Thema.KitChangeThema += ThemaOnKitChangeThema;
            Load += ThemaOnKitChangeThema;
            moved = new MoveControl(this, new Control[]{ panelTitleName, panelTitleHeader, pictureBox1 });
        }

        private void ThemaOnKitChangeThema(object sender, EventArgs e)
        {
            panelTitleName.BackColor = Thema.Default.Shema.BackAccept.Darker(Persent._20);
            panelTitleHeader.BackColor = Thema.Default.Shema.BackAccept;
        }



        private void InitializeComponent()
        {
            this.panelTitleHeader = new System.Windows.Forms.Panel();
            this.panelTitleName = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinimizeForm = new System.Windows.Forms.Button();
            this.buttonNormalForm = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.panelTitleHeader.SuspendLayout();
            this.panelTitleName.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleHeader
            // 
            this.panelTitleHeader.Controls.Add(this.pictureBox1);
            this.panelTitleHeader.Controls.Add(this.panelTitleName);
            this.panelTitleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleHeader.Location = new System.Drawing.Point(0, 0);
            this.panelTitleHeader.Name = "panelTitleHeader";
            this.panelTitleHeader.Size = new System.Drawing.Size(800, 59);
            this.panelTitleHeader.TabIndex = 0;
            // 
            // panelTitleName
            // 
            this.panelTitleName.Controls.Add(this.panel3);
            this.panelTitleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleName.Location = new System.Drawing.Point(0, 0);
            this.panelTitleName.Name = "panelTitleName";
            this.panelTitleName.Size = new System.Drawing.Size(800, 26);
            this.panelTitleName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonMinimizeForm);
            this.panel3.Controls.Add(this.buttonNormalForm);
            this.panel3.Controls.Add(this.buttonCloseForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(673, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 26);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MaterialKit.WinForm.Properties.Resources.application;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinimizeForm
            // 
            this.buttonMinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimizeForm.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeForm.Image = global::MaterialKit.WinForm.Properties.Resources.closeMin;
            this.buttonMinimizeForm.Location = new System.Drawing.Point(49, 0);
            this.buttonMinimizeForm.Name = "buttonMinimizeForm";
            this.buttonMinimizeForm.Size = new System.Drawing.Size(26, 26);
            this.buttonMinimizeForm.TabIndex = 2;
            this.buttonMinimizeForm.UseVisualStyleBackColor = true;
            this.buttonMinimizeForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonNormalForm
            // 
            this.buttonNormalForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNormalForm.FlatAppearance.BorderSize = 0;
            this.buttonNormalForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNormalForm.Image = global::MaterialKit.WinForm.Properties.Resources.closeMax;
            this.buttonNormalForm.Location = new System.Drawing.Point(75, 0);
            this.buttonNormalForm.Name = "buttonNormalForm";
            this.buttonNormalForm.Size = new System.Drawing.Size(26, 26);
            this.buttonNormalForm.TabIndex = 1;
            this.buttonNormalForm.UseVisualStyleBackColor = true;
            this.buttonNormalForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Image = global::MaterialKit.WinForm.Properties.Resources.closeYellow;
            this.buttonCloseForm.Location = new System.Drawing.Point(101, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(26, 26);
            this.buttonCloseForm.TabIndex = 0;
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // MaterialKitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTitleHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialKitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialKitForm";
            this.panelTitleHeader.ResumeLayout(false);
            this.panelTitleName.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal?FormWindowState.Maximized:WindowState = FormWindowState.Normal;
            buttonNormalForm.Image = WindowState == FormWindowState.Normal ? Resources.closeMax : Resources.closeNormal;
        }
        private void buttonCloseForm_Click(object sender, EventArgs e) => Close();
        private void button2_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

    }
}
