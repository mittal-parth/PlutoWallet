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


namespace Opal.NetApi.Generated.Model.xcm
{
    
    
    /// <summary>
    /// >> VersionedAssetId
    /// </summary>
    public enum VersionedAssetId
    {
        
        /// <summary>
        /// >> V3
        /// </summary>
        V3 = 3,
    }
    
    /// <summary>
    /// >> 331 - Variant[xcm.VersionedAssetId]
    /// </summary>
    public sealed class EnumVersionedAssetId : BaseEnumRust<VersionedAssetId>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumVersionedAssetId()
        {
				AddTypeDecoder<Opal.NetApi.Generated.Model.xcm.v3.multiasset.EnumAssetId>(VersionedAssetId.V3);
        }
    }
}
