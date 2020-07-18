namespace Многооконность_и_доп.элементы_интерфейса
{
    partial class Dialog_window
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
            this.CarMark_Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CarManufacturer_Value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FuelRate_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CarWeight_Value = new System.Windows.Forms.TextBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Наименование марки";
            // 
            // CarMark_Value
            // 
            this.CarMark_Value.Location = new System.Drawing.Point(251, 22);
            this.CarMark_Value.Name = "CarMark_Value";
            this.CarMark_Value.Size = new System.Drawing.Size(170, 22);
            this.CarMark_Value.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Фирма-производитель";
            // 
            // CarManufacturer_Value
            // 
            this.CarManufacturer_Value.Location = new System.Drawing.Point(251, 49);
            this.CarManufacturer_Value.Name = "CarManufacturer_Value";
            this.CarManufacturer_Value.Size = new System.Drawing.Size(170, 22);
            this.CarManufacturer_Value.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Расход топлива на 100км";
            // 
            // FuelRate_Value
            // 
            this.FuelRate_Value.Location = new System.Drawing.Point(251, 76);
            this.FuelRate_Value.Name = "FuelRate_Value";
            this.FuelRate_Value.Size = new System.Drawing.Size(170, 22);
            this.FuelRate_Value.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Вес автомобиля";
            // 
            // CarWeight_Value
            // 
            this.CarWeight_Value.Location = new System.Drawing.Point(251, 103);
            this.CarWeight_Value.Name = "CarWeight_Value";
            this.CarWeight_Value.Size = new System.Drawing.Size(170, 22);
            this.CarWeight_Value.TabIndex = 7;
            // 
            // Button_OK
            // 
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(70, 139);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(125, 33);
            this.Button_OK.TabIndex = 8;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(269, 139);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(125, 33);
            this.Button_Cancel.TabIndex = 9;
            this.Button_Cancel.Text = "&Отмена";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Dialog_window
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 187);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.CarWeight_Value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FuelRate_Value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarManufacturer_Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarMark_Value);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Dialog_window";
            this.Text = "Диалоговое окно";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dialog_window_FormClosing);
            this.Shown += new System.EventHandler(this.Dialog_window_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        public System.Windows.Forms.TextBox CarMark_Value;
        public System.Windows.Forms.TextBox CarManufacturer_Value;
        public System.Windows.Forms.TextBox FuelRate_Value;
        public System.Windows.Forms.TextBox CarWeight_Value;
    }
}