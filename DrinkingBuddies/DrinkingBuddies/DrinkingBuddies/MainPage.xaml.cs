﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DrinkingBuddies
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnClick(object sender, EventArgs e)
		{
			friendsLabel.IsVisible = true;
		}
	}
}
