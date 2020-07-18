namespace Древовидные_структуры
{
    partial class FormLibraly
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
            this.nud_CountOfBooks = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.tb_CityPopulation = new System.Windows.Forms.Label();
            this.tb_LibralyAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_LibralyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CountOfBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_CountOfBooks
            // 
            this.nud_CountOfBooks.Location = new System.Drawing.Point(15, 121);
            this.nud_CountOfBooks.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_CountOfBooks.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_CountOfBooks.Name = "nud_CountOfBooks";
            this.nud_CountOfBooks.Size = new System.Drawing.Size(124, 20);
            this.nud_CountOfBooks.TabIndex = 5;
            this.nud_CountOfBooks.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(136, 163);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(82, 29);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(30, 163);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(82, 29);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // tb_CityPopulation
            // 
            this.tb_CityPopulation.AutoSize = true;
            this.tb_CityPopulation.Location = new System.Drawing.Point(12, 105);
            this.tb_CityPopulation.Name = "tb_CityPopulation";
            this.tb_CityPopulation.Size = new System.Drawing.Size(92, 13);
            this.tb_CityPopulation.TabIndex = 4;
            this.tb_CityPopulation.Text = "Количесвто книг";
            // 
            // tb_LibralyAdress
            // 
            this.tb_LibralyAdress.Location = new System.Drawing.Point(15, 75);
            this.tb_LibralyAdress.Name = "tb_LibralyAdress";
            this.tb_LibralyAdress.Size = new System.Drawing.Size(213, 20);
            this.tb_LibralyAdress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес библиотеки";
            // 
            // tb_LibralyName
            // 
            this.tb_LibralyName.Location = new System.Drawing.Point(15, 26);
            this.tb_LibralyName.Name = "tb_LibralyName";
            this.tb_LibralyName.Size = new System.Drawing.Size(213, 20);
            this.tb_LibralyName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Библиотека";
            // 
            // FormLibraly
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(261, 210);
            this.Controls.Add(this.tb_LibralyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_CountOfBooks);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.tb_CityPopulation);
            this.Controls.Add(this.tb_LibralyAdress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLibraly";
            this.Text = "FormLibraly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLibraly_FormClosing);
            this.Shown += new System.EventHandler(this.FormLibraly_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CountOfBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label tb_CityPopulation;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nud_CountOfBooks;
        public System.Windows.Forms.TextBox tb_LibralyAdress;
        public System.Windows.Forms.TextBox tb_LibralyName;
        private System.Windows.Forms.Label label2;
    }
}