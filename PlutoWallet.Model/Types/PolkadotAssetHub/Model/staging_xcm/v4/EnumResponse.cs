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


namespace PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4
{
    
    
    /// <summary>
    /// >> Response
    /// </summary>
    public enum Response
    {
        
        /// <summary>
        /// >> Null
        /// </summary>
        Null = 0,
        
        /// <summary>
        /// >> Assets
        /// </summary>
        Assets = 1,
        
        /// <summary>
        /// >> ExecutionResult
        /// </summary>
        ExecutionResult = 2,
        
        /// <summary>
        /// >> Version
        /// </summary>
        Version = 3,
        
        /// <summary>
        /// >> PalletsInfo
        /// </summary>
        PalletsInfo = 4,
        
        /// <summary>
        /// >> DispatchResult
        /// </summary>
        DispatchResult = 5,
    }
    
    /// <summary>
    /// >> 78 - Variant[staging_xcm.v4.Response]
    /// </summary>
    public sealed class EnumResponse : BaseEnumExt<Response, BaseVoid, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.traits.EnumError>>, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.EnumMaybeErrorCode>
    {
    }
}
