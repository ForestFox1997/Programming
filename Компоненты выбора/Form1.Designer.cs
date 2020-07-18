namespace Компоненты_выбора
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
            this.Input_Data = new System.Windows.Forms.DataGridView();
            this.N_value = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Select_Rows = new System.Windows.Forms.RadioButton();
            this.Select_Columns = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Select_Positive = new System.Windows.Forms.CheckBox();
            this.Select_Negative = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Calc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.M_value = new System.Windows.Forms.NumericUpDown();
            this.Output_Data = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Input_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_value)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.M_value)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_Data
            // 
            this.Input_Data.AllowUserToAddRows = false;
            this.Input_Data.AllowUserToDeleteRows = false;
            this.Input_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Input_Data.ColumnHeadersVisible = false;
            this.Input_Data.Location = new System.Drawing.Point(22, 50);
            this.Input_Data.Name = "Input_Data";
            this.Input_Data.RowHeadersVisible = false;
            this.Input_Data.RowTemplate.Height = 24;
            this.Input_Data.Size = new System.Drawing.Size(634, 373);
            this.Input_Data.TabIndex = 5;
            // 
            // N_value
            // 
            this.N_value.Location = new System.Drawing.Point(767, 12);
            this.N_value.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.N_value.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.N_value.Name = "N_value";
            this.N_value.Size = new System.Drawing.Size(57, 22);
            this.N_value.TabIndex = 1;
            this.N_value.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.N_value.ValueChanged += new System.EventHandler(this.N_value_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Количество строк";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Select_Rows);
            this.groupBox1.Controls.Add(this.Select_Columns);
            this.groupBox1.Location = new System.Drawing.Point(695, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Определение";
            // 
            // Select_Rows
            // 
            this.Select_Rows.AutoSize = true;
            this.Select_Rows.Location = new System.Drawing.Point(6, 50);
            this.Select_Rows.Name = "Select_Rows";
            this.Select_Rows.Size = new System.Drawing.Size(105, 21);
            this.Select_Rows.TabIndex = 1;
            this.Select_Rows.Text = "По ст&рокам";
            this.Select_Rows.UseVisualStyleBackColor = true;
            // 
            // Select_Columns
            // 
            this.Select_Columns.AutoSize = true;
            this.Select_Columns.Checked = true;
            this.Select_Columns.Location = new System.Drawing.Point(6, 23);
            this.Select_Columns.Name = "Select_Columns";
            this.Select_Columns.Size = new System.Drawing.Size(114, 21);
            this.Select_Columns.TabIndex = 0;
            this.Select_Columns.TabStop = true;
            this.Select_Columns.Text = "По сто&лбцам";
            this.Select_Columns.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Select_Positive);
            this.groupBox2.Controls.Add(this.Select_Negative);
            this.groupBox2.Location = new System.Drawing.Point(691, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Для элементов";
            // 
            // Select_Positive
            // 
            this.Select_Positive.AutoSize = true;
            this.Select_Positive.Location = new System.Drawing.Point(6, 50);
            this.Select_Positive.Name = "Select_Positive";
            this.Select_Positive.Size = new System.Drawing.Size(135, 21);
            this.Select_Positive.TabIndex = 1;
            this.Select_Positive.Text = "&Положительных";
            this.Select_Positive.UseVisualStyleBackColor = true;
            // 
            // Select_Negative
            // 
            this.Select_Negative.AutoSize = true;
            this.Select_Negative.Location = new System.Drawing.Point(6, 23);
            this.Select_Negative.Name = "Select_Negative";
            this.Select_Negative.Size = new System.Drawing.Size(134, 21);
            this.Select_Negative.TabIndex = 0;
            this.Select_Negative.Text = "&Отрицательных";
            this.Select_Negative.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исходная &матрица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Средние значения элементов в матрице";
            // 
            // Button_Calc
            // 
            this.Button_Calc.Location = new System.Drawing.Point(699, 297);
            this.Button_Calc.Name = "Button_Calc";
            this.Button_Calc.Size = new System.Drawing.Size(137, 34);
            this.Button_Calc.TabIndex = 8;
            this.Button_Calc.Text = "&Вычислить";
            this.Button_Calc.UseVisualStyleBackColor = true;
            this.Button_Calc.Click += new System.EventHandler(this.Button_Calc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Кол&ичество столбцов";
            // 
            // M_value
            // 
            this.M_value.Location = new System.Drawing.Point(537, 10);
            this.M_value.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M_value.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M_value.Name = "M_value";
            this.M_value.Size = new System.Drawing.Size(57, 22);
            this.M_value.TabIndex = 3;
            this.M_value.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.M_value.ValueChanged += new System.EventHandler(this.M_value_ValueChanged);
            // 
            // Output_Data
            // 
            this.Output_Data.Location = new System.Drawing.Point(22, 458);
            this.Output_Data.Multiline = true;
            this.Output_Data.Name = "Output_Data";
            this.Output_Data.Size = new System.Drawing.Size(843, 214);
            this.Output_Data.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(886, 687);
            this.Controls.Add(this.Output_Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.M_value);
            this.Controls.Add(this.Button_Calc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N_value);
            this.Controls.Add(this.Input_Data);
            this.Name = "Form1";
            this.Text = "Компоненты выбора";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Input_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_value)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.M_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Input_Data;
        private System.Windows.Forms.NumericUpDown N_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Select_Rows;
        private System.Windows.Forms.RadioButton Select_Columns;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Select_Positive;
        private System.Windows.Forms.CheckBox Select_Negative;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Calc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown M_value;
        private System.Windows.Forms.TextBox Output_Data;
    }
}

