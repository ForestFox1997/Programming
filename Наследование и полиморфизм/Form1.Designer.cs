namespace Наследование_и_полиморфизм
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
            this.listBox_elements = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_change = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_choiceDiameter = new System.Windows.Forms.RadioButton();
            this.radioButton_choiceWidth = new System.Windows.Forms.RadioButton();
            this.radioButton_choiceDisk = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_elements
            // 
            this.listBox_elements.FormattingEnabled = true;
            this.listBox_elements.Location = new System.Drawing.Point(25, 34);
            this.listBox_elements.Name = "listBox_elements";
            this.listBox_elements.Size = new System.Drawing.Size(209, 199);
            this.listBox_elements.TabIndex = 1;
            this.listBox_elements.SelectedIndexChanged += new System.EventHandler(this.listBox_elements_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Список элементов";
            // 
            // button_change
            // 
            this.button_change.Enabled = false;
            this.button_change.Location = new System.Drawing.Point(25, 365);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(209, 29);
            this.button_change.TabIndex = 3;
            this.button_change.Text = "&Изменить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(25, 400);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(209, 29);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "&Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(0, 86);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(209, 29);
            this.button_add.TabIndex = 3;
            this.button_add.Tag = "";
            this.button_add.Text = "&Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(25, 485);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(209, 20);
            this.textBox_result.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Результат";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_choiceDiameter);
            this.groupBox1.Controls.Add(this.radioButton_choiceWidth);
            this.groupBox1.Controls.Add(this.radioButton_choiceDisk);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Location = new System.Drawing.Point(25, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_choiceDiameter
            // 
            this.radioButton_choiceDiameter.AutoSize = true;
            this.radioButton_choiceDiameter.Location = new System.Drawing.Point(11, 63);
            this.radioButton_choiceDiameter.Name = "radioButton_choiceDiameter";
            this.radioButton_choiceDiameter.Size = new System.Drawing.Size(90, 17);
            this.radioButton_choiceDiameter.TabIndex = 2;
            this.radioButton_choiceDiameter.TabStop = true;
            this.radioButton_choiceDiameter.Text = "По ди&аметру";
            this.radioButton_choiceDiameter.UseVisualStyleBackColor = true;
            // 
            // radioButton_choiceWidth
            // 
            this.radioButton_choiceWidth.AutoSize = true;
            this.radioButton_choiceWidth.Location = new System.Drawing.Point(12, 40);
            this.radioButton_choiceWidth.Name = "radioButton_choiceWidth";
            this.radioButton_choiceWidth.Size = new System.Drawing.Size(80, 17);
            this.radioButton_choiceWidth.TabIndex = 1;
            this.radioButton_choiceWidth.TabStop = true;
            this.radioButton_choiceWidth.Text = "По &ширине";
            this.radioButton_choiceWidth.UseVisualStyleBackColor = true;
            // 
            // radioButton_choiceDisk
            // 
            this.radioButton_choiceDisk.AutoSize = true;
            this.radioButton_choiceDisk.Checked = true;
            this.radioButton_choiceDisk.Location = new System.Drawing.Point(12, 16);
            this.radioButton_choiceDisk.Name = "radioButton_choiceDisk";
            this.radioButton_choiceDisk.Size = new System.Drawing.Size(71, 17);
            this.radioButton_choiceDisk.TabIndex = 0;
            this.radioButton_choiceDisk.TabStop = true;
            this.radioButton_choiceDisk.Text = "По ди&ску";
            this.radioButton_choiceDisk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(261, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_elements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_elements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_choiceWidth;
        private System.Windows.Forms.RadioButton radioButton_choiceDisk;
        private System.Windows.Forms.RadioButton radioButton_choiceDiameter;
    }
}

