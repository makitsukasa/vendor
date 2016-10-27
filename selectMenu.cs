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
		protected cartButton[] cartButtons = new cartButton[5];
		private categoryButton[,] cButtons = new categoryButton[6, 2];
		private menuButton[,] mButtons = new menuButton[6, 3];
		private category category = category.EmptySpace;

		public selectMenu()
		{
            InitializeComponent();
            availableMoney = money;
            for (int y = 0; y < 5; y++)
            {
                cartButtons[y] = new cartButton(this);
                cartButtons[y].setLocation(800, y * 100);
            }
            int index = 0;
            category[] categs = new category[12];
            foreach (category c in Enum.GetValues(typeof(category)))
            {
                categs[index] = c;
                index++;
            }
            index = 0;
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 2; x++)
                {
                    if (categs[index] != category.EmptySpace)
                    {
                        cButtons[y, x] = new categoryButton(categs[index]);
                        cButtons[y, x].setLocation(x * 100, y * 100);
                        this.Controls.Add(cButtons[y, x]);
                    }
                    index++;
                }
            }
            availableMoneyLabel.Text = availableMoney.ToString() + "円";
            reloadAvailable();

		}
		public void setCategory(category c)
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
						mButtons[y, x] = new menuButton(this, 0, category.EmptySpace); 
					}
					else {
						mButtons[y, x] = new menuButton(this, IDs[index], c);
						mButtons[y, x].setLocation(x * 150 + 300, y * 100);
						index++;
					}
				}
			}
            reloadAvailable();
		}
		
		public void showCart()
		{
			int first, last = cart.Count - 1;
			if(cart.Count < 5)
			{
				first = 0;
			}
			else
			{
				first = cart.Count - 5;
			}

			for(int i = first; i <= last; i++)
			{
				cartButtons[i - first].setMenuText(cart[i].id, category.EmptySpace);
			}
			for(int i = last + 1; i < first + 5; i++)
			{
				cartButtons[i - first].setMenuText(int.MaxValue, category.EmptySpace);
			}

		}

		public void addCart(menu m)
		{
			cart.Add(m);
			availableMoney -= m.price;
			availableMoneyLabel.Text = availableMoney.ToString() + "円";
			showCart();
			reloadAvailable();
		}

		public void removeCart(int index)
		{
			availableMoney += cart[index].price;
			cart.RemoveAt(index);
			showCart();
			reloadAvailable();
		}

		public void reloadAvailable()
        {
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (mButtons[y, x] == null) continue;
                    mButtons[y, x].setAvailableByMoney(availableMoney);
                }
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

		private void buyTicket(object sender, EventArgs e)
		{
			// ボタンを押したときのログを取る
			this.log(this, sender, e);

            int tempMoney = availableMoney;
			Button btn = (Button)sender;
			item_name = btn.Text.Replace("\r\n", "");
			buy_ticket(item_name);
            if (availableMoney < 0)
			{
                availableMoney = tempMoney;
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
			Random rand = new Random();
			ArrayList l = new ArrayList(Enum.GetValues(typeof(category)));
			setCategory((category)rand.Next(l.Count));
		}

		private void button2_Click(object sender, EventArgs e)
		{
            if (cart.Count == 0) return;
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
        protected category c;
        private bool available;

        public menuButton() { }

        public menuButton(Form_orig parent, int ID, category c)
        {
            parent.Controls.Add(nameLabel);
            parent.Controls.Add(priceLabel);
            this.c = c;
            setMenuText(ID, c);
        }

		public void setMenuText(int ID, category c)
		{
			m = mm.getMenu(ID);
			nameLabel.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 128);
			nameLabel.Name = "nameLabel" + ID;
			nameLabel.Size = new Size(200, 34);
			nameLabel.TabIndex = 0;
			nameLabel.Click += new EventHandler(click);
			nameLabel.Text = m.name;

			priceLabel.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 128);
			priceLabel.Name = "nameLabel" + ID;
			priceLabel.Size = new Size(200, 34);
			priceLabel.TabIndex = 0;
			priceLabel.Click += new EventHandler(click);
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            priceLabel.Text = m.price.ToString() + "円";
            if (priceLabel.Text == "0円") priceLabel.Text = "";
			priceLabel.BackColor = Color.White;
		}

		public virtual void setLocation(Point p)
		{
			nameLabel.Location = p;
			priceLabel.Location = p + new Size(0, 30);
		}
		public virtual void setLocation(int x, int y)
		{
			setLocation(new Point(x, y));
		}
		private void click(object sender, EventArgs e)
		{
            if (!available) return;
			(nameLabel.Parent as selectMenu).addCart(m);
		}
        public void setAvailableByMoney(int availableMoney)
        {
            setAvailable(m.price <= availableMoney);
        }
        public void setAvailable(bool flag)
        {
            available = flag;
            if (available) nameLabel.BackColor = categoryTable.getMenuButtonColor(c);
            else nameLabel.BackColor = Color.FromArgb(0xcccccc);
        }
	}

    public class cartButton : menuButton
    {
        protected Label cancelButton = new Label();
		protected Form_orig parent;
		public int index;
		public cartButton() { }
		public cartButton(Form_orig parent, List<menu> cart, int index)
		{
			this.parent = parent;
			parent.Controls.Add(nameLabel);
			parent.Controls.Add(priceLabel);
			this.c = category.EmptySpace;
			setMenuText(cart[index].id, c);

			this.index = index;
			cancelButton.Text = "取り消し";
			cancelButton.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 128);
			cancelButton.BackColor = Color.FromArgb(0x0000ff);
			parent.Controls.Add(cancelButton);
			cancelButton.BringToFront();
			cancelButton.Click += new EventHandler(cancelButtonClick);
		}
        public cartButton(Form_orig parent, int ID = 0, category c = category.EmptySpace)
        {
			this.parent = parent;
            parent.Controls.Add(nameLabel);
            parent.Controls.Add(priceLabel);
            this.c = c;
            setMenuText(ID, c);

            cancelButton.Text = "取り消し";
            cancelButton.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cancelButton.BackColor = Color.FromArgb(0x0000ff);
            parent.Controls.Add(cancelButton);
            cancelButton.BringToFront();
            cancelButton.Click += new EventHandler(cancelButtonClick);
        }
        public override void setLocation(Point p)
        {
            nameLabel.Location = p;
            priceLabel.Location = p + new Size(0, 30);
            cancelButton.Location = p + new Size(0, 50);
        }
        public override void setLocation(int x, int y)
        {
            setLocation(new Point(x, y));
        }
        public void cancelButtonClick(object sender, EventArgs e)
        {
			if(parent is selectMenu)
			{
				(parent as selectMenu).removeCart(index);
				(parent as selectMenu).showCart();
				(parent as selectMenu).reloadAvailable();
			}
        }

    }

}


/*
 
 * control += eventhandler()
 * 
 * 
 form.control.add
 
 */
