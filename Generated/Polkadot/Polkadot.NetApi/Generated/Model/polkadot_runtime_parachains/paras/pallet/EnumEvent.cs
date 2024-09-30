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


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.paras.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> CurrentCodeUpdated
        /// Current code has been updated for a Para. `para_id`
        /// </summary>
        CurrentCodeUpdated = 0,
        
        /// <summary>
        /// >> CurrentHeadUpdated
        /// Current head has been updated for a Para. `para_id`
        /// </summary>
        CurrentHeadUpdated = 1,
        
        /// <summary>
        /// >> CodeUpgradeScheduled
        /// A code upgrade has been scheduled for a Para. `para_id`
        /// </summary>
        CodeUpgradeScheduled = 2,
        
        /// <summary>
        /// >> NewHeadNoted
        /// A new head has been noted for a Para. `para_id`
        /// </summary>
        NewHeadNoted = 3,
        
        /// <summary>
        /// >> ActionQueued
        /// A para has been queued to execute pending actions. `para_id`
        /// </summary>
        ActionQueued = 4,
        
        /// <summary>
        /// >> PvfCheckStarted
        /// The given para either initiated or subscribed to a PVF check for the given validation
        /// code. `code_hash` `para_id`
        /// </summary>
        PvfCheckStarted = 5,
        
        /// <summary>
        /// >> PvfCheckAccepted
        /// The given validation code was accepted by the PVF pre-checking vote.
        /// `code_hash` `para_id`
        /// </summary>
        PvfCheckAccepted = 6,
        
        /// <summary>
        /// >> PvfCheckRejected
        /// The given validation code was rejected by the PVF pre-checking vote.
        /// `code_hash` `para_id`
        /// </summary>
        PvfCheckRejected = 7,
    }
    
    /// <summary>
    /// >> 506 - Variant[polkadot_runtime_parachains.paras.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id>(Event.CurrentCodeUpdated);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id>(Event.CurrentHeadUpdated);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id>(Event.CodeUpgradeScheduled);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id>(Event.NewHeadNoted);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.ActionQueued);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCodeHash, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id>>(Event.PvfCheckStarted);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCodeHash, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id>>(Event.PvfCheckAccepted);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCodeHash, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id>>(Event.PvfCheckRejected);
        }
    }
}
