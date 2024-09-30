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


namespace InvArch.NetApi.Generated.Model.xcm
{
    
    
    /// <summary>
    /// >> VersionedMultiAssets
    /// </summary>
    public enum VersionedMultiAssets
    {
        
        /// <summary>
        /// >> V2
        /// </summary>
        V2 = 1,
        
        /// <summary>
        /// >> V3
        /// </summary>
        V3 = 3,
    }
    
    /// <summary>
    /// >> 93 - Variant[xcm.VersionedMultiAssets]
    /// </summary>
    public sealed class EnumVersionedMultiAssets : BaseEnumRust<VersionedMultiAssets>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumVersionedMultiAssets()
        {
				AddTypeDecoder<InvArch.NetApi.Generated.Model.xcm.v2.multiasset.MultiAssets>(VersionedMultiAssets.V2);
				AddTypeDecoder<InvArch.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets>(VersionedMultiAssets.V3);
        }
    }
}
