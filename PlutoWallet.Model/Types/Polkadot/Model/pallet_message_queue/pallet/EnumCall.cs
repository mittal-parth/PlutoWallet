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


namespace Polkadot.NetApi.Generated.Model.pallet_message_queue.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> reap_page
        /// See [`Pallet::reap_page`].
        /// </summary>
        reap_page = 0,
        
        /// <summary>
        /// >> execute_overweight
        /// See [`Pallet::execute_overweight`].
        /// </summary>
        execute_overweight = 1,
    }
    
    /// <summary>
    /// >> 463 - Variant[pallet_message_queue.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Polkadot.NetApi.Generated.Model.sp_weights.weight_v2.Weight>>
    {
    }
}
