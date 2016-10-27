using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
	public enum category { Udon, Soba, Ramen, EmptySpace, Don, Curry, Big, Small, Rice, Soup, Salad, Dessert };

	public static class categoryTable
	{
		public static int[] getIDs(category c)
		{
			switch(c)
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
			default: return new int[] {};
			}
		}
		public static string getName(category c)
		{
			switch(c)
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
			default: return "";
			}
		}
		public static Point getLocation(category c)
		{
			switch(c)
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
        public static Color getColor(category c)
        {
            switch (c)
            {
                case category.Udon:
                case category.Soba:
                case category.Ramen:
                    return Color.Yellow;
                case category.Curry:
                case category.Don:
                    return Color.Red;
                case category.Big:
                case category.Small:
                case category.Rice:
                case category.Soup:
                case category.Salad:
                case category.Dessert:
                    return Color.Orange;
                default:
                    return Color.White;
            }
        }
        public static Color getMenuButtonColor(category c)
        {
            switch (c)
            {
                case category.Udon:
                case category.Soba:
                case category.Ramen:
                    return Color.FromArgb(0xff, 0xff, 0x33);
                case category.Curry:
                case category.Don:
                    return Color.FromArgb(0xff, 0x33, 0x33);
                case category.Big:
                case category.Small:
                case category.Rice:
                case category.Soup:
                case category.Salad:
                case category.Dessert:
                    return Color.FromArgb(0xff, 0x99, 0x33);
                default:
                    return Color.White;
            }
        }

	}

	public class categoryButton : Label
	{
		private int[] IDs;
        private category c;
		public categoryButton(category c)
		{
            this.c = c;
            Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 128);
            BackColor = categoryTable.getColor(c);
            Text = categoryTable.getName(c);
			IDs = categoryTable.getIDs(c);
			Location = categoryTable.getLocation(c);
            Click += new EventHandler(click);
		}
        public void setLocation(Point p)
        {
            this.Location = p;
        }

        public void setLocation(int x, int y)
        {
            setLocation(new Point(x, y));
        }

        private void click(object sender, EventArgs e)
        {
            (this.Parent as selectMenu).setCategory(c);
        }



	}

}
