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


namespace Polkadot.NetApi.Generated.Model.pallet_child_bounties.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> ParentBountyNotActive
        /// The parent bounty is not in active state.
        /// </summary>
        ParentBountyNotActive = 0,
        
        /// <summary>
        /// >> InsufficientBountyBalance
        /// The bounty balance is not enough to add new child-bounty.
        /// </summary>
        InsufficientBountyBalance = 1,
        
        /// <summary>
        /// >> TooManyChildBounties
        /// Number of child bounties exceeds limit `MaxActiveChildBountyCount`.
        /// </summary>
        TooManyChildBounties = 2,
    }
    
    /// <summary>
    /// >> 702 - Variant[pallet_child_bounties.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
