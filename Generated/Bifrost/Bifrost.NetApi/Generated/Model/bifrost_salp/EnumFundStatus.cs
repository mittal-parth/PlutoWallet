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


namespace Bifrost.NetApi.Generated.Model.bifrost_salp
{
    
    
    /// <summary>
    /// >> FundStatus
    /// </summary>
    public enum FundStatus
    {
        
        /// <summary>
        /// >> Ongoing
        /// </summary>
        Ongoing = 0,
        
        /// <summary>
        /// >> Retired
        /// </summary>
        Retired = 1,
        
        /// <summary>
        /// >> Success
        /// </summary>
        Success = 2,
        
        /// <summary>
        /// >> Failed
        /// </summary>
        Failed = 3,
        
        /// <summary>
        /// >> RefundWithdrew
        /// </summary>
        RefundWithdrew = 4,
        
        /// <summary>
        /// >> RedeemWithdrew
        /// </summary>
        RedeemWithdrew = 5,
        
        /// <summary>
        /// >> FailedToContinue
        /// </summary>
        FailedToContinue = 6,
        
        /// <summary>
        /// >> End
        /// </summary>
        End = 7,
    }
    
    /// <summary>
    /// >> 314 - Variant[bifrost_salp.FundStatus]
    /// </summary>
    public sealed class EnumFundStatus : BaseEnum<FundStatus>
    {
    }
}