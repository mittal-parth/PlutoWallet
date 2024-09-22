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


namespace PolkadotAssetHub.NetApi.Generated.Model.pallet_collator_selection.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_invulnerables
        /// See [`Pallet::set_invulnerables`].
        /// </summary>
        set_invulnerables = 0,
        
        /// <summary>
        /// >> set_desired_candidates
        /// See [`Pallet::set_desired_candidates`].
        /// </summary>
        set_desired_candidates = 1,
        
        /// <summary>
        /// >> set_candidacy_bond
        /// See [`Pallet::set_candidacy_bond`].
        /// </summary>
        set_candidacy_bond = 2,
        
        /// <summary>
        /// >> register_as_candidate
        /// See [`Pallet::register_as_candidate`].
        /// </summary>
        register_as_candidate = 3,
        
        /// <summary>
        /// >> leave_intent
        /// See [`Pallet::leave_intent`].
        /// </summary>
        leave_intent = 4,
        
        /// <summary>
        /// >> add_invulnerable
        /// See [`Pallet::add_invulnerable`].
        /// </summary>
        add_invulnerable = 5,
        
        /// <summary>
        /// >> remove_invulnerable
        /// See [`Pallet::remove_invulnerable`].
        /// </summary>
        remove_invulnerable = 6,
        
        /// <summary>
        /// >> update_bond
        /// See [`Pallet::update_bond`].
        /// </summary>
        update_bond = 7,
        
        /// <summary>
        /// >> take_candidate_slot
        /// See [`Pallet::take_candidate_slot`].
        /// </summary>
        take_candidate_slot = 8,
    }
    
    /// <summary>
    /// >> 248 - Variant[pallet_collator_selection.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Call.set_invulnerables);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.set_desired_candidates);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.set_candidacy_bond);
				AddTypeDecoder<BaseVoid>(Call.register_as_candidate);
				AddTypeDecoder<BaseVoid>(Call.leave_intent);
				AddTypeDecoder<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Call.add_invulnerable);
				AddTypeDecoder<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Call.remove_invulnerable);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.update_bond);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Call.take_candidate_slot);
        }
    }
}
