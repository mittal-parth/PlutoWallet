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


namespace Bifrost.NetApi.Generated.Model.bifrost_slpx.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> TokenNotFoundInVtokenMinting
        /// Token not found in vtoken minting
        /// </summary>
        TokenNotFoundInVtokenMinting = 0,
        
        /// <summary>
        /// >> TokenNotFoundInZenlink
        /// Token not found in zenlink
        /// </summary>
        TokenNotFoundInZenlink = 1,
        
        /// <summary>
        /// >> AccountIdAlreadyInWhitelist
        /// Contract Account already exists in the whitelist
        /// </summary>
        AccountIdAlreadyInWhitelist = 2,
        
        /// <summary>
        /// >> AccountIdNotInWhitelist
        /// Contract Account is not in the whitelist
        /// </summary>
        AccountIdNotInWhitelist = 3,
        
        /// <summary>
        /// >> ExceededWhitelistMaxNumber
        /// The maximum number of whitelist addresses is 10
        /// </summary>
        ExceededWhitelistMaxNumber = 4,
        
        /// <summary>
        /// >> NotSetExecutionFee
        /// Execution fee not set
        /// </summary>
        NotSetExecutionFee = 5,
        
        /// <summary>
        /// >> FreeBalanceTooLow
        /// Insufficient balance to execute the fee
        /// </summary>
        FreeBalanceTooLow = 6,
        
        /// <summary>
        /// >> ArgumentsError
        /// ArgumentsError
        /// </summary>
        ArgumentsError = 7,
        
        /// <summary>
        /// >> ErrorConvertVtoken
        /// </summary>
        ErrorConvertVtoken = 8,
        
        /// <summary>
        /// >> ErrorValidating
        /// </summary>
        ErrorValidating = 9,
        
        /// <summary>
        /// >> ErrorDelivering
        /// </summary>
        ErrorDelivering = 10,
        
        /// <summary>
        /// >> Unsupported
        /// </summary>
        Unsupported = 11,
    }
    
    /// <summary>
    /// >> 901 - Variant[bifrost_slpx.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
