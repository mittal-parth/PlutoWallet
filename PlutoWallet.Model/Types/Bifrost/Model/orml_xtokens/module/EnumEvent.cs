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


namespace Bifrost.NetApi.Generated.Model.orml_xtokens.module
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> TransferredMultiAssets
        /// Transferred `MultiAsset` with fee.
        /// </summary>
        TransferredMultiAssets = 0,
    }
    
    /// <summary>
    /// >> 413 - Variant[orml_xtokens.module.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAsset, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>
    {
    }
}