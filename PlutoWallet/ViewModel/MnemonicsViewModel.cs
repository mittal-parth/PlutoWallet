﻿using System;
using Substrate.NetApi;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using static Substrate.NetApi.Mnemonic;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Input;
using Schnorrkel.Keys;

namespace PlutoWallet.ViewModel
{
    public partial class MnemonicsViewModel : ObservableObject //, INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        [ObservableProperty]
        private string[] mnemonicsArray;

        private string password;
        public string Password
        {
            get => password;
            set
            {
                if (password == value)
                    return;

                password = value;

                // tell the user that his password is weak

                //RaisePropertyChanged(nameof(Password));
                //RaisePropertyChanged(nameof(IsStrongPassword));
            }
        }

        public bool IsStrongPassword => true;//!(Password == null || Password == "");

        [ObservableProperty]
        private string[] orderedMnemonicsArray;

        public void Continue()
        {
            var mnemonicsString = string.Empty;
            foreach (var item in MnemonicsArray)
            {
                mnemonicsString += item + " ";
            }

            var keyPair = Mnemonic.GetKeyPairFromMnemonic(mnemonicsString.Trim(), Password, BIP39Wordlist.English, ExpandMode.Ed25519);
            var secret = Mnemonic.GetSecretKeyFromMnemonic(mnemonicsString.Trim(), Password, BIP39Wordlist.English);

            Preferences.Set(
                "privateKey",
                Utils.Bytes2HexString(keyPair.Secret.key.GetBytes())
            );
            Preferences.Set(
                "publicKey",
                 Utils.Bytes2HexString(keyPair.Public.Key)
            );

            Preferences.Set(
                "mnemonics",
                 mnemonicsString.Trim()
            );
        }

        public MnemonicsViewModel()
        {
            mnemonicsArray = Model.KeysModel.GenerateMnemonicsArray();
            orderedMnemonicsArray = new string[mnemonicsArray.Count()];

            int i = 0;
            foreach (string mnemonic in mnemonicsArray)
            {
                orderedMnemonicsArray[i] = ++i + ". " + mnemonic;
            }
        }
    }
}

