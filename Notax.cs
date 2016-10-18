using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Notax : helloworld.Form_orig
    {
        public Notax()
        {
            InitializeComponent();
            label3.Text = Math.Round(get_price(item_name) / 1.05) + "円";
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
            Tax newform = new Tax();
            newform.Show();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }





    }
}