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


namespace Bifrost.NetApi.Generated.Model.bifrost_slpx.types
{
    
    
    /// <summary>
    /// >> OrderCaller
    /// </summary>
    public enum OrderCaller
    {
        
        /// <summary>
        /// >> Substrate
        /// </summary>
        Substrate = 0,
        
        /// <summary>
        /// >> Evm
        /// </summary>
        Evm = 1,
    }
    
    /// <summary>
    /// >> 449 - Variant[bifrost_slpx.types.OrderCaller]
    /// </summary>
    public sealed class EnumOrderCaller : BaseEnumExt<OrderCaller, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.primitive_types.H160>
    {
    }
}
