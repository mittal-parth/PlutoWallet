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


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_common.crowdloan.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Created
        /// Create a new crowdloaning campaign.
        /// </summary>
        Created = 0,
        
        /// <summary>
        /// >> Contributed
        /// Contributed to a crowd sale.
        /// </summary>
        Contributed = 1,
        
        /// <summary>
        /// >> Withdrew
        /// Withdrew full balance of a contributor.
        /// </summary>
        Withdrew = 2,
        
        /// <summary>
        /// >> PartiallyRefunded
        /// The loans in a fund have been partially dissolved, i.e. there are some left
        /// over child keys that still need to be killed.
        /// </summary>
        PartiallyRefunded = 3,
        
        /// <summary>
        /// >> AllRefunded
        /// All loans in a fund have been refunded.
        /// </summary>
        AllRefunded = 4,
        
        /// <summary>
        /// >> Dissolved
        /// Fund is dissolved.
        /// </summary>
        Dissolved = 5,
        
        /// <summary>
        /// >> HandleBidResult
        /// The result of trying to submit a new bid to the Slots pallet.
        /// </summary>
        HandleBidResult = 6,
        
        /// <summary>
        /// >> Edited
        /// The configuration to a crowdloan has been edited.
        /// </summary>
        Edited = 7,
        
        /// <summary>
        /// >> MemoUpdated
        /// A memo has been updated.
        /// </summary>
        MemoUpdated = 8,
        
        /// <summary>
        /// >> AddedToNewRaise
        /// A parachain has been moved to `NewRaise`
        /// </summary>
        AddedToNewRaise = 9,
    }
    
    /// <summary>
    /// >> 511 - Variant[polkadot_runtime_common.crowdloan.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, BaseTuple<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U128>, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Polkadot.NetApi.Generated.Types.Base.EnumResult>, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, BaseTuple<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id>
    {
    }
}
