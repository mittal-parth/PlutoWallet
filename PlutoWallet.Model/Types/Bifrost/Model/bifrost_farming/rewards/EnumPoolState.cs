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


namespace Bifrost.NetApi.Generated.Model.bifrost_farming.rewards
{
    
    
    /// <summary>
    /// >> PoolState
    /// </summary>
    public enum PoolState
    {
        
        /// <summary>
        /// >> UnCharged
        /// </summary>
        UnCharged = 0,
        
        /// <summary>
        /// >> Charged
        /// </summary>
        Charged = 1,
        
        /// <summary>
        /// >> Ongoing
        /// </summary>
        Ongoing = 2,
        
        /// <summary>
        /// >> Dead
        /// </summary>
        Dead = 3,
        
        /// <summary>
        /// >> Retired
        /// </summary>
        Retired = 4,
    }
    
    /// <summary>
    /// >> 763 - Variant[bifrost_farming.rewards.PoolState]
    /// </summary>
    public sealed class EnumPoolState : BaseEnum<PoolState>
    {
    }
}