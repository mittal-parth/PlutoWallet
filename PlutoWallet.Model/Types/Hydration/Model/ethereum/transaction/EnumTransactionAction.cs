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


namespace Hydration.NetApi.Generated.Model.ethereum.transaction
{
    
    
    /// <summary>
    /// >> TransactionAction
    /// </summary>
    public enum TransactionAction
    {
        
        /// <summary>
        /// >> Call
        /// </summary>
        Call = 0,
        
        /// <summary>
        /// >> Create
        /// </summary>
        Create = 1,
    }
    
    /// <summary>
    /// >> 348 - Variant[ethereum.transaction.TransactionAction]
    /// </summary>
    public sealed class EnumTransactionAction : BaseEnumExt<TransactionAction, Hydration.NetApi.Generated.Model.primitive_types.H160, BaseVoid>
    {
    }
}