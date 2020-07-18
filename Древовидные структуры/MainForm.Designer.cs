namespace Древовидные_структуры
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Список городов");
            this.label1 = new System.Windows.Forms.Label();
            this.treeView_Catalog = new System.Windows.Forms.TreeView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Information = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Структура &каталога";
            // 
            // treeView_Catalog
            // 
            this.treeView_Catalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_Catalog.Location = new System.Drawing.Point(16, 30);
            this.treeView_Catalog.Name = "treeView_Catalog";
            treeNode4.Name = "list_of_sities";
            treeNode4.Tag = "";
            treeNode4.Text = "Список городов";
            this.treeView_Catalog.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView_Catalog.Size = new System.Drawing.Size(417, 331);
            this.treeView_Catalog.TabIndex = 1;
            this.treeView_Catalog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Catalog_AfterSelect);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(6, 19);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(95, 30);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "&Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(6, 60);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(95, 30);
            this.button_change.TabIndex = 1;
            this.button_change.Text = "&Изменить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(6, 101);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(95, 30);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "&Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "И&нформация";
            // 
            // tb_Information
            // 
            this.tb_Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Information.Location = new System.Drawing.Point(16, 396);
            this.tb_Information.Name = "tb_Information";
            this.tb_Information.ReadOnly = true;
            this.tb_Information.Size = new System.Drawing.Size(527, 20);
            this.tb_Information.TabIndex = 5;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(6, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(95, 30);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "&Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(6, 55);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(95, 30);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "&Загрузить";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_change);
            this.groupBox1.Location = new System.Drawing.Point(439, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элемент";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.button_save);
            this.groupBox2.Controls.Add(this.button_load);
            this.groupBox2.Location = new System.Drawing.Point(439, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 93);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Каталог";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Information);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView_Catalog);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.Text = "Древовидная структура";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView_Catalog;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Information;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

