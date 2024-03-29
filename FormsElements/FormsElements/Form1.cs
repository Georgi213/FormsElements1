﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pb;
        CheckBox cbA, cbB, cbC, cbD;
        RadioButton rb, rb2;
        TextBox txt_box;
        Button mb;
        TabControl tabC;
        TabPage page1, page2, page3;
        ListBox lb;
        bool t = true;
        public Form1()
        {
            this.Height = 500;
            this.Width = 800;
            this.Text = "Vorm elementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("Radiobutton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));
            tn.Nodes.Add(new TreeNode("Listbox"));
            tn.Nodes.Add(new TreeNode("DataGridView"));
            tn.Nodes.Add(new TreeNode("MainMenu"));
            //nupp
            btn = new Button();
            btn.Text = "vajuta siia";
            btn.Location = new Point(150, 30);
            btn.Height = 30;
            btn.Width = 100;
            btn.Click += Btn_Click;
            //label
            lbl = new Label();
            lbl.Text = "Elementide loomine c# abil";
            lbl.Size = new Size(60, 30);
            lbl.Location = new Point(150, 0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;
            //imageBox
            pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.Location = new Point(150, 70);
            pb.ImageLocation = ("../../car.jpg");
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.MouseDoubleClick += Pb_MouseDoubleClick;
            //checkBox
            cbA = new CheckBox();
            cbB = new CheckBox();
            cbC = new CheckBox();
            cbD = new CheckBox();

            cbA.Location = new Point(600, 70);
            cbA.Text = "Font(label)";
            cbB.Text = "Border(PictureBox)";
            cbB.Location = new Point(600, 50);
            cbB.Size = new Size(cbB.Text.Length * 8, 20);
            cbC.Location = new Point(600, 30);
            cbC.Text = "Background color";
            cbD.Location = new Point(600, 90);
            cbD.Text = "Size";
            cbA.MouseClick += CbA_MouseClick;
            cbB.MouseClick += CbB_MouseClick;
            cbC.MouseClick += CbC_MouseClick;
            cbD.MouseClick += CbD_MouseClick;
            //radiobutton
            rb = new RadioButton();
            rb2 = new RadioButton();
            rb.Location = new Point(500, 70);
            rb2.Location = new Point(500, 40);
            rb.Text = "Github";
            rb2.Text = "Moodle";
            rb.MouseClick += Rb_MouseClick;
            rb2.MouseClick += Rb2_MouseClick;
            rb.CheckedChanged += new EventHandler(rb_Checked);
            rb2.CheckedChanged += new EventHandler(rb_Checked);
            //messageBox
            mb = new Button();
            mb.Location = new Point(300, 70);
            mb.Click += Mb_Click;
            //textBox
            txt_box = new TextBox();
            txt_box.Multiline = true;
            txt_box.Text = "Failist";
            txt_box.Location = new Point(300, 300);
            txt_box.Width = 100;
            txt_box.Height = 100;



            tree.Nodes.Add(tn);
            this.Controls.Add(tree);

        }

        private void Mb_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show(
            "Желаете ли вы нажать на кнопку?",
            "Сообщение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (answer == DialogResult.No)
            {
                var answers = MessageBox.Show(
                "Точно не желаете?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }

        }
        private void rb_Checked(object sender, EventArgs e)
        {
            if (rb.Checked)
            {
                this.BackColor = Color.Orange;
                rb2.ForeColor = Color.Yellow;
                rb.ForeColor = Color.Yellow;

            }
            else if (rb2.Checked)
            {
                this.BackColor = Color.DarkGreen;
                rb2.ForeColor = Color.Blue;
                rb.ForeColor = Color.Blue;
            }
        }
        private void Rb2_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://moodle.edu.ee/");
        }
        private void Rb_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/");
        }

        private void CbD_MouseClick(object sender, MouseEventArgs e)
        {
            if (t)
            {
                this.Size = new Size(1000, 1000);
                cbD.Text = "Уменьшаем размер";
                t = false;
            }
            else
            {
                this.Size = new Size(800, 500);
                cbD.Text = "Увеличиваем размер";
                t = true;
            }
        }

        private void CbC_MouseClick(object sender, MouseEventArgs e)
        {
            if (t)
            {
                lbl.Font = new Font("Times New Roman", 7, FontStyle.Bold);
                cbC.Text = "Times New Roman";
                t = false;
            }
            else
            {
                lbl.Font = new Font("Arial", 7, FontStyle.Bold);
                cbC.Text = "Arial";
                t = true;
            }
        }

        private void CbB_MouseClick(object sender, MouseEventArgs e)
        {
            if (t)
            {
                pb.BorderStyle = BorderStyle.Fixed3D;
                cbB.Text = "Fixed3D";
                t = false;
            }
            else
            {
                pb.BorderStyle = BorderStyle.None;
                cbB.Text = "None";
                t = true;
            }

        }

        private void CbA_MouseClick(object sender, MouseEventArgs e)
        {
            if (t)
            {
                BackColor = Color.Green;
                cbA.Text = "Green";
                t = false;
            }
            else
            {
                BackColor = Color.Coral;
                cbA.Text = "Coral";
                t = true;
            }
        }

        private void Pb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("car.jpg");
            list.Add("ford.jpg");
            list.Add("sport.jpg");

            Random rnd = new Random();

            int num = rnd.Next(4);

            pb.ImageLocation = ("../../ford.jpg");
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(76, 0, 153);
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blinov20.thkit.ee/wp/");
            if (MessageBox.Show("Ты уверен, что хочешь закрыть программу?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void menuFile_Select3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuFile_Select2(object sender, EventArgs e)
        {
            pb.Image = Image.FromFile("../../sport.jpg");
        }
        private void Page3_MouseDoubleClick(object sender, EventArgs e)
        {
            string title = "tabP" + (tabC.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tabC.TabPages.Add(tb);
        }
        private void TabC_Selected(object sender,TabControlEventArgs e)
        {
            this.tabC.TabPages.Remove(tabC.SelectedTab);
            
        }
        private void TabC_Doubleclick(object sender,EventArgs e)
        {
            string title = "tabP" + (tabC.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tabC.TabPages.Add(tb);
        }
        private void List_SelectedIndexChanged(object sender,EventArgs e)
        {
            switch (lb.SelectedIndex)
            {
                case 0:
                    lb.BackColor = Color.Green;
                    break;
                case 1:
                    lb.BackColor = Color.Red;
                    break;
                case 2:
                    lb.BackColor = Color.Yellow;
                    break;
                case 3:
                    lb.BackColor = Color.Orange;
                    break;
                case 4:
                    lb.BackColor = Color.Violet;
                    break;
                default:
                    lb.BackColor = Color.Transparent;
                    break;
            }

        }
        private void menuFile_Exit_Select(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Nupp")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text == "label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pb);
            }
            else if (e.Node.Text == "CheckBox")
            {
                this.Controls.Add(cbA);
                this.Controls.Add(cbB);
                this.Controls.Add(cbC);
                this.Controls.Add(cbD);
            }
            else if (e.Node.Text == "Radiobutton")
            {
                this.Controls.Add(rb);
                this.Controls.Add(rb2);
            }
            else if (e.Node.Text == "MessageBox")
            {
                this.Controls.Add(mb);

            }
            
            else if (e.Node.Text == "TabControl")
            {
                tabC = new TabControl();
                tabC.Location = new Point(400, 300);
                tabC.Size = new Size(200, 200);
                page1 = new TabPage("Esimene");
                page2 = new TabPage("Teine");
                page3 = new TabPage("Kolmas");
                page3.DoubleClick += Page3_MouseDoubleClick;

                WebBrowser wb = new WebBrowser();
                wb.Url =new Uri("https://www.tthk.ee/");
                page1.Controls.Add(wb);
                tabC.Controls.Add(page1);
                tabC.Controls.Add(page2);
                tabC.Controls.Add(page3);
                tabC.Selected += TabC_Selected;
                tabC.DoubleClick += TabC_Doubleclick;
                this.Controls.Add(tabC);
               
                
            }
            
            else if (e.Node.Text == "DataGridView")
            {
                DataSet ds = new DataSet("XML fail.Menüü");
                ds.ReadXml(@"..\..\XA.xml");
                DataGridView dg = new DataGridView();
                dg.Width = 300;
                dg.Height = 160;
                dg.Location = new Point(150, 250);
                dg.AutoGenerateColumns = true;
                dg.DataSource = ds;
                dg.DataMember = "food";
                

                this.Controls.Add(dg);
            }
            else if (e.Node.Text == "Listbox")
            {
                lb = new ListBox();
                lb.Items.Add("green");
                lb.Items.Add("red");
                lb.Items.Add("yellow");
                lb.Items.Add("orange");
                lb.Items.Add("violet");
                lb.Location = new Point(150, 120);
                lb.SelectedIndexChanged += List_SelectedIndexChanged;
                this.Controls.Add(lb);
            }
            else if(e.Node.Text=="MainMenu")
            {
                MainMenu menu = new MainMenu();
                MenuItem menuFile = new MenuItem("File");
                menuFile.MenuItems.Add("Exit",new EventHandler(menuFile_Exit_Select));
                menuFile.MenuItems.Add("Image", new EventHandler(menuFile_Select2));
                menuFile.MenuItems.Add("Windows", new EventHandler(menuFile_Select3));
                menu.MenuItems.Add(menuFile);
                this.Menu = menu;
            }
            
            else if (e.Node.Text == "TextBox")
            {
                
                this.Controls.Add(txt_box);
            }

        }
    }
}
//два пункта в меню и 5 цветов в ls_SelectedIndexChanged