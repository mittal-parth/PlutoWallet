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


namespace PolkadotAssetHub.NetApi.Generated.Model.pallet_assets.types
{
    
    
    /// <summary>
    /// >> AssetStatus
    /// </summary>
    public enum AssetStatus
    {
        
        /// <summary>
        /// >> Live
        /// </summary>
        Live = 0,
        
        /// <summary>
        /// >> Frozen
        /// </summary>
        Frozen = 1,
        
        /// <summary>
        /// >> Destroying
        /// </summary>
        Destroying = 2,
    }
    
    /// <summary>
    /// >> 401 - Variant[pallet_assets.types.AssetStatus]
    /// </summary>
    public sealed class EnumAssetStatus : BaseEnum<AssetStatus>
    {
    }
}
