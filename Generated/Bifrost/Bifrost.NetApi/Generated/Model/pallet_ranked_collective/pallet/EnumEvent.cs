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


namespace Bifrost.NetApi.Generated.Model.pallet_ranked_collective.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> MemberAdded
        /// A member `who` has been added.
        /// </summary>
        MemberAdded = 0,
        
        /// <summary>
        /// >> RankChanged
        /// The member `who`se rank has been changed to the given `rank`.
        /// </summary>
        RankChanged = 1,
        
        /// <summary>
        /// >> MemberRemoved
        /// The member `who` of given `rank` has been removed from the collective.
        /// </summary>
        MemberRemoved = 2,
        
        /// <summary>
        /// >> Voted
        /// The member `who` has voted for the `poll` with the given `vote` leading to an updated
        /// `tally`.
        /// </summary>
        Voted = 3,
        
        /// <summary>
        /// >> MemberExchanged
        /// The member `who` had their `AccountId` changed to `new_who`.
        /// </summary>
        MemberExchanged = 4,
    }
    
    /// <summary>
    /// >> 527 - Variant[pallet_ranked_collective.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Event.MemberAdded);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16>>(Event.RankChanged);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16>>(Event.MemberRemoved);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.pallet_ranked_collective.EnumVoteRecord, Bifrost.NetApi.Generated.Model.pallet_ranked_collective.Tally>>(Event.Voted);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.MemberExchanged);
        }
    }
}
