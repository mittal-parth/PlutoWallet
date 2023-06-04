﻿using System;
using PlutoWallet.Components.Balance;
using PlutoWallet.Components.AddressView;
using PlutoWallet.Components.DAppConnectionView;
using PlutoWallet.Components.Extrinsic;
using PlutoWallet.Components.CalamarView;
using PlutoWallet.Components.Staking;
using System.Collections.ObjectModel;
using PlutoWallet.Components.MessagePopup;

namespace PlutoWallet.Model
{
    public class LayoutItemInfo
    {
        public string Name { get; set; }
        public string PlutoLayoutId { get; set; }
    }

    public class CustomLayoutModel
	{
        public const string DEFAULT_PLUTO_LAYOUT = "plutolayout: [dApp, ExSL, UsdB, PubK, SubK, ChaK, StDash, CalEx]";

        // This constant is used to fetch all items
        public const string ALL_ITEMS = "plutolayout: [dApp, ExSL, UsdB, PubK, SubK, ChaK, StDash, CalEx]";

        public static List<IView> ParsePlutoLayout(string plutoLayoutString)
		{
            if (plutoLayoutString.Substring(0, 13) != "plutolayout: ")
            {
                throw new Exception("Could not parse the PlutoLayout");
            }

            Console.WriteLine(plutoLayoutString);

            plutoLayoutString = plutoLayoutString.Substring(13);

            List<IView> result = new List<IView>();

            if (plutoLayoutString.Length == 2)
            {
                return result;
            }

            string[] layoutItemStrings = plutoLayoutString.Trim(new char[] { '[', ']' }).Split(',');

            foreach (string item in layoutItemStrings)
            {
                result.Add(GetItem(item.Trim()));
            }

            return result;
        }

        public static ObservableCollection<LayoutItemInfo> ParsePlutoLayoutItemInfos(string plutoLayoutString)
        {
            if (plutoLayoutString.Substring(0, 13) != "plutolayout: ")
            {
                throw new Exception("Could not parse the PlutoLayout");
            }

            plutoLayoutString = plutoLayoutString.Substring(13);

            ObservableCollection<LayoutItemInfo> result = new ObservableCollection<LayoutItemInfo>();

            if (plutoLayoutString.Length == 2)
            {
                return result;
            }

            string[] layoutItemStrings = plutoLayoutString.Trim(new char[] { '[', ']' }).Split(',');

            foreach (string item in layoutItemStrings)
            {
                result.Add(GetItemInfo(item.Trim()));
            }

            return result;
        }

        public static void SaveLayout(ObservableCollection<LayoutItemInfo> layoutItemInfos)
        {
            string result = "plutolayout: [";

            foreach (LayoutItemInfo info in layoutItemInfos)
            {
                result += info.PlutoLayoutId + ", ";
            }

            if (layoutItemInfos.Count() > 0)
            {
                result = result.Substring(0, result.Length - 2); // Remove last ", " (comma + space)
            }

            result += "]";

            Preferences.Set("PlutoLayout", result);

            ShowRestartNeededMessage();
        }

        public static void SaveLayout(string layoutItemInfos)
        {
            Preferences.Set("PlutoLayout", layoutItemInfos);

            ShowRestartNeededMessage();
        }

        public static void AddItemToSavedLayout(string itemId)
        {
            string savedLayout = Preferences.Get("PlutoLayout", DEFAULT_PLUTO_LAYOUT);



            string newLayout = savedLayout.Length != 15 ?
                savedLayout.Substring(0, savedLayout.Length - 1) + ", " + itemId + "]" :
                "plutolayout: [" + itemId + "]";

            SaveLayout(newLayout);
        }

        private static void ShowRestartNeededMessage()
        {
            // Tell the user that they need to restart the app.
            var messagePopup = DependencyService.Get<MessagePopupViewModel>();

            messagePopup.Title = "Restart needed";
            messagePopup.Text = "Please, restart PlutoWallet app to apply changes to the layout.";

            messagePopup.IsVisible = true;
        }

        public static IView GetItem(string plutoLayoutId)
        {
            switch (plutoLayoutId)
            {
                case "dApp":
                    return new DAppConnectionView();
                case "ExSL":
                    return new ExtrinsicStatusStackLayout();
                case "UsdB":
                    return new BalanceDashboardView();
                case "PubK":
                    return new AddressView
                    {
                        Title = "Public key",
                        Address = KeysModel.GetPublicKey(),
                    };
                case "SubK":
                    return new AddressView
                    {
                        Title = "Substrate key",
                        Address = KeysModel.GetSubstrateKey(),
                    };
                case "ChaK":
                    return new ChainAddressView();
                case "StDash":
                    return new StakingDashboardView();
                case "CalEx":
                    return new CalamarView();
            }

            throw new Exception("Could not parse the PlutoLayout");
        }

        public static IView GetItemPreview(string plutoLayoutId)
        {
            switch (plutoLayoutId)
            {
                case "dApp":
                    var dAppConnectionViewModel = new DAppConnectionViewModel();
                    dAppConnectionViewModel.Name = "Galaxy Logic Game";
                    dAppConnectionViewModel.Icon = "https://rostislavlitovkin.pythonanywhere.com/logo";
                    dAppConnectionViewModel.IsVisible = true;

                    return new DAppConnectionView(dAppConnectionViewModel);
                case "ExSL":
                    ExtrinsicStatusStackViewModel extrinsicStatusViewModel = new ExtrinsicStatusStackViewModel();
                    var tempExtrinsics = new Dictionary<string, ExtrinsicInfo>();
                    tempExtrinsics.Add("18736389", new ExtrinsicInfo
                    {
                        ExtrinsicId = "18736389",
                        Status = ExtrinsicStatusEnum.InBlock,
                    });

                    tempExtrinsics.Add("18737890", new ExtrinsicInfo
                    {
                        ExtrinsicId = "18737890",
                        Status = ExtrinsicStatusEnum.Success,
                    });

                    extrinsicStatusViewModel.Extrinsics = tempExtrinsics;
                    extrinsicStatusViewModel.Update();

                    return new ExtrinsicStatusStackLayout(extrinsicStatusViewModel, 135);
                case "UsdB":
                    return new BalanceDashboardView();
                case "PubK":
                    return new AddressView
                    {
                        Title = "Public key",
                        Address = KeysModel.GetPublicKey(),
                    };
                case "SubK":
                    return new AddressView
                    {
                        Title = "Substrate key",
                        Address = KeysModel.GetPublicKey(),
                    };
                case "ChaK":
                    return new ChainAddressView();
                case "StDash":
                    return new StakingDashboardView();
                case "CalEx":
                    return new CalamarView();
            }

            throw new Exception("Could not parse the PlutoLayout");
        }

        public static LayoutItemInfo GetItemInfo(string plutoLayoutId)
        {
            switch (plutoLayoutId)
            {
                case "dApp":
                    return new LayoutItemInfo
                    {
                        Name = "dApp connection",
                        PlutoLayoutId = "dApp",
                    };
                case "ExSL":
                    return new LayoutItemInfo
                    {
                        Name = "Extrinsic status",
                        PlutoLayoutId = "ExSL",
                    };
                case "UsdB":
                    return new LayoutItemInfo
                    {
                        Name = "Balance dashboard",
                        PlutoLayoutId = "UsdB",
                    };
                case "PubK":
                    return new LayoutItemInfo
                    {
                        Name = "Public key",
                        PlutoLayoutId = "PubK",
                    };
                case "SubK":
                    return new LayoutItemInfo
                    {
                        Name = "Substrate key",
                        PlutoLayoutId = "SubK",
                    };
                case "ChaK":
                    return new LayoutItemInfo
                    {
                        Name = "Chain specific key",
                        PlutoLayoutId = "ChaK",
                    };
                case "StDash":
                    return new LayoutItemInfo
                    {
                        Name = "Staking dashboard",
                        PlutoLayoutId = "StDash",
                    };
                case "CalEx":
                    return new LayoutItemInfo
                    {
                        Name = "Calamar",
                        PlutoLayoutId = "CalEx",
                    };
            }

            throw new Exception("Could not parse the PlutoLayout");
        }
    }
}

