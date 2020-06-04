using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rspuzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		int r1 = 0;
		int r2 = 0;
		int r3 = 0;
		int r4 = 0;
		int r5 = 0;

		int c1 = 0;
		int c2 = 0;
		int c3 = 0;
		int c4 = 0;
		int c5 = 0;

		public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			for (int i = 0; i < (1 << 25); i++)
			{
				int[] rows = new int[5];
				for (int j = 0; j < 5; j++)
				{
					int temp_i = i >> (5 * j);
					for (int k = 0; k < 5; k++)
					{
						rows[j] += (k + 1) * ((temp_i >> k) & 0b1);
					}
				}

				int[] columns = new int[5];
				for (int j = 0; j < 5; j++)
				{
					for (int k = j; k < 25; k += 5)
					{
						columns[j] += ((i >> k) & 0b1) * (((k - j) / 5) + 1);
					}
				}

				if (rows[0] == r1 && rows[1] == r2 && rows[2] == r3 && rows[3] == r4 && rows[4] == r5
					&& columns[0] == c1 && columns[1] == c2 && columns[2] == c3 && columns[3] == c4 && columns[4] == c5)
				{
					if ((i & 0b0000000000000000000000001) >> 00 == 1) r1c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r1c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000000000000010) >> 01 == 1) r1c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r1c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000000000000100) >> 02 == 1) r1c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r1c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000000000001000) >> 03 == 1) r1c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r1c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000000000010000) >> 04 == 1) r1c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r1c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000000000100000) >> 05 == 1) r2c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r2c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000000001000000) >> 06 == 1) r2c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r2c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000000010000000) >> 07 == 1) r2c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r2c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000000100000000) >> 08 == 1) r2c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r2c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000001000000000) >> 09 == 1) r2c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r2c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000010000000000) >> 10 == 1) r3c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r3c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000000100000000000) >> 11 == 1) r3c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r3c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000001000000000000) >> 12 == 1) r3c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r3c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000010000000000000) >> 13 == 1) r3c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r3c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000000100000000000000) >> 14 == 1) r3c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r3c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000001000000000000000) >> 15 == 1) r4c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r4c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000010000000000000000) >> 16 == 1) r4c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r4c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000000100000000000000000) >> 17 == 1) r4c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r4c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000001000000000000000000) >> 18 == 1) r4c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r4c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000010000000000000000000) >> 19 == 1) r4c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r4c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0000100000000000000000000) >> 20 == 1) r5c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r5c1.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0001000000000000000000000) >> 21 == 1) r5c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r5c2.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0010000000000000000000000) >> 22 == 1) r5c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r5c3.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b0100000000000000000000000) >> 23 == 1) r5c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r5c4.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
					if ((i & 0b1000000000000000000000000) >> 24 == 1) r5c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.Black); else r5c5.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);

					return;
				}
			}

		}

		private void r1_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try {
				r1 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void r2_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				r2 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void r3_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				r3 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void r4_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				r4 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void r5_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				r5 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void c1_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				c1 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void c2_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				c2 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void c3_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				c3 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void c4_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				c4 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}

		private void c5_changed(object sender, TextChangedEventArgs e)
		{
			TextBox t = (TextBox)sender;
			string text = t.Text;
			try
			{
				c5 = Int32.Parse(text);
			}
			catch (Exception error) { }
		}
	}
}
