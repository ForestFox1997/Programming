namespace Совокупность_объектов_пользовательсткого_класса
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_FirstValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SecondValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lb_Elements = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Первое число списка";
            // 
            // tb_FirstValue
            // 
            this.tb_FirstValue.Location = new System.Drawing.Point(144, 20);
            this.tb_FirstValue.Name = "tb_FirstValue";
            this.tb_FirstValue.Size = new System.Drawing.Size(122, 20);
            this.tb_FirstValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Второе число списка";
            // 
            // tb_SecondValue
            // 
            this.tb_SecondValue.Location = new System.Drawing.Point(144, 53);
            this.tb_SecondValue.Name = "tb_SecondValue";
            this.tb_SecondValue.Size = new System.Drawing.Size(122, 20);
            this.tb_SecondValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Р&езультат";
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(268, 256);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(100, 20);
            this.tb_Result.TabIndex = 9;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(26, 253);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(85, 26);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "&Расчёт";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lb_Elements
            // 
            this.lb_Elements.FormattingEnabled = true;
            this.lb_Elements.Location = new System.Drawing.Point(25, 85);
            this.lb_Elements.Name = "lb_Elements";
            this.lb_Elements.Size = new System.Drawing.Size(241, 160);
            this.lb_Elements.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(283, 85);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 26);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "&Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(283, 129);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(85, 26);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "&Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 298);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_Elements);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_SecondValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_FirstValue);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Совокупность объектов пользовательского класса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_FirstValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SecondValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.ListBox lb_Elements;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
    }
}

