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

			totalAmountTextLabel.Location = new Point(Pixel(75), Pixel(20));
			//totalAmountTextLabel.Size = new Size(Pixel(45), Pixel(15));
			totalAmountTextLabel.Font = new Font("MS UI Gothic", 45F);

			totalAmountLabel.Location = new Point(Pixel(140), Pixel(20));
			//totalAmountLabel.Size = new Size(Pixel(45), Pixel(15));
			totalAmountLabel.Font = new Font("MS UI Gothic", 45F);
			totalAmountLabel.TextAlign = ContentAlignment.MiddleRight;

			moneyTextLabel.Location = new Point(Pixel(75), Pixel(40));
			//moneyTextLabel.Size = new Size(Pixel(90), Pixel(15));
			moneyTextLabel.Font = new Font("MS UI Gothic", 45F);

			moneyLabel.Location = new Point(Pixel(140), Pixel(40));
			//moneyLabel.Size = new Size(Pixel(45), Pixel(15));
			moneyLabel.Font = new Font("MS UI Gothic", 45F);
			moneyLabel.TextAlign = ContentAlignment.MiddleRight;

			changeTextLabel.Location = new Point(Pixel(75), Pixel(65));
			//changeTextLabel.Size = new Size(Pixel(90), Pixel(15));
			changeTextLabel.Font = new Font("MS UI Gothic", 45F);

			changeLabel.Location = new Point(Pixel(140), Pixel(65));
			//changeLabel.Size = new Size(Pixel(45), Pixel(15));
			changeLabel.Font = new Font("MS UI Gothic", 45F);
			changeLabel.TextAlign = ContentAlignment.MiddleRight;

			thanksTextLabel.Location = new Point(Pixel(75), Pixel(95));
			//thanksTextLabel.Size = new Size(Pixel(90), Pixel(10));
			thanksTextLabel.Font = new Font("MS UI Gothic", 38F);

			for (int y = 0; y < Math.Min(5, cart.Count); y++)
			{
				cartButtons[y] = new cartButton_formEnd(this);
				cartButtons[y].setLocation(20, y * 25 + 10);
			}
			showCart();
			moneyLabel.Text = money + "円";
			totalAmountLabel.Text = getTotalAmount() + "円";
			changeLabel.Text = availableMoney + "円";
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

		private int getTotalAmount()
		{
			int total = 0;
			foreach(menu m in cart)
			{
				total += m.price;
			}
			return total;
		}

        private void button2_Click(object sender, EventArgs e)
        {
			money = availableMoney;
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.ClientSize = new System.Drawing.Size(1008, 730);
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
