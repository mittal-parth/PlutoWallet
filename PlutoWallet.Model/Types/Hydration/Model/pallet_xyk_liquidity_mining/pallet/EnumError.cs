//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Hydration.NetApi.Generated.Model.pallet_xyk_liquidity_mining.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> CantFindDepositOwner
        /// Nft pallet didn't return an owner.
        /// </summary>
        CantFindDepositOwner = 0,
        
        /// <summary>
        /// >> InsufficientXykSharesBalance
        /// Account balance of XYK pool shares is not sufficient.
        /// </summary>
        InsufficientXykSharesBalance = 1,
        
        /// <summary>
        /// >> XykPoolDoesntExist
        /// XYK pool does not exist
        /// </summary>
        XykPoolDoesntExist = 2,
        
        /// <summary>
        /// >> NotDepositOwner
        /// Account is not deposit owner.
        /// </summary>
        NotDepositOwner = 3,
        
        /// <summary>
        /// >> CantGetXykAssets
        /// XYK did not return assets for given pool id
        /// </summary>
        CantGetXykAssets = 4,
        
        /// <summary>
        /// >> DepositDataNotFound
        /// Deposit data not found
        /// </summary>
        DepositDataNotFound = 5,
        
        /// <summary>
        /// >> ZeroClaimedRewards
        /// Calculated reward to claim is 0.
        /// </summary>
        ZeroClaimedRewards = 6,
        
        /// <summary>
        /// >> AssetNotInAssetPair
        /// Asset is not in the `AssetPair`.
        /// </summary>
        AssetNotInAssetPair = 7,
        
        /// <summary>
        /// >> InvalidAssetPair
        /// Provided `AssetPair` is not used by the deposit.
        /// </summary>
        InvalidAssetPair = 8,
        
        /// <summary>
        /// >> AssetNotRegistered
        /// Asset is not registered in asset registry.
        /// </summary>
        AssetNotRegistered = 9,
        
        /// <summary>
        /// >> FailToGetPotId
        /// Failed to calculate `pot`'s account.
        /// </summary>
        FailToGetPotId = 10,
    }
    
    /// <summary>
    /// >> 581 - Variant[pallet_xyk_liquidity_mining.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
