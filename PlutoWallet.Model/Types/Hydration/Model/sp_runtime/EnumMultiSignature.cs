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


namespace Hydration.NetApi.Generated.Model.sp_runtime
{
    
    
    /// <summary>
    /// >> MultiSignature
    /// </summary>
    public enum MultiSignature
    {
        
        /// <summary>
        /// >> Ed25519
        /// </summary>
        Ed25519 = 0,
        
        /// <summary>
        /// >> Sr25519
        /// </summary>
        Sr25519 = 1,
        
        /// <summary>
        /// >> Ecdsa
        /// </summary>
        Ecdsa = 2,
    }
    
    /// <summary>
    /// >> 710 - Variant[sp_runtime.MultiSignature]
    /// </summary>
    public sealed class EnumMultiSignature : BaseEnumExt<MultiSignature, Hydration.NetApi.Generated.Model.sp_core.ed25519.Signature, Hydration.NetApi.Generated.Model.sp_core.sr25519.Signature, Hydration.NetApi.Generated.Model.sp_core.ecdsa.Signature>
    {
    }
}
