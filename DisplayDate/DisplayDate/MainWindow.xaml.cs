﻿using System;
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

namespace DisplayDate
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			string naama=5;
			string x = "tamar"
		}

		void OnLoad(object sender, RoutedEventArgs e)
		{
			string nowDate = DateTime.Now.ToString("dd/MMMM/yyyy HH:mm");
			DateLable.Content = nowDate;
			int y = 6;
		}
	}


}
