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


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.paras
{
    
    
    /// <summary>
    /// >> PvfCheckCause
    /// </summary>
    public enum PvfCheckCause
    {
        
        /// <summary>
        /// >> Onboarding
        /// </summary>
        Onboarding = 0,
        
        /// <summary>
        /// >> Upgrade
        /// </summary>
        Upgrade = 1,
    }
    
    /// <summary>
    /// >> 769 - Variant[polkadot_runtime_parachains.paras.PvfCheckCause]
    /// </summary>
    public sealed class EnumPvfCheckCause : BaseEnumExt<PvfCheckCause, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.paras.EnumSetGoAhead>>
    {
    }
}