using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{

    public partial class selectMenu : helloworld.Form_orig
    {

        const int Udon = 0;
        const int Soba = 1;
        const int Ramen = 2;
        const int Don = 4;
        const int Curry = 5;
        const int Big = 6;
        const int Small = 7;
        const int Soup = 8;
        const int Salad = 9;
        const int Dessert = 10;

        public selectMenu()
        {
            InitializeComponent();
            textBox1.Text = money.ToString();
            var c = new categoryButtonGenerator(this);
        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            insertMoney newform = new insertMoney();
            newform.Show();
            this.Dispose();
        }
        */

        private void buyTicket(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            int tempMoney = money;
            Button btn = (Button)sender;
            item_name = btn.Text.Replace("\r\n", "");
            buy_ticket(item_name);
            if (money < 0)
            {
                money = tempMoney;
                return;
            }
            Meal newform = new Meal();
            newform.Show();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void selectMenu_Load(object sender, EventArgs e)
        {
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Udon;
            tabControl1.SelectTab("tabPage4");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Soba;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Ramen;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Don;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Curry;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Big;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Small;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Salad;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Dessert;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }


    }


    public enum category { Udon, Soba, Ramen, EmptySpace, Don, Curry, Big, Small, Rice, Soup, Salad, Dessert };

    public static class categoryTable
    {
        public static int[] getIDs(category c)
        {
            switch (c)
            {
                case category.Udon: return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                case category.Soba: return new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 75 };
                case category.Ramen: return new int[] { 21, 22, 23, 24, 25 };
                case category.Curry: return new int[] { 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37 };
                case category.Don: return new int[] { 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55 };
                case category.Big: return new int[] { 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 75 };
                case category.Small: return new int[] { 76, 77, 78, 79, 80, 81, 81, 82, 83, 84, 85, 86, 87, 89 };
                case category.Rice: return new int[] { 97, 98, 99, 100 };
                case category.Soup: return new int[] { 73, 74, 95, 96 };
                case category.Salad: return new int[] { 88, 90 };
                case category.Dessert: return new int[] { 91, 92, 93, 94 };
                default: return new int[] { };
            }
        }
        public static string getName(category c)
        {
            switch (c)
            {
                case category.Udon: return "うどん";
                case category.Soba: return "そば";
                case category.Ramen: return "ラーメン";
                case category.Curry: return "カレー";
                case category.Don: return "丼";
                case category.Big: return "大皿";
                case category.Small: return "小皿";
                case category.Rice: return "ごはん";
                case category.Soup: return "汁物";
                case category.Salad: return "サラダ";
                case category.Dessert: return "デザート";
                default: return "Error";
            }
        }
        public static Point getLocation(category c)
        {
            switch (c)
            {
                case category.Udon: return new Point(0, 0);
                case category.Soba: return new Point(10, 0);
                case category.Ramen: return new Point(0, 10);
                case category.Curry: return new Point(10, 10);
                case category.Don: return new Point(0, 20);
                case category.Big: return new Point(10, 20);
                case category.Small: return new Point(0, 0);
                case category.Rice: return new Point(0, 0);
                case category.Soup: return new Point(0, 0);
                case category.Salad: return new Point(0, 0);
                case category.Dessert: return new Point(0, 0);
                default: return new Point(0, 0);
            }
        }

    }

    public class categoryButton : System.Windows.Forms.Button
    {
        public int[] IDs;
        public categoryButton(category c)
        {
            Text = categoryTable.getName(c);
            IDs = categoryTable.getIDs(c);
            Location = categoryTable.getLocation(c);
        }
    }

    public class categoryButtonGenerator
    {
        public categoryButtonGenerator(Object parent)
        {
            foreach (category c in Enum.GetValues(typeof(category)))
            {
                if (c == category.EmptySpace) continue;
                var cButton = new categoryButton(c);
                cButton.Controls.Add(cButton);
                (parent as Form_orig).Controls.Add(cButton);
                //cButton.Click += new System.EventHandler(cButton_Click);
            }
        }

        public int cButton_Click()
        {
            int hoge = 0;
            return hoge;
        }
    }

}


/*
 
 * control += eventhandler()
 * 
 * 
 form.control.add
 
 */