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


namespace Hydration.NetApi.Generated.Model.pallet_referrals.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> CodeRegistered
        /// Referral code has been registered.
        /// </summary>
        CodeRegistered = 0,
        
        /// <summary>
        /// >> CodeLinked
        /// Referral code has been linked to an account.
        /// </summary>
        CodeLinked = 1,
        
        /// <summary>
        /// >> Converted
        /// Asset has been converted to RewardAsset.
        /// </summary>
        Converted = 2,
        
        /// <summary>
        /// >> Claimed
        /// Rewards claimed.
        /// </summary>
        Claimed = 3,
        
        /// <summary>
        /// >> AssetRewardsUpdated
        /// New asset rewards has been set.
        /// </summary>
        AssetRewardsUpdated = 4,
        
        /// <summary>
        /// >> LevelUp
        /// Referrer reached new level.
        /// </summary>
        LevelUp = 5,
    }
    
    /// <summary>
    /// >> 112 - Variant[pallet_referrals.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Hydration.NetApi.Generated.Model.pallet_referrals.AssetAmount, Hydration.NetApi.Generated.Model.pallet_referrals.AssetAmount>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.pallet_referrals.EnumLevel, Hydration.NetApi.Generated.Model.pallet_referrals.FeeDistribution>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Model.pallet_referrals.EnumLevel>>
    {
    }
}
