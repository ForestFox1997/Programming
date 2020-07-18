namespace Многооконность_и_доп.элементы_интерфейса
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.label1 = new System.Windows.Forms.Label();
            this.Car_List = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.CoolCar_Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CarInfo_Value = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Add = new System.Windows.Forms.ToolStripButton();
            this.TSB_Change = new System.Windows.Forms.ToolStripButton();
            this.TSB_Del = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Список автомобилей";
            // 
            // Car_List
            // 
            this.Car_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Car_List.FormattingEnabled = true;
            this.Car_List.ItemHeight = 16;
            this.Car_List.Location = new System.Drawing.Point(12, 66);
            this.Car_List.Name = "Car_List";
            this.Car_List.Size = new System.Drawing.Size(358, 420);
            this.Car_List.TabIndex = 3;
            this.Car_List.SelectedIndexChanged += new System.EventHandler(this.Car_List_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_List});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_List
            // 
            this.Menu_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Save,
            this.Menu_Load});
            this.Menu_List.Name = "Menu_List";
            this.Menu_List.Size = new System.Drawing.Size(71, 24);
            this.Menu_List.Text = "&Список";
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.Size = new System.Drawing.Size(210, 26);
            this.Menu_Save.Text = "&Сохранить список";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
            // 
            // Menu_Load
            // 
            this.Menu_Load.Name = "Menu_Load";
            this.Menu_Load.Size = new System.Drawing.Size(210, 26);
            this.Menu_Load.Text = "&Загрузить список";
            this.Menu_Load.Click += new System.EventHandler(this.Menu_Load_Click);
            // 
            // CoolCar_Value
            // 
            this.CoolCar_Value.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CoolCar_Value.Location = new System.Drawing.Point(27, 558);
            this.CoolCar_Value.Name = "CoolCar_Value";
            this.CoolCar_Value.Size = new System.Drawing.Size(326, 22);
            this.CoolCar_Value.TabIndex = 8;
            this.CoolCar_Value.Text = "Ответа нет";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Наиболее эффективный автомобиль";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarInfo_Value});
            this.statusStrip1.Location = new System.Drawing.Point(0, 592);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(382, 22);
            this.statusStrip1.TabIndex = 9;
            // 
            // CarInfo_Value
            // 
            this.CarInfo_Value.Name = "CarInfo_Value";
            this.CarInfo_Value.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Add,
            this.TSB_Change,
            this.TSB_Del});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(382, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Add
            // 
            this.TSB_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Add.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Add.Image")));
            this.TSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Add.Name = "TSB_Add";
            this.TSB_Add.Size = new System.Drawing.Size(32, 32);
            this.TSB_Add.Text = "Добавить";
            this.TSB_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // TSB_Change
            // 
            this.TSB_Change.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Change.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Change.Image")));
            this.TSB_Change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Change.Name = "TSB_Change";
            this.TSB_Change.Size = new System.Drawing.Size(32, 32);
            this.TSB_Change.Text = "Изменить";
            this.TSB_Change.Click += new System.EventHandler(this.Button_Change_Click);
            // 
            // TSB_Del
            // 
            this.TSB_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Del.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Del.Image")));
            this.TSB_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Del.Name = "TSB_Del";
            this.TSB_Del.Size = new System.Drawing.Size(32, 32);
            this.TSB_Del.Text = "Удалить";
            this.TSB_Del.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(19, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(138, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Change_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(257, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "&Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 614);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoolCar_Value);
            this.Controls.Add(this.Car_List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(400, 2400);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Main_form";
            this.Text = "Многооконность и элементы интерфейса";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Car_List;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_List;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_Load;
        private System.Windows.Forms.TextBox CoolCar_Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Add;
        private System.Windows.Forms.ToolStripButton TSB_Change;
        private System.Windows.Forms.ToolStripButton TSB_Del;
        private System.Windows.Forms.ToolStripStatusLabel CarInfo_Value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

