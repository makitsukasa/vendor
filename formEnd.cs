using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class formEnd : helloworld.Form_orig
    {
		cartButton_formEnd[] cartButtons = new cartButton_formEnd[5];
        public formEnd()
        {
            InitializeComponent();
            for (int y = 0; y < Math.Min(5, cart.Count); y++)
			{
				cartButtons[y] = new cartButton_formEnd(this);
				cartButtons[y].setLocation(100, y * 100);
			}
			showCart();
		}
        private void showCart()
        {
            int first, last = cart.Count - 1;
            if (cart.Count < 5)
            {
                first = 0;
            }
            else
            {
                first = cart.Count - 5;
            }

            for (int i = first; i <= last; i++)
            {
                cartButtons[i - first].setMenuText(cart[i].id, category.EmptySpace);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cart.Clear();
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            insertMoney newform = new insertMoney();
            newform.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cart.Clear();
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            this.Close();
        }

        private void formEnd_Load(object sender, EventArgs e)
        {
            textBox1.Text = item_name;
            textBox2.Text = money.ToString();
        }

    }

	public class cartButton_formEnd : cartButton
	{
		public cartButton_formEnd(Form_orig parent, List<menu> cart = null, int index = 0)
		{
			this.parent = parent;
			parent.Controls.Add(nameLabel);
			parent.Controls.Add(priceLabel);
			this.c = category.EmptySpace;
			if(cart == null)
			{
				cart = parent.getCart();
			}
			setMenuText(cart[index].id, c);

			this.index = index;
		}
	}

}
