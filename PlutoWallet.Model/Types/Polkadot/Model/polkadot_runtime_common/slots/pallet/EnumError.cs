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


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_common.slots.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> ParaNotOnboarding
        /// The parachain ID is not onboarding.
        /// </summary>
        ParaNotOnboarding = 0,
        
        /// <summary>
        /// >> LeaseError
        /// There was an error with the lease.
        /// </summary>
        LeaseError = 1,
    }
    
    /// <summary>
    /// >> 812 - Variant[polkadot_runtime_common.slots.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
