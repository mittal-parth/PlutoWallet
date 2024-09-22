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


namespace Bajun.NetApi.Generated.Model.orml_xtokens.module
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> TransferredAssets
        /// Transferred `Asset` with fee.
        /// </summary>
        TransferredAssets = 0,
    }
    
    /// <summary>
    /// >> 137 - Variant[orml_xtokens.module.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Asset, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>>(Event.TransferredAssets);
        }
    }
}
