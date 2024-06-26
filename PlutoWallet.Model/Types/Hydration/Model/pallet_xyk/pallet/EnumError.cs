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


namespace Hydration.NetApi.Generated.Model.pallet_xyk.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> CannotCreatePoolWithSameAssets
        /// It is not allowed to create a pool between same assets.
        /// </summary>
        CannotCreatePoolWithSameAssets = 0,
        
        /// <summary>
        /// >> InsufficientLiquidity
        /// Liquidity has not reached the required minimum.
        /// </summary>
        InsufficientLiquidity = 1,
        
        /// <summary>
        /// >> InsufficientTradingAmount
        /// Amount is less than min trading limit.
        /// </summary>
        InsufficientTradingAmount = 2,
        
        /// <summary>
        /// >> ZeroLiquidity
        /// Liquidity is zero.
        /// </summary>
        ZeroLiquidity = 3,
        
        /// <summary>
        /// >> ZeroInitialPrice
        /// It is not allowed to create a pool with zero initial price.
        /// Not used, kept for backward compatibility
        /// </summary>
        ZeroInitialPrice = 4,
        
        /// <summary>
        /// >> CreatePoolAssetAmountInvalid
        /// Overflow
        /// Not used, kept for backward compatibility
        /// </summary>
        CreatePoolAssetAmountInvalid = 5,
        
        /// <summary>
        /// >> InvalidMintedLiquidity
        /// Overflow
        /// </summary>
        InvalidMintedLiquidity = 6,
        
        /// <summary>
        /// >> InvalidLiquidityAmount
        /// Overflow
        /// </summary>
        InvalidLiquidityAmount = 7,
        
        /// <summary>
        /// >> AssetAmountExceededLimit
        /// Asset amount has exceeded given limit.
        /// </summary>
        AssetAmountExceededLimit = 8,
        
        /// <summary>
        /// >> AssetAmountNotReachedLimit
        /// Asset amount has not reached given limit.
        /// </summary>
        AssetAmountNotReachedLimit = 9,
        
        /// <summary>
        /// >> InsufficientAssetBalance
        /// Asset balance is not sufficient.
        /// </summary>
        InsufficientAssetBalance = 10,
        
        /// <summary>
        /// >> InsufficientPoolAssetBalance
        /// Not enough asset liquidity in the pool.
        /// </summary>
        InsufficientPoolAssetBalance = 11,
        
        /// <summary>
        /// >> InsufficientNativeCurrencyBalance
        /// Not enough core asset liquidity in the pool.
        /// </summary>
        InsufficientNativeCurrencyBalance = 12,
        
        /// <summary>
        /// >> TokenPoolNotFound
        /// Liquidity pool for given assets does not exist.
        /// </summary>
        TokenPoolNotFound = 13,
        
        /// <summary>
        /// >> TokenPoolAlreadyExists
        /// Liquidity pool for given assets already exists.
        /// </summary>
        TokenPoolAlreadyExists = 14,
        
        /// <summary>
        /// >> AddAssetAmountInvalid
        /// Overflow
        /// </summary>
        AddAssetAmountInvalid = 15,
        
        /// <summary>
        /// >> RemoveAssetAmountInvalid
        /// Overflow
        /// </summary>
        RemoveAssetAmountInvalid = 16,
        
        /// <summary>
        /// >> SellAssetAmountInvalid
        /// Overflow
        /// </summary>
        SellAssetAmountInvalid = 17,
        
        /// <summary>
        /// >> BuyAssetAmountInvalid
        /// Overflow
        /// </summary>
        BuyAssetAmountInvalid = 18,
        
        /// <summary>
        /// >> FeeAmountInvalid
        /// Overflow
        /// </summary>
        FeeAmountInvalid = 19,
        
        /// <summary>
        /// >> CannotApplyDiscount
        /// Overflow
        /// </summary>
        CannotApplyDiscount = 20,
        
        /// <summary>
        /// >> MaxOutRatioExceeded
        /// Max fraction of pool to buy in single transaction has been exceeded.
        /// </summary>
        MaxOutRatioExceeded = 21,
        
        /// <summary>
        /// >> MaxInRatioExceeded
        /// Max fraction of pool to sell in single transaction has been exceeded.
        /// </summary>
        MaxInRatioExceeded = 22,
        
        /// <summary>
        /// >> Overflow
        /// Overflow
        /// </summary>
        Overflow = 23,
        
        /// <summary>
        /// >> CannotCreatePool
        /// Pool cannot be created due to outside factors.
        /// </summary>
        CannotCreatePool = 24,
    }
    
    /// <summary>
    /// >> 542 - Variant[pallet_xyk.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
