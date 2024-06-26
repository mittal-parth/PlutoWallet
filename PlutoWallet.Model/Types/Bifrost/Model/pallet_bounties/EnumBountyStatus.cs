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


namespace Bifrost.NetApi.Generated.Model.pallet_bounties
{
    
    
    /// <summary>
    /// >> BountyStatus
    /// </summary>
    public enum BountyStatus
    {
        
        /// <summary>
        /// >> Proposed
        /// </summary>
        Proposed = 0,
        
        /// <summary>
        /// >> Approved
        /// </summary>
        Approved = 1,
        
        /// <summary>
        /// >> Funded
        /// </summary>
        Funded = 2,
        
        /// <summary>
        /// >> CuratorProposed
        /// </summary>
        CuratorProposed = 3,
        
        /// <summary>
        /// >> Active
        /// </summary>
        Active = 4,
        
        /// <summary>
        /// >> PendingPayout
        /// </summary>
        PendingPayout = 5,
    }
    
    /// <summary>
    /// >> 681 - Variant[pallet_bounties.BountyStatus]
    /// </summary>
    public sealed class EnumBountyStatus : BaseEnumExt<BountyStatus, BaseVoid, BaseVoid, BaseVoid, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
