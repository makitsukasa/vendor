using System;
using System.Collections;
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
		private menuButton[] cartItems = new menuButton[5];
		private categoryButton[] cButtons = new categoryButton[12];
		private menuButton[,] mButtons = new menuButton[6, 3];
		private category category = category.EmptySpace;

		public selectMenu()
		{
			InitializeComponent();
		}
		private void setCategory(category c)
		{
			category = c;
			int[] IDs = categoryTable.getIDs(c);
			int index = 0;
			for(int y = 0; y < 6; y++)
			{
				for(int x = 0; x < 3; x++)
				{
					if(mButtons[y, x] != null)
					{
						if(mButtons[y, x].nameLabel != null)
							this.Controls.Remove(mButtons[y, x].nameLabel);
						if(mButtons[y, x].priceLabel != null)
							this.Controls.Remove(mButtons[y, x].priceLabel);
					}
					if(index >= IDs.Length)
					{
						mButtons[y, x] = new menuButton(0, category.EmptySpace); 
					}
					else {
						mButtons[y, x] = new menuButton(IDs[index], c);
						this.Controls.Add(mButtons[y, x].nameLabel);
						this.Controls.Add(mButtons[y, x].priceLabel);
						mButtons[y, x].setLocation(x * 200, y * 100);
						index++;
					}
				}
			}
			for(int y = 0; y < 5; y++)
			{
				cartItems[y] = new menuButton(0, category.EmptySpace);
				this.Controls.Add(cartItems[y].nameLabel);
				this.Controls.Add(cartItems[y].priceLabel);
			}
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

		private void menu1(object sender, EventArgs e)
		{

		}

		public void addCart(menu m)
		{
			cart.Add(m);
			showCart();
		}

		private void showCart()
		{
			int start;
			if(cart.Count < 5) start = 0;
			else start = cart.Count - 5;

			for(int i = 0; i < 5; i++)
			{
				if(cart.Count <= i) break;
				cartItems[i].setMenuText(cart[start + i].id, category.EmptySpace);
				cartItems[i].setLocation(700, i * 100);
			}
			
		}

		private void buyTicket(object sender, EventArgs e)
		{
			// ボタンを押したときのログを取る
			this.log(this, sender, e);

			int tempMoney = money;
			Button btn = (Button)sender;
			item_name = btn.Text.Replace("\r\n", "");
			buy_ticket(item_name);
			if(money < 0)
			{
				money = tempMoney;
				return;
			}
			Meal newform = new Meal();
			newform.Show();
			this.Dispose();
		}

		private void selectMenu_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			ArrayList l = new ArrayList(Enum.GetValues(typeof(category)));
			int i = r.Next(l.Count);
			setCategory((category)i);
		}

		private void button2_Click(object sender, EventArgs e)
		{

			formEnd newform = new formEnd();
			newform.Show();
			this.Dispose();
		}
	}



	public class menuButton
	{
		public Label nameLabel = new Label();
		public Label priceLabel = new Label();
		private static menuManager mm = new menuManager();
		private menu m;

		public menuButton(int ID, category c)
		{
			setMenuText(ID, c);
		}

		public void setMenuText(int ID, category c)
		{
			m = mm.getMenu(ID);
			nameLabel.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 128);
			nameLabel.Location = new Point(133, 113);
			nameLabel.Name = "nameLabel" + ID;
			nameLabel.Size = new Size(200, 34);
			nameLabel.TabIndex = 0;
			nameLabel.Text = categoryTable.getIDs(c)[0].ToString();
			nameLabel.Click += new EventHandler(click);
			nameLabel.Text = m.name;
			nameLabel.BackColor = categoryTable.getColor(c);

			priceLabel.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 128);
			priceLabel.Location = new Point(133, 133);
			priceLabel.Name = "nameLabel" + ID;
			priceLabel.Size = new Size(200, 34);
			priceLabel.TabIndex = 0;
			priceLabel.Text = categoryTable.getIDs(c)[0].ToString();
			priceLabel.Click += new EventHandler(click);
			priceLabel.Text = m.price.ToString();
			priceLabel.BackColor = Color.White;
		}

		public void setLocation(Point p)
		{
			nameLabel.Location = p;
			priceLabel.Location = p + new Size(0, 30);
		}
		public void setLocation(int x, int y)
		{
			setLocation(new Point(x, y));
		}
		private void click(object sender, EventArgs e)
		{
			(nameLabel.Parent as selectMenu).addCart(m);
		}
	}

}


/*
 
 * control += eventhandler()
 * 
 * 
 form.control.add
 
 */
