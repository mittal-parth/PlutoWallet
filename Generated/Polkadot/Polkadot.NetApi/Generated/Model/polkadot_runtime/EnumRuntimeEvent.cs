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


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime
{
    
    
    /// <summary>
    /// >> RuntimeEvent
    /// </summary>
    public enum RuntimeEvent
    {
        
        /// <summary>
        /// >> System
        /// </summary>
        System = 0,
        
        /// <summary>
        /// >> Scheduler
        /// </summary>
        Scheduler = 1,
        
        /// <summary>
        /// >> Preimage
        /// </summary>
        Preimage = 10,
        
        /// <summary>
        /// >> Indices
        /// </summary>
        Indices = 4,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 5,
        
        /// <summary>
        /// >> TransactionPayment
        /// </summary>
        TransactionPayment = 32,
        
        /// <summary>
        /// >> Staking
        /// </summary>
        Staking = 7,
        
        /// <summary>
        /// >> Offences
        /// </summary>
        Offences = 8,
        
        /// <summary>
        /// >> Session
        /// </summary>
        Session = 9,
        
        /// <summary>
        /// >> Grandpa
        /// </summary>
        Grandpa = 11,
        
        /// <summary>
        /// >> ImOnline
        /// </summary>
        ImOnline = 12,
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Treasury = 19,
        
        /// <summary>
        /// >> ConvictionVoting
        /// </summary>
        ConvictionVoting = 20,
        
        /// <summary>
        /// >> Referenda
        /// </summary>
        Referenda = 21,
        
        /// <summary>
        /// >> Whitelist
        /// </summary>
        Whitelist = 23,
        
        /// <summary>
        /// >> Claims
        /// </summary>
        Claims = 24,
        
        /// <summary>
        /// >> Vesting
        /// </summary>
        Vesting = 25,
        
        /// <summary>
        /// >> Utility
        /// </summary>
        Utility = 26,
        
        /// <summary>
        /// >> Identity
        /// </summary>
        Identity = 28,
        
        /// <summary>
        /// >> Proxy
        /// </summary>
        Proxy = 29,
        
        /// <summary>
        /// >> Multisig
        /// </summary>
        Multisig = 30,
        
        /// <summary>
        /// >> Bounties
        /// </summary>
        Bounties = 34,
        
        /// <summary>
        /// >> ChildBounties
        /// </summary>
        ChildBounties = 38,
        
        /// <summary>
        /// >> ElectionProviderMultiPhase
        /// </summary>
        ElectionProviderMultiPhase = 36,
        
        /// <summary>
        /// >> VoterList
        /// </summary>
        VoterList = 37,
        
        /// <summary>
        /// >> NominationPools
        /// </summary>
        NominationPools = 39,
        
        /// <summary>
        /// >> FastUnstake
        /// </summary>
        FastUnstake = 40,
        
        /// <summary>
        /// >> ParaInclusion
        /// </summary>
        ParaInclusion = 53,
        
        /// <summary>
        /// >> Paras
        /// </summary>
        Paras = 56,
        
        /// <summary>
        /// >> Hrmp
        /// </summary>
        Hrmp = 60,
        
        /// <summary>
        /// >> ParasDisputes
        /// </summary>
        ParasDisputes = 62,
        
        /// <summary>
        /// >> Registrar
        /// </summary>
        Registrar = 70,
        
        /// <summary>
        /// >> Slots
        /// </summary>
        Slots = 71,
        
        /// <summary>
        /// >> Auctions
        /// </summary>
        Auctions = 72,
        
        /// <summary>
        /// >> Crowdloan
        /// </summary>
        Crowdloan = 73,
        
        /// <summary>
        /// >> StateTrieMigration
        /// </summary>
        StateTrieMigration = 98,
        
        /// <summary>
        /// >> XcmPallet
        /// </summary>
        XcmPallet = 99,
        
        /// <summary>
        /// >> MessageQueue
        /// </summary>
        MessageQueue = 100,
        
        /// <summary>
        /// >> AssetRate
        /// </summary>
        AssetRate = 101,
        
        /// <summary>
        /// >> IdentityMigrator
        /// </summary>
        IdentityMigrator = 248,
    }
    
    /// <summary>
    /// >> 20 - Variant[polkadot_runtime.RuntimeEvent]
    /// </summary>
    public sealed class EnumRuntimeEvent : BaseEnumRust<RuntimeEvent>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRuntimeEvent()
        {
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.frame_system.pallet.EnumEvent>(RuntimeEvent.System);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_scheduler.pallet.EnumEvent>(RuntimeEvent.Scheduler);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_preimage.pallet.EnumEvent>(RuntimeEvent.Preimage);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_indices.pallet.EnumEvent>(RuntimeEvent.Indices);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_balances.pallet.EnumEvent>(RuntimeEvent.Balances);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_transaction_payment.pallet.EnumEvent>(RuntimeEvent.TransactionPayment);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_staking.pallet.pallet.EnumEvent>(RuntimeEvent.Staking);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_offences.pallet.EnumEvent>(RuntimeEvent.Offences);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_session.pallet.EnumEvent>(RuntimeEvent.Session);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_grandpa.pallet.EnumEvent>(RuntimeEvent.Grandpa);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime.pallet_im_online.pallet.EnumEvent>(RuntimeEvent.ImOnline);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_treasury.pallet.EnumEvent>(RuntimeEvent.Treasury);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_conviction_voting.pallet.EnumEvent>(RuntimeEvent.ConvictionVoting);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_referenda.pallet.EnumEvent>(RuntimeEvent.Referenda);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_whitelist.pallet.EnumEvent>(RuntimeEvent.Whitelist);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_common.claims.pallet.EnumEvent>(RuntimeEvent.Claims);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_vesting.pallet.EnumEvent>(RuntimeEvent.Vesting);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_utility.pallet.EnumEvent>(RuntimeEvent.Utility);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_identity.pallet.EnumEvent>(RuntimeEvent.Identity);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_proxy.pallet.EnumEvent>(RuntimeEvent.Proxy);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_multisig.pallet.EnumEvent>(RuntimeEvent.Multisig);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_bounties.pallet.EnumEvent>(RuntimeEvent.Bounties);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_child_bounties.pallet.EnumEvent>(RuntimeEvent.ChildBounties);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_election_provider_multi_phase.pallet.EnumEvent>(RuntimeEvent.ElectionProviderMultiPhase);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_bags_list.pallet.EnumEvent>(RuntimeEvent.VoterList);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_nomination_pools.pallet.EnumEvent>(RuntimeEvent.NominationPools);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_fast_unstake.pallet.EnumEvent>(RuntimeEvent.FastUnstake);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.pallet.EnumEvent>(RuntimeEvent.ParaInclusion);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.paras.pallet.EnumEvent>(RuntimeEvent.Paras);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.hrmp.pallet.EnumEvent>(RuntimeEvent.Hrmp);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.disputes.pallet.EnumEvent>(RuntimeEvent.ParasDisputes);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_common.paras_registrar.pallet.EnumEvent>(RuntimeEvent.Registrar);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_common.slots.pallet.EnumEvent>(RuntimeEvent.Slots);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_common.auctions.pallet.EnumEvent>(RuntimeEvent.Auctions);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_common.crowdloan.pallet.EnumEvent>(RuntimeEvent.Crowdloan);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.EnumEvent>(RuntimeEvent.StateTrieMigration);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_xcm.pallet.EnumEvent>(RuntimeEvent.XcmPallet);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_message_queue.pallet.EnumEvent>(RuntimeEvent.MessageQueue);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_asset_rate.pallet.EnumEvent>(RuntimeEvent.AssetRate);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_runtime_common.identity_migrator.pallet.EnumEvent>(RuntimeEvent.IdentityMigrator);
        }
    }
}
