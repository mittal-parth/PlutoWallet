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


namespace Hydration.NetApi.Generated.Model.pallet_collective
{
    
    
    /// <summary>
    /// >> RawOrigin
    /// </summary>
    public enum RawOrigin
    {
        
        /// <summary>
        /// >> Members
        /// </summary>
        Members = 0,
        
        /// <summary>
        /// >> Member
        /// </summary>
        Member = 1,
        
        /// <summary>
        /// >> _Phantom
        /// </summary>
        _Phantom = 2,
    }
    
    /// <summary>
    /// >> 414 - Variant[pallet_collective.RawOrigin]
    /// </summary>
    public sealed class EnumRawOrigin : BaseEnumExt<RawOrigin, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseVoid>
    {
    }
}
