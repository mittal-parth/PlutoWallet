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


namespace Hydration.NetApi.Generated.Model.pallet_circuit_breaker.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> InvalidLimitValue
        /// Invalid value for a limit. Limit must be non-zero.
        /// </summary>
        InvalidLimitValue = 0,
        
        /// <summary>
        /// >> LiquidityLimitNotStoredForAsset
        /// Allowed liquidity limit is not stored for asset
        /// </summary>
        LiquidityLimitNotStoredForAsset = 1,
        
        /// <summary>
        /// >> TokenOutflowLimitReached
        /// Token trade outflow per block has been reached
        /// </summary>
        TokenOutflowLimitReached = 2,
        
        /// <summary>
        /// >> TokenInfluxLimitReached
        /// Token trade influx per block has been reached
        /// </summary>
        TokenInfluxLimitReached = 3,
        
        /// <summary>
        /// >> MaxLiquidityLimitPerBlockReached
        /// Maximum pool's liquidity limit per block has been reached
        /// </summary>
        MaxLiquidityLimitPerBlockReached = 4,
        
        /// <summary>
        /// >> NotAllowed
        /// Asset is not allowed to have a limit
        /// </summary>
        NotAllowed = 5,
    }
    
    /// <summary>
    /// >> 518 - Variant[pallet_circuit_breaker.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
