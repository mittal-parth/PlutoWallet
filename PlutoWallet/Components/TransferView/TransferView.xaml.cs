﻿using PlutoWallet.Model;
using PlutoWallet.Components.AssetSelect;
using PlutoWallet.Components.Extrinsic;
using Substrate.NetApi.Model.Rpc;
using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using System.Numerics;
using PlutoWallet.Types;

namespace PlutoWallet.Components.TransferView;

public partial class TransferView : ContentView
{
	public TransferView()
	{
        var viewModel = DependencyService.Get<TransferViewModel>();

        BindingContext = viewModel;

        InitializeComponent();

        //viewModel.GetFeeAsync();
    }

    async void SignAndTransferClicked(System.Object sender, System.EventArgs e)
    {
        // Send the actual transaction

        var viewModel = DependencyService.Get<TransferViewModel>();
        
        errorLabel.Text = "";

        var client = Model.AjunaClientModel.Client;

        try
        {
            var assetSelectButtonViewModel = DependencyService.Get<AssetSelectButtonViewModel>();

            decimal tempAmount;
            BigInteger amount;
            if (decimal.TryParse(viewModel.Amount, out tempAmount))
            {
                // Double to int conversion
                // Complete later

                amount = (BigInteger)(tempAmount * (decimal)Math.Pow(10, assetSelectButtonViewModel.Decimals));

                Console.WriteLine(assetSelectButtonViewModel.Decimals);
            }
            else
            {
                errorLabel.Text = "Invalid amount value";
                return;
            }

            Method transfer =
                assetSelectButtonViewModel.Pallet == AssetPallet.Native ?
                TransferModel.NativeTransfer(client, viewModel.Address, amount) :
                TransferModel.AssetsTransfer(client, viewModel.Address, assetSelectButtonViewModel.AssetId, amount);

            if ((await KeysModel.GetAccount()).IsSome(out var account))
            {
                Console.WriteLine(account.Value);
                Console.WriteLine(account.KeyType);

                Console.WriteLine("connected: " + client.System.ChainAsync());


                Console.WriteLine("connected: " + client.Properties.TokenSymbol);

                Console.WriteLine("connected: " + client.IsConnected);
                Console.WriteLine("Nonce: " + await client.System.AccountNextIndexAsync(account.Value, default));

                UnCheckedExtrinsic extrinsic = await client.GetExtrinsicParametersAsync(
                    transfer,
                    account,
                    client.DefaultCharge,
                    lifeTime: 64,
                    signed: true,
                    CancellationToken.None);

                byte[] hash = HashExtension.Blake2(extrinsic.GetPayload(client.RuntimeVersion).Encode(), 256);
                byte[] sig = account.Sign(hash);

                Console.WriteLine("Signature: " + Utils.Bytes2HexString(sig).ToLower());
                Console.WriteLine("Signature: " + Utils.Bytes2HexString(hash).ToLower());

                Console.WriteLine(account.Verify(sig, hash));


                string extrinsicId = await client.SubmitExtrinsicAsync(extrinsic, CancellationToken.None);
            }
            else
            {
                // Verification failed, do something about it
            }

            // Hide this layout

            viewModel.SetToDefault();
        }
        catch (Exception ex)
        {
            errorLabel.Text = ex.Message;
            Console.WriteLine(ex);
        }

        
    }

    async void OnBackClicked(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        // Hide this layout
        var viewModel = DependencyService.Get<TransferViewModel>();

        viewModel.SetToDefault();

        qrLayout.Children.Clear();
    }
}
