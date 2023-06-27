﻿using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Plutonication;

namespace PlutoWallet.Components.ConnectionRequestView
{
	public partial class ConnectionRequestViewModel : ObservableObject
	{
		[ObservableProperty]
		private string name;

		[ObservableProperty]
		private string icon;

		[ObservableProperty]
		private bool isVisible;

		[ObservableProperty]
		private string url;

        [ObservableProperty]
        private string key;

		[ObservableProperty]
		private AccessCredentials accessCredentials;

        public ConnectionRequestViewModel()
		{
			isVisible = false;
		}
	}
}

