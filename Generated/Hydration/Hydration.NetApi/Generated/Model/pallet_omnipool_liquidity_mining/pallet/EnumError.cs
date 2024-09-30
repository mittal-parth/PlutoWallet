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


namespace Hydration.NetApi.Generated.Model.pallet_omnipool_liquidity_mining.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> AssetNotFound
        /// Asset is not in the omnipool.
        /// </summary>
        AssetNotFound = 0,
        
        /// <summary>
        /// >> Forbidden
        /// Signed account is not owner of the deposit.
        /// </summary>
        Forbidden = 1,
        
        /// <summary>
        /// >> ZeroClaimedRewards
        /// Rewards to claim are 0.
        /// </summary>
        ZeroClaimedRewards = 2,
        
        /// <summary>
        /// >> InconsistentState
        /// Action cannot be completed because unexpected error has occurred. This should be reported
        /// to protocol maintainers.
        /// </summary>
        InconsistentState = 3,
        
        /// <summary>
        /// >> OracleNotAvailable
        /// Oracle could not be found for requested assets.
        /// </summary>
        OracleNotAvailable = 4,
        
        /// <summary>
        /// >> PriceAdjustmentNotAvailable
        /// Oracle providing `price_adjustment` could not be found for requested assets.
        /// </summary>
        PriceAdjustmentNotAvailable = 5,
    }
    
    /// <summary>
    /// >> 582 - Variant[pallet_omnipool_liquidity_mining.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnumRust<Error>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumError()
        {
				AddTypeDecoder<BaseVoid>(Error.AssetNotFound);
				AddTypeDecoder<BaseVoid>(Error.Forbidden);
				AddTypeDecoder<BaseVoid>(Error.ZeroClaimedRewards);
				AddTypeDecoder<Hydration.NetApi.Generated.Model.pallet_omnipool_liquidity_mining.pallet.EnumInconsistentStateError>(Error.InconsistentState);
				AddTypeDecoder<BaseVoid>(Error.OracleNotAvailable);
				AddTypeDecoder<BaseVoid>(Error.PriceAdjustmentNotAvailable);
        }
    }
}
