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


namespace Hydration.NetApi.Generated.Model.hydradx_traits.router
{
    
    
    /// <summary>
    /// >> PoolType
    /// </summary>
    public enum PoolType
    {
        
        /// <summary>
        /// >> XYK
        /// </summary>
        XYK = 0,
        
        /// <summary>
        /// >> LBP
        /// </summary>
        LBP = 1,
        
        /// <summary>
        /// >> Stableswap
        /// </summary>
        Stableswap = 2,
        
        /// <summary>
        /// >> Omnipool
        /// </summary>
        Omnipool = 3,
    }
    
    /// <summary>
    /// >> 151 - Variant[hydradx_traits.router.PoolType]
    /// </summary>
    public sealed class EnumPoolType : BaseEnumRust<PoolType>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumPoolType()
        {
				AddTypeDecoder<BaseVoid>(PoolType.XYK);
				AddTypeDecoder<BaseVoid>(PoolType.LBP);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(PoolType.Stableswap);
				AddTypeDecoder<BaseVoid>(PoolType.Omnipool);
        }
    }
}
