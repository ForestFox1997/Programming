namespace Древовидные_структуры
{
    partial class FormCity
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CityName = new System.Windows.Forms.TextBox();
            this.tb_StateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.nud_Population = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Population)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование города";
            // 
            // tb_CityName
            // 
            this.tb_CityName.Location = new System.Drawing.Point(16, 30);
            this.tb_CityName.Name = "tb_CityName";
            this.tb_CityName.Size = new System.Drawing.Size(213, 20);
            this.tb_CityName.TabIndex = 1;
            // 
            // tb_StateName
            // 
            this.tb_StateName.Location = new System.Drawing.Point(16, 76);
            this.tb_StateName.Name = "tb_StateName";
            this.tb_StateName.Size = new System.Drawing.Size(213, 20);
            this.tb_StateName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование области";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Число жителей";
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(31, 154);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(82, 29);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(137, 154);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(82, 29);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // nud_Population
            // 
            this.nud_Population.Location = new System.Drawing.Point(16, 121);
            this.nud_Population.Maximum = new decimal(new int[] {
            15000000,
            0,
            0,
            0});
            this.nud_Population.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_Population.Name = "nud_Population";
            this.nud_Population.Size = new System.Drawing.Size(124, 20);
            this.nud_Population.TabIndex = 5;
            this.nud_Population.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // FormCity
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(261, 199);
            this.Controls.Add(this.nud_Population);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_StateName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_CityName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCity";
            this.ShowInTaskbar = false;
            this.Text = "FormCity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCity_FormClosing);
            this.Shown += new System.EventHandler(this.FormCity_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Population)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.TextBox tb_CityName;
        public System.Windows.Forms.TextBox tb_StateName;
        public System.Windows.Forms.NumericUpDown nud_Population;
    }
}