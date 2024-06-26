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


namespace Bifrost.NetApi.Generated.Model.cumulus_pallet_xcmp_queue.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> service_overweight
        /// See [`Pallet::service_overweight`].
        /// </summary>
        service_overweight = 0,
        
        /// <summary>
        /// >> suspend_xcm_execution
        /// See [`Pallet::suspend_xcm_execution`].
        /// </summary>
        suspend_xcm_execution = 1,
        
        /// <summary>
        /// >> resume_xcm_execution
        /// See [`Pallet::resume_xcm_execution`].
        /// </summary>
        resume_xcm_execution = 2,
        
        /// <summary>
        /// >> update_suspend_threshold
        /// See [`Pallet::update_suspend_threshold`].
        /// </summary>
        update_suspend_threshold = 3,
        
        /// <summary>
        /// >> update_drop_threshold
        /// See [`Pallet::update_drop_threshold`].
        /// </summary>
        update_drop_threshold = 4,
        
        /// <summary>
        /// >> update_resume_threshold
        /// See [`Pallet::update_resume_threshold`].
        /// </summary>
        update_resume_threshold = 5,
        
        /// <summary>
        /// >> update_threshold_weight
        /// See [`Pallet::update_threshold_weight`].
        /// </summary>
        update_threshold_weight = 6,
        
        /// <summary>
        /// >> update_weight_restrict_decay
        /// See [`Pallet::update_weight_restrict_decay`].
        /// </summary>
        update_weight_restrict_decay = 7,
        
        /// <summary>
        /// >> update_xcmp_max_individual_weight
        /// See [`Pallet::update_xcmp_max_individual_weight`].
        /// </summary>
        update_xcmp_max_individual_weight = 8,
    }
    
    /// <summary>
    /// >> 124 - Variant[cumulus_pallet_xcmp_queue.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight>, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight>
    {
    }
}
