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


namespace Bifrost.NetApi.Generated.Model.cumulus_pallet_parachain_system.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> OverlappingUpgrades
        /// Attempt to upgrade validation function while existing upgrade pending.
        /// </summary>
        OverlappingUpgrades = 0,
        
        /// <summary>
        /// >> ProhibitedByPolkadot
        /// Polkadot currently prohibits this parachain from upgrading its validation function.
        /// </summary>
        ProhibitedByPolkadot = 1,
        
        /// <summary>
        /// >> TooBig
        /// The supplied validation function has compiled into a blob larger than Polkadot is
        /// willing to run.
        /// </summary>
        TooBig = 2,
        
        /// <summary>
        /// >> ValidationDataNotAvailable
        /// The inherent which supplies the validation data did not run this block.
        /// </summary>
        ValidationDataNotAvailable = 3,
        
        /// <summary>
        /// >> HostConfigurationNotAvailable
        /// The inherent which supplies the host configuration did not run this block.
        /// </summary>
        HostConfigurationNotAvailable = 4,
        
        /// <summary>
        /// >> NotScheduled
        /// No validation function upgrade is currently scheduled.
        /// </summary>
        NotScheduled = 5,
        
        /// <summary>
        /// >> NothingAuthorized
        /// No code upgrade has been authorized.
        /// </summary>
        NothingAuthorized = 6,
        
        /// <summary>
        /// >> Unauthorized
        /// The given code upgrade has not been authorized.
        /// </summary>
        Unauthorized = 7,
    }
    
    /// <summary>
    /// >> 505 - Variant[cumulus_pallet_parachain_system.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
