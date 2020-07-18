namespace Графика
{
    partial class Main_form
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
            this.components = new System.ComponentModel.Container();
            this.Image_PB = new System.Windows.Forms.PictureBox();
            this.Move_T = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Image_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_PB
            // 
            this.Image_PB.BackColor = System.Drawing.Color.White;
            this.Image_PB.Location = new System.Drawing.Point(1, 1);
            this.Image_PB.Margin = new System.Windows.Forms.Padding(2);
            this.Image_PB.Name = "Image_PB";
            this.Image_PB.Size = new System.Drawing.Size(300, 300);
            this.Image_PB.TabIndex = 0;
            this.Image_PB.TabStop = false;
            this.Image_PB.Click += new System.EventHandler(this.Image_PB_Click);
            // 
            // Move_T
            // 
            this.Move_T.Interval = 50;
            this.Move_T.Tick += new System.EventHandler(this.Move_T_Tick);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 302);
            this.Controls.Add(this.Image_PB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_form";
            this.Text = "Форма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_form_FormClosed);
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Image_PB;
        private System.Windows.Forms.Timer Move_T;
    }
}

