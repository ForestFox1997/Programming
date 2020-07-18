namespace Свойста_и_индексаторы
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
            this.button_GetArrayB = new System.Windows.Forms.Button();
            this.dgv_matrix_A = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_n = new System.Windows.Forms.NumericUpDown();
            this.nud_m = new System.Windows.Forms.NumericUpDown();
            this.tb_Array_B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matrix_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_m)).BeginInit();
            this.SuspendLayout();
            // 
            // button_GetArrayB
            // 
            this.button_GetArrayB.Location = new System.Drawing.Point(457, 418);
            this.button_GetArrayB.Name = "button_GetArrayB";
            this.button_GetArrayB.Size = new System.Drawing.Size(146, 25);
            this.button_GetArrayB.TabIndex = 1;
            this.button_GetArrayB.Text = "Получить массив B";
            this.button_GetArrayB.UseVisualStyleBackColor = true;
            this.button_GetArrayB.Click += new System.EventHandler(this.button_GetArrayB_Click);
            // 
            // dgv_matrix_A
            // 
            this.dgv_matrix_A.AllowUserToAddRows = false;
            this.dgv_matrix_A.AllowUserToDeleteRows = false;
            this.dgv_matrix_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matrix_A.ColumnHeadersVisible = false;
            this.dgv_matrix_A.Location = new System.Drawing.Point(10, 10);
            this.dgv_matrix_A.MultiSelect = false;
            this.dgv_matrix_A.Name = "dgv_matrix_A";
            this.dgv_matrix_A.RowHeadersVisible = false;
            this.dgv_matrix_A.Size = new System.Drawing.Size(600, 400);
            this.dgv_matrix_A.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество строк(n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество столбцов(m)";
            // 
            // nud_n
            // 
            this.nud_n.Location = new System.Drawing.Point(148, 422);
            this.nud_n.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_n.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_n.Name = "nud_n";
            this.nud_n.Size = new System.Drawing.Size(37, 20);
            this.nud_n.TabIndex = 5;
            this.nud_n.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_n.ValueChanged += new System.EventHandler(this.numericUpDown_n_ValueChanged);
            // 
            // nud_m
            // 
            this.nud_m.Location = new System.Drawing.Point(148, 448);
            this.nud_m.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_m.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_m.Name = "nud_m";
            this.nud_m.Size = new System.Drawing.Size(37, 20);
            this.nud_m.TabIndex = 6;
            this.nud_m.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_m.ValueChanged += new System.EventHandler(this.numericUpDown_m_ValueChanged);
            // 
            // tb_Array_B
            // 
            this.tb_Array_B.Location = new System.Drawing.Point(408, 448);
            this.tb_Array_B.Name = "tb_Array_B";
            this.tb_Array_B.ReadOnly = true;
            this.tb_Array_B.Size = new System.Drawing.Size(196, 20);
            this.tb_Array_B.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Массив B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Array_B);
            this.Controls.Add(this.nud_m);
            this.Controls.Add(this.nud_n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_matrix_A);
            this.Controls.Add(this.button_GetArrayB);
            this.Name = "Form1";
            this.Text = "Свойства и индексаторы";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matrix_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GetArrayB;
        private System.Windows.Forms.DataGridView dgv_matrix_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_n;
        private System.Windows.Forms.NumericUpDown nud_m;
        private System.Windows.Forms.TextBox tb_Array_B;
        private System.Windows.Forms.Label label3;
    }
}

