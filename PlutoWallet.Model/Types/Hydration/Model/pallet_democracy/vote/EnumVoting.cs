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


namespace Hydration.NetApi.Generated.Model.pallet_democracy.vote
{
    
    
    /// <summary>
    /// >> Voting
    /// </summary>
    public enum Voting
    {
        
        /// <summary>
        /// >> Direct
        /// </summary>
        Direct = 0,
        
        /// <summary>
        /// >> Delegating
        /// </summary>
        Delegating = 1,
    }
    
    /// <summary>
    /// >> 444 - Variant[pallet_democracy.vote.Voting]
    /// </summary>
    public sealed class EnumVoting : BaseEnumExt<Voting, BaseTuple<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT22, Hydration.NetApi.Generated.Model.pallet_democracy.types.Delegations, Hydration.NetApi.Generated.Model.pallet_democracy.vote.PriorLock>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Model.pallet_democracy.conviction.EnumConviction, Hydration.NetApi.Generated.Model.pallet_democracy.types.Delegations, Hydration.NetApi.Generated.Model.pallet_democracy.vote.PriorLock>>
    {
    }
}
