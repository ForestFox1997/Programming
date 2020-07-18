using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Древовидные_структуры.ApplicationStructure;

namespace Древовидные_структуры
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<City> list_of_cities = new List<City>();

        #region Работа с элементами каталога
        private void button_add_Click(object sender, EventArgs e)
        {
            if (treeView_Catalog.SelectedNode != null) //Если выбран какой-то узел дерева
            {
                if (treeView_Catalog.SelectedNode.Level == 0) //Если выбран узел "Список городов"
                {
                    var dialog = new FormCity();
                    dialog.Text = "Добавление города";
                    dialog.tb_CityName.Text = "";
                    dialog.tb_StateName.Text = "";
                    dialog.nud_Population.Value = 100000;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var city = new City()
                        {
                            name = Convert.ToString(dialog.tb_CityName.Text),
                            state = Convert.ToString(dialog.tb_StateName.Text),
                            population = Convert.ToInt32(dialog.nud_Population.Value),
                            libraly_list = new List<Libraly>()
                        };
                        TreeNode treeNode = treeView_Catalog.SelectedNode.Nodes.Add(city.name);
                        treeNode.Nodes.Add(city.state);
                        treeNode.Nodes.Add(Convert.ToString(city.population));
                        treeNode.Nodes.Add("Список библиотек");
                        list_of_cities.Add(city);
                    }
                }
                else if(treeView_Catalog.SelectedNode.Level == 2 && treeView_Catalog.SelectedNode.Index == 2) //Если выбран узел "Список библиотек"
                {
                    var dialog = new FormLibraly();
                    dialog.Text = "Добавление библиотеки";
                    dialog.tb_LibralyAdress.Text = "";
                    dialog.nud_CountOfBooks.Value = 10000;
                    if(dialog.ShowDialog() == DialogResult.OK)
                    {
                        var libraly = new Libraly()
                        {
                            name = Convert.ToString(dialog.tb_LibralyName.Text),
                            address = Convert.ToString(dialog.tb_LibralyAdress.Text),
                            count_of_books = Convert.ToInt32(dialog.nud_CountOfBooks.Value)
                        };
                        var city = list_of_cities.ElementAt(treeView_Catalog.SelectedNode.Parent.Index);
                        city.libraly_list.Add(libraly);
                        TreeNode treeNode = treeView_Catalog.SelectedNode.Nodes.Add(libraly.name);
                        treeNode.Nodes.Add(libraly.address);
                        treeNode.Nodes.Add(Convert.ToString(libraly.count_of_books));
                    }
                }
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (treeView_Catalog.SelectedNode != null)
            {
                if(treeView_Catalog.SelectedNode.Level == 1 || treeView_Catalog.SelectedNode.Level == 3) //Если выбран раздел "Список городов", или "Список библиотек"
                {
                    if(treeView_Catalog.SelectedNode.Level == 1) //Если выбран элемент из "Список городов"
                    {
                        City city = list_of_cities.ElementAt(treeView_Catalog.SelectedNode.Index);
                        var dialog = new FormCity();
                        dialog.Text = "Изменение города";
                        dialog.tb_CityName.Text = city.name;
                        dialog.tb_StateName.Text = city.state;
                        dialog.nud_Population.Value = city.population;
                        if(dialog.ShowDialog() == DialogResult.OK)
                        {
                            city.name = dialog.tb_CityName.Text;
                            city.state = dialog.tb_StateName.Text;
                            city.population = Convert.ToInt32(dialog.nud_Population.Value);
                            treeView_Catalog.SelectedNode.Text = city.name;
                            treeView_Catalog.SelectedNode.Nodes[0].Text = city.state;
                            treeView_Catalog.SelectedNode.Nodes[1].Text = Convert.ToString(city.population);
                        }
                    }
                    else if(treeView_Catalog.SelectedNode.Level == 3) //Если выбран элемент из "Список библиотек"
                    {
                        City city = list_of_cities.ElementAt(treeView_Catalog.SelectedNode.Parent.Parent.Index);
                        Libraly libraly = city.libraly_list[treeView_Catalog.SelectedNode.Index];
                        var dialog = new FormLibraly();
                        dialog.Text = "Изменение библиотеки";
                        dialog.tb_LibralyName.Text = libraly.name;
                        dialog.tb_LibralyAdress.Text = libraly.address;
                        dialog.nud_CountOfBooks.Value = libraly.count_of_books;
                        if(dialog.ShowDialog() == DialogResult.OK)
                        {
                            libraly.name = dialog.tb_LibralyName.Text;
                            libraly.address = dialog.tb_LibralyAdress.Text;
                            libraly.count_of_books = Convert.ToInt32(dialog.nud_CountOfBooks.Value);
                            treeView_Catalog.SelectedNode.Text = libraly.name;
                            treeView_Catalog.SelectedNode.Nodes[0].Text = libraly.address;
                            treeView_Catalog.SelectedNode.Nodes[1].Text = Convert.ToString(libraly.count_of_books);
                        }
                    }
                }

            }
            else
                MessageBox.Show("Изменить можно город, или библиотеку");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (treeView_Catalog.SelectedNode != null)
            {
                if (treeView_Catalog.SelectedNode.Level == 1 || treeView_Catalog.SelectedNode.Level == 3) //Если выбран раздел "Список городов", или "Список библиотек"
                {
                    if (treeView_Catalog.SelectedNode.Level == 1) //Если выбран элемент из "Список городов"
                        list_of_cities.RemoveAt(treeView_Catalog.SelectedNode.Index);
                    else if (treeView_Catalog.SelectedNode.Level == 3) //Если выбран элемент из "Список библиотек"
                    {
                        City city = list_of_cities.ElementAt(treeView_Catalog.SelectedNode.Parent.Parent.Index);
                        city.libraly_list.RemoveAt(treeView_Catalog.SelectedNode.Index);
                    }
                    treeView_Catalog.SelectedNode.Remove();
                }
                else
                    MessageBox.Show("Можно удалить раздел, или книгу");
            }
            else
                MessageBox.Show("Выберите город, или библиотеку для удаления");
        }
        #endregion

        #region Сохранение и загразка каталога
        private void button_save_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Вы уверены, что хотите сохранить список городов в файл?", "", MessageBoxButtons.OKCancel))
            {
                if (list_of_cities.Count != 0)
                    using (var sw = new StreamWriter(File.Open(Application.StartupPath + "/list.txt", FileMode.OpenOrCreate)))
                    {
                        sw.WriteLine(Convert.ToInt32(list_of_cities.Count));
                        for (int i = 0; i < list_of_cities.Count; i++)
                        {
                            var city = list_of_cities[i] as City;
                            sw.WriteLine(city.name);
                            sw.WriteLine(city.state);
                            sw.WriteLine(Convert.ToInt32(city.population));
                            sw.WriteLine(Convert.ToInt32(city.libraly_list.Count));
                            for (int j = 0; j < city.libraly_list.Count; j++)
                            {
                                var libraly = city.libraly_list[j] as Libraly;
                                sw.WriteLine(libraly.name);
                                sw.WriteLine(libraly.address);
                                sw.WriteLine(Convert.ToString(libraly.count_of_books));
                            }
                        }
                    }
                else
                    MessageBox.Show("В каталоге нет элементов для сохранения");
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show("Вы уверены, что хотите загрузить список городов из файла?", "", MessageBoxButtons.OKCancel))
            {
                if (File.Exists(Application.StartupPath + "/list.txt"))
                {
                    using (var sr = new StreamReader(File.Open(Application.StartupPath + "/list.txt", FileMode.Open)))
                    {
                        int переменная = Convert.ToInt32(sr.ReadLine());
                        list_of_cities = new List<City>();
                        for (int i = 0; i < переменная; i++)
                        {
                            var city = new City();
                            list_of_cities.Add(city);
                            city = list_of_cities[i] as City;
                            city.name = sr.ReadLine();
                            city.state = sr.ReadLine();
                            city.population = Convert.ToInt32(sr.ReadLine());
                            city.libraly_list = new List<Libraly>();
                            int count_of_libraly = Convert.ToInt32(sr.ReadLine());
                            for (int j = 0; j < count_of_libraly; j++)
                            {
                                var libraly = new Libraly();
                                city.libraly_list.Add(libraly);
                                libraly = city.libraly_list[j] as Libraly;
                                libraly.name = sr.ReadLine();
                                libraly.address = sr.ReadLine();
                                libraly.count_of_books = Convert.ToInt32(sr.ReadLine());
                            }
                        }
                    }

                    treeView_Catalog.Nodes.Clear();
                    treeView_Catalog.Nodes.Add("Список городов");
                    for (int i = 0; i < list_of_cities.Count; i++)
                    {
                        treeView_Catalog.SelectedNode = treeView_Catalog.Nodes[0];
                        var city = list_of_cities[i] as City;
                        var treeNode = treeView_Catalog.SelectedNode.Nodes.Add(city.name);
                        treeNode.Nodes.Add(city.state);
                        treeNode.Nodes.Add(Convert.ToString(city.population));
                        treeNode.Nodes.Add("Список библиотек");
                        for (int j = 0; j < city.libraly_list.Count; j++)
                        {
                            var libraly = city.libraly_list[j] as Libraly;
                            treeView_Catalog.SelectedNode = treeView_Catalog.Nodes[0].Nodes[i].Nodes[2];
                            treeNode = treeView_Catalog.SelectedNode.Nodes.Add(libraly.name);
                            treeNode.Nodes.Add(libraly.address);
                            treeNode.Nodes.Add(Convert.ToString(libraly.count_of_books));
                        }
                    }
                }
                else
                    MessageBox.Show("Файл со списком отсутствует в папке с программой");
            }
        }

        #endregion

        #region Выбор элемента каталога
        private void treeView_Catalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView_Catalog.SelectedNode.Level)
            {
                case 0:
                    tb_Information.Text = "Это корень каталога";
                    button_add.Enabled = true;
                    button_change.Enabled = false;
                    button_delete.Enabled = false;
                    break;
                case 1:
                    tb_Information.Text = "Выбран город: " + treeView_Catalog.SelectedNode.Text;
                    button_add.Enabled = false;
                    button_change.Enabled = true;
                    button_delete.Enabled = true;
                    break;
                case 2:
                    if (treeView_Catalog.SelectedNode.Index == 0 || treeView_Catalog.SelectedNode.Index == 1)
                    {
                        tb_Information.Text = "Выбран город: " + treeView_Catalog.SelectedNode.Parent.Text;
                        button_add.Enabled = false;
                    }
                    else if (treeView_Catalog.SelectedNode.Index == 2)
                    {
                        tb_Information.Text = "Это список библиотек города " + treeView_Catalog.SelectedNode.Parent.Text;
                        button_add.Enabled = true;
                    }
                    button_change.Enabled = false;
                    button_delete.Enabled = false;
                    break;
                case 3:
                    tb_Information.Text = "Выбрана библиотека \"" + treeView_Catalog.SelectedNode.Text + "\" города " + treeView_Catalog.SelectedNode.Parent.Parent.Text;
                    button_add.Enabled = false;
                    button_change.Enabled = true;
                    button_delete.Enabled = true;
                    break;
                case 4:
                    tb_Information.Text = "Выбрана библиотека \"" + treeView_Catalog.SelectedNode.Parent.Text + "\" города " + treeView_Catalog.SelectedNode.Parent.Parent.Parent.Text;
                    button_add.Enabled = false;
                    button_change.Enabled = false;
                    button_delete.Enabled = false;
                    break;
            }
        }
        #endregion
    }
}
