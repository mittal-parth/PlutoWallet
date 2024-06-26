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


namespace Hydration.NetApi.Generated.Model.pallet_ema_oracle.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> TooManyUniqueEntries
        /// </summary>
        TooManyUniqueEntries = 0,
        
        /// <summary>
        /// >> OnTradeValueZero
        /// </summary>
        OnTradeValueZero = 1,
        
        /// <summary>
        /// >> OracleNotFound
        /// </summary>
        OracleNotFound = 2,
    }
    
    /// <summary>
    /// >> 707 - Variant[pallet_ema_oracle.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
