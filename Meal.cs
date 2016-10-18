using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Meal : helloworld.Form_orig
    {
        public Meal()
        {
            InitializeComponent();
            label3.Text = item_name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            money = 0;
            insertMoney newform = new insertMoney();
            newform.Show();
            this.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            money = money + get_price(item_name);
            selectMenu newform = new selectMenu();
            newform.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            Notax newform = new Notax();
            newform.Show();
            this.Dispose();
        }
    }
}