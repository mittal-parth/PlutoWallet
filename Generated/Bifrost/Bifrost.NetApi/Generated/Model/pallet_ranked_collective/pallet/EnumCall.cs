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
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> add_member
        /// Introduce a new member.
        /// 
        /// - `origin`: Must be the `AddOrigin`.
        /// - `who`: Account of non-member which will become a member.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        add_member = 0,
        
        /// <summary>
        /// >> promote_member
        /// Increment the rank of an existing member by one.
        /// 
        /// - `origin`: Must be the `PromoteOrigin`.
        /// - `who`: Account of existing member.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        promote_member = 1,
        
        /// <summary>
        /// >> demote_member
        /// Decrement the rank of an existing member by one. If the member is already at rank zero,
        /// then they are removed entirely.
        /// 
        /// - `origin`: Must be the `DemoteOrigin`.
        /// - `who`: Account of existing member of rank greater than zero.
        /// 
        /// Weight: `O(1)`, less if the member's index is highest in its rank.
        /// </summary>
        demote_member = 2,
        
        /// <summary>
        /// >> remove_member
        /// Remove the member entirely.
        /// 
        /// - `origin`: Must be the `RemoveOrigin`.
        /// - `who`: Account of existing member of rank greater than zero.
        /// - `min_rank`: The rank of the member or greater.
        /// 
        /// Weight: `O(min_rank)`.
        /// </summary>
        remove_member = 3,
        
        /// <summary>
        /// >> vote
        /// Add an aye or nay vote for the sender to the given proposal.
        /// 
        /// - `origin`: Must be `Signed` by a member account.
        /// - `poll`: Index of a poll which is ongoing.
        /// - `aye`: `true` if the vote is to approve the proposal, `false` otherwise.
        /// 
        /// Transaction fees are be waived if the member is voting on any particular proposal
        /// for the first time and the call is successful. Subsequent vote changes will charge a
        /// fee.
        /// 
        /// Weight: `O(1)`, less if there was no previous vote on the poll by the member.
        /// </summary>
        vote = 4,
        
        /// <summary>
        /// >> cleanup_poll
        /// Remove votes from the given poll. It must have ended.
        /// 
        /// - `origin`: Must be `Signed` by any account.
        /// - `poll_index`: Index of a poll which is completed and for which votes continue to
        ///   exist.
        /// - `max`: Maximum number of vote items from remove in this call.
        /// 
        /// Transaction fees are waived if the operation is successful.
        /// 
        /// Weight `O(max)` (less if there are fewer items to remove than `max`).
        /// </summary>
        cleanup_poll = 5,
        
        /// <summary>
        /// >> exchange_member
        /// Exchanges a member with a new account and the same existing rank.
        /// 
        /// - `origin`: Must be the `ExchangeOrigin`.
        /// - `who`: Account of existing member of rank greater than zero to be exchanged.
        /// - `new_who`: New Account of existing member of rank greater than zero to exchanged to.
        /// </summary>
        exchange_member = 6,
    }
    
    /// <summary>
    /// >> 424 - Variant[pallet_ranked_collective.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.add_member);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.promote_member);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.demote_member);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U16>>(Call.remove_member);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.vote);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.cleanup_poll);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.exchange_member);
        }
    }
}
