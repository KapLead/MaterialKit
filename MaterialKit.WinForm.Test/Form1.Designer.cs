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
            this.checkBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBox1.FontSize = MaterialKit.WinForm.FontSize.Normal;
            this.checkBox1.Foreground = MaterialKit.WinForm.Themes.TypeColor.Foreground;
            this.checkBox1.IsCheck = true;
            this.checkBox1.LineAlignment = System.Drawing.StringAlignment.Center;
            this.checkBox1.Location = new System.Drawing.Point(41, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(410, 23);
            this.checkBox1.Style = MaterialKit.WinForm.FontStyle.Italic;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Title = "KitCheckBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CheckBox checkBox1;
    }
}

