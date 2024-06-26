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


namespace Hydration.NetApi.Generated.Model.pallet_evm_accounts.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> TruncatedAccountAlreadyUsed
        /// EVM Account's nonce is not zero
        /// </summary>
        TruncatedAccountAlreadyUsed = 0,
        
        /// <summary>
        /// >> AddressAlreadyBound
        /// Address is already bound
        /// </summary>
        AddressAlreadyBound = 1,
        
        /// <summary>
        /// >> BoundAddressCannotBeUsed
        /// Bound address cannot be used
        /// </summary>
        BoundAddressCannotBeUsed = 2,
        
        /// <summary>
        /// >> AddressNotWhitelisted
        /// Address not whitelisted
        /// </summary>
        AddressNotWhitelisted = 3,
    }
    
    /// <summary>
    /// >> 580 - Variant[pallet_evm_accounts.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
