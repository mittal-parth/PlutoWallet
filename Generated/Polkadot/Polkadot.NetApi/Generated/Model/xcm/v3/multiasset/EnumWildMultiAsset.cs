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


namespace Polkadot.NetApi.Generated.Model.xcm.v3.multiasset
{
    
    
    /// <summary>
    /// >> WildMultiAsset
    /// </summary>
    public enum WildMultiAsset
    {
        
        /// <summary>
        /// >> All
        /// </summary>
        All = 0,
        
        /// <summary>
        /// >> AllOf
        /// </summary>
        AllOf = 1,
        
        /// <summary>
        /// >> AllCounted
        /// </summary>
        AllCounted = 2,
        
        /// <summary>
        /// >> AllOfCounted
        /// </summary>
        AllOfCounted = 3,
    }
    
    /// <summary>
    /// >> 430 - Variant[xcm.v3.multiasset.WildMultiAsset]
    /// </summary>
    public sealed class EnumWildMultiAsset : BaseEnumRust<WildMultiAsset>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumWildMultiAsset()
        {
				AddTypeDecoder<BaseVoid>(WildMultiAsset.All);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.xcm.v3.multiasset.EnumAssetId, Polkadot.NetApi.Generated.Model.xcm.v3.multiasset.EnumWildFungibility>>(WildMultiAsset.AllOf);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(WildMultiAsset.AllCounted);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.xcm.v3.multiasset.EnumAssetId, Polkadot.NetApi.Generated.Model.xcm.v3.multiasset.EnumWildFungibility, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>>(WildMultiAsset.AllOfCounted);
        }
    }
}
