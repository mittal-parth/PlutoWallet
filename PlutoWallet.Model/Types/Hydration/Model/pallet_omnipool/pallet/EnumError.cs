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


namespace Hydration.NetApi.Generated.Model.pallet_omnipool.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> InsufficientBalance
        /// Balance too low
        /// </summary>
        InsufficientBalance = 0,
        
        /// <summary>
        /// >> AssetAlreadyAdded
        /// Asset is already in omnipool
        /// </summary>
        AssetAlreadyAdded = 1,
        
        /// <summary>
        /// >> AssetNotFound
        /// Asset is not in omnipool
        /// </summary>
        AssetNotFound = 2,
        
        /// <summary>
        /// >> MissingBalance
        /// Failed to add token to Omnipool due to insufficient initial liquidity.
        /// </summary>
        MissingBalance = 3,
        
        /// <summary>
        /// >> InvalidInitialAssetPrice
        /// Invalid initial asset price.
        /// </summary>
        InvalidInitialAssetPrice = 4,
        
        /// <summary>
        /// >> BuyLimitNotReached
        /// Slippage protection - minimum limit has not been reached.
        /// </summary>
        BuyLimitNotReached = 5,
        
        /// <summary>
        /// >> SellLimitExceeded
        /// Slippage protection - maximum limit has been exceeded.
        /// </summary>
        SellLimitExceeded = 6,
        
        /// <summary>
        /// >> PositionNotFound
        /// Position has not been found.
        /// </summary>
        PositionNotFound = 7,
        
        /// <summary>
        /// >> InsufficientShares
        /// Insufficient shares in position
        /// </summary>
        InsufficientShares = 8,
        
        /// <summary>
        /// >> NotAllowed
        /// Asset is not allowed to be traded.
        /// </summary>
        NotAllowed = 9,
        
        /// <summary>
        /// >> Forbidden
        /// Signed account is not owner of position instance.
        /// </summary>
        Forbidden = 10,
        
        /// <summary>
        /// >> AssetWeightCapExceeded
        /// Asset weight cap has been exceeded.
        /// </summary>
        AssetWeightCapExceeded = 11,
        
        /// <summary>
        /// >> AssetNotRegistered
        /// Asset is not registered in asset registry
        /// </summary>
        AssetNotRegistered = 12,
        
        /// <summary>
        /// >> InsufficientLiquidity
        /// Provided liquidity is below minimum allowed limit
        /// </summary>
        InsufficientLiquidity = 13,
        
        /// <summary>
        /// >> InsufficientTradingAmount
        /// Traded amount is below minimum allowed limit
        /// </summary>
        InsufficientTradingAmount = 14,
        
        /// <summary>
        /// >> SameAssetTradeNotAllowed
        /// Sell or buy with same asset ids is not allowed.
        /// </summary>
        SameAssetTradeNotAllowed = 15,
        
        /// <summary>
        /// >> HubAssetUpdateError
        /// LRNA update after trade results in positive value.
        /// </summary>
        HubAssetUpdateError = 16,
        
        /// <summary>
        /// >> PositiveImbalance
        /// Imbalance results in positive value.
        /// </summary>
        PositiveImbalance = 17,
        
        /// <summary>
        /// >> InvalidSharesAmount
        /// Amount of shares provided cannot be 0.
        /// </summary>
        InvalidSharesAmount = 18,
        
        /// <summary>
        /// >> InvalidHubAssetTradableState
        /// Hub asset is only allowed to be sold.
        /// </summary>
        InvalidHubAssetTradableState = 19,
        
        /// <summary>
        /// >> AssetRefundNotAllowed
        /// Asset is not allowed to be refunded.
        /// </summary>
        AssetRefundNotAllowed = 20,
        
        /// <summary>
        /// >> MaxOutRatioExceeded
        /// Max fraction of asset to buy has been exceeded.
        /// </summary>
        MaxOutRatioExceeded = 21,
        
        /// <summary>
        /// >> MaxInRatioExceeded
        /// Max fraction of asset to sell has been exceeded.
        /// </summary>
        MaxInRatioExceeded = 22,
        
        /// <summary>
        /// >> PriceDifferenceTooHigh
        /// Max allowed price difference has been exceeded.
        /// </summary>
        PriceDifferenceTooHigh = 23,
        
        /// <summary>
        /// >> InvalidOraclePrice
        /// Invalid oracle price - division by zero.
        /// </summary>
        InvalidOraclePrice = 24,
        
        /// <summary>
        /// >> InvalidWithdrawalFee
        /// Failed to calculate withdrawal fee.
        /// </summary>
        InvalidWithdrawalFee = 25,
        
        /// <summary>
        /// >> FeeOverdraft
        /// More than allowed amount of fee has been transferred.
        /// </summary>
        FeeOverdraft = 26,
        
        /// <summary>
        /// >> SharesRemaining
        /// Token cannot be removed from Omnipool due to shares still owned by other users.
        /// </summary>
        SharesRemaining = 27,
        
        /// <summary>
        /// >> AssetNotFrozen
        /// Token cannot be removed from Omnipool because asset is not frozen.
        /// </summary>
        AssetNotFrozen = 28,
        
        /// <summary>
        /// >> ZeroAmountOut
        /// Calculated amount out from sell trade is zero.
        /// </summary>
        ZeroAmountOut = 29,
    }
    
    /// <summary>
    /// >> 496 - Variant[pallet_omnipool.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}