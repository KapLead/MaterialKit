namespace MaterialKit.WinForm.Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new MaterialKit.WinForm.Controls.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new MaterialKit.WinForm.Controls.Label();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // buttonMinimizeForm
            // 
            this.buttonMinimizeForm.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // buttonNormalForm
            // 
            this.buttonNormalForm.FlatAppearance.BorderSize = 0;
            this.buttonNormalForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // checkBox1
            // 
            this.checkBox1.Accept = MaterialKit.WinForm.Themes.TypeColor.Accept;
            this.checkBox1.Alignment = System.Drawing.StringAlignment.Center;
            this.checkBox1.Background = MaterialKit.WinForm.Themes.TypeColor.Background;
            this.checkBox1.FontSize = MaterialKit.WinForm.FontSize.Small;
            this.checkBox1.Foreground = MaterialKit.WinForm.Themes.TypeColor.Accept;
            this.checkBox1.IsCheck = true;
            this.checkBox1.LineAlignment = System.Drawing.StringAlignment.Center;
            this.checkBox1.Location = new System.Drawing.Point(41, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(366, 32);
            this.checkBox1.Style = MaterialKit.WinForm.FontStyle.BlackItalic;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.TextAlignment = null;
            this.checkBox1.Title = "KitCheckBox лоьлж";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(607, 214);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Accept = MaterialKit.WinForm.Themes.TypeColor.Accept;
            this.label1.Alignment = System.Drawing.StringAlignment.Center;
            this.label1.Background = MaterialKit.WinForm.Themes.TypeColor.Background;
            this.label1.FontSize = MaterialKit.WinForm.FontSize.Normal;
            this.label1.Foreground = MaterialKit.WinForm.Themes.TypeColor.Foreground;
            this.label1.LineAlignment = System.Drawing.StringAlignment.Center;
            this.label1.Location = new System.Drawing.Point(251, 150);
            this.label1.Name = "label1";
            this.label1.ShadowAlign = new System.Drawing.Size(2, 2);
            this.label1.ShadowColor = System.Drawing.Color.Empty;
            this.label1.ShadowShow = true;
            this.label1.Size = new System.Drawing.Size(155, 64);
            this.label1.Style = MaterialKit.WinForm.FontStyle.Black;
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.checkBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private Controls.Label label1;
    }
}

