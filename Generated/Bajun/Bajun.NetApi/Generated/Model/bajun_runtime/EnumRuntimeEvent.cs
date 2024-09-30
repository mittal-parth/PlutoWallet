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


namespace Bajun.NetApi.Generated.Model.bajun_runtime
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
        /// >> ParachainSystem
        /// </summary>
        ParachainSystem = 1,
        
        /// <summary>
        /// >> Multisig
        /// </summary>
        Multisig = 4,
        
        /// <summary>
        /// >> Utility
        /// </summary>
        Utility = 5,
        
        /// <summary>
        /// >> Identity
        /// </summary>
        Identity = 6,
        
        /// <summary>
        /// >> Proxy
        /// </summary>
        Proxy = 7,
        
        /// <summary>
        /// >> Scheduler
        /// </summary>
        Scheduler = 8,
        
        /// <summary>
        /// >> Preimage
        /// </summary>
        Preimage = 9,
        
        /// <summary>
        /// >> Migrations
        /// </summary>
        Migrations = 10,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 15,
        
        /// <summary>
        /// >> TransactionPayment
        /// </summary>
        TransactionPayment = 16,
        
        /// <summary>
        /// >> Vesting
        /// </summary>
        Vesting = 17,
        
        /// <summary>
        /// >> CollatorSelection
        /// </summary>
        CollatorSelection = 21,
        
        /// <summary>
        /// >> Session
        /// </summary>
        Session = 22,
        
        /// <summary>
        /// >> XcmpQueue
        /// </summary>
        XcmpQueue = 30,
        
        /// <summary>
        /// >> PolkadotXcm
        /// </summary>
        PolkadotXcm = 31,
        
        /// <summary>
        /// >> CumulusXcm
        /// </summary>
        CumulusXcm = 32,
        
        /// <summary>
        /// >> MessageQueue
        /// </summary>
        MessageQueue = 34,
        
        /// <summary>
        /// >> XTokens
        /// </summary>
        XTokens = 35,
        
        /// <summary>
        /// >> OrmlXcm
        /// </summary>
        OrmlXcm = 36,
        
        /// <summary>
        /// >> Sudo
        /// </summary>
        Sudo = 40,
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Treasury = 41,
        
        /// <summary>
        /// >> Council
        /// </summary>
        Council = 42,
        
        /// <summary>
        /// >> CouncilMembership
        /// </summary>
        CouncilMembership = 43,
        
        /// <summary>
        /// >> TechnicalCommittee
        /// </summary>
        TechnicalCommittee = 44,
        
        /// <summary>
        /// >> TechnicalCommitteeMembership
        /// </summary>
        TechnicalCommitteeMembership = 45,
        
        /// <summary>
        /// >> Democracy
        /// </summary>
        Democracy = 46,
        
        /// <summary>
        /// >> AwesomeAvatars
        /// </summary>
        AwesomeAvatars = 51,
        
        /// <summary>
        /// >> Nft
        /// </summary>
        Nft = 60,
        
        /// <summary>
        /// >> NftTransfer
        /// </summary>
        NftTransfer = 61,
        
        /// <summary>
        /// >> AffiliatesAAA
        /// </summary>
        AffiliatesAAA = 70,
        
        /// <summary>
        /// >> TournamentAAA
        /// </summary>
        TournamentAAA = 80,
        
        /// <summary>
        /// >> Assets
        /// </summary>
        Assets = 90,
        
        /// <summary>
        /// >> AssetRegistry
        /// </summary>
        AssetRegistry = 91,
    }
    
    /// <summary>
    /// >> 21 - Variant[bajun_runtime.RuntimeEvent]
    /// </summary>
    public sealed class EnumRuntimeEvent : BaseEnumRust<RuntimeEvent>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRuntimeEvent()
        {
				AddTypeDecoder<Bajun.NetApi.Generated.Model.frame_system.pallet.EnumEvent>(RuntimeEvent.System);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.cumulus_pallet_parachain_system.pallet.EnumEvent>(RuntimeEvent.ParachainSystem);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_multisig.pallet.EnumEvent>(RuntimeEvent.Multisig);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_utility.pallet.EnumEvent>(RuntimeEvent.Utility);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_identity.pallet.EnumEvent>(RuntimeEvent.Identity);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_proxy.pallet.EnumEvent>(RuntimeEvent.Proxy);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_scheduler.pallet.EnumEvent>(RuntimeEvent.Scheduler);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_preimage.pallet.EnumEvent>(RuntimeEvent.Preimage);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_migrations.pallet.EnumEvent>(RuntimeEvent.Migrations);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_balances.pallet.EnumEvent>(RuntimeEvent.Balances);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_transaction_payment.pallet.EnumEvent>(RuntimeEvent.TransactionPayment);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.orml_vesting.module.EnumEvent>(RuntimeEvent.Vesting);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_collator_selection.pallet.EnumEvent>(RuntimeEvent.CollatorSelection);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_session.pallet.EnumEvent>(RuntimeEvent.Session);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.cumulus_pallet_xcmp_queue.pallet.EnumEvent>(RuntimeEvent.XcmpQueue);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_xcm.pallet.EnumEvent>(RuntimeEvent.PolkadotXcm);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.cumulus_pallet_xcm.pallet.EnumEvent>(RuntimeEvent.CumulusXcm);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_message_queue.pallet.EnumEvent>(RuntimeEvent.MessageQueue);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.orml_xtokens.module.EnumEvent>(RuntimeEvent.XTokens);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.orml_xcm.module.EnumEvent>(RuntimeEvent.OrmlXcm);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_sudo.pallet.EnumEvent>(RuntimeEvent.Sudo);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_treasury.pallet.EnumEvent>(RuntimeEvent.Treasury);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_collective.pallet.EnumEvent>(RuntimeEvent.Council);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_membership.pallet.EnumEvent>(RuntimeEvent.CouncilMembership);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_collective.pallet.EnumEvent>(RuntimeEvent.TechnicalCommittee);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_membership.pallet.EnumEvent>(RuntimeEvent.TechnicalCommitteeMembership);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_democracy.pallet.EnumEvent>(RuntimeEvent.Democracy);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.pallet.EnumEvent>(RuntimeEvent.AwesomeAvatars);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_nfts.pallet.EnumEvent>(RuntimeEvent.Nft);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_ajuna_nft_transfer.pallet.EnumEvent>(RuntimeEvent.NftTransfer);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_ajuna_affiliates.pallet.EnumEvent>(RuntimeEvent.AffiliatesAAA);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_ajuna_tournament.pallet.EnumEvent>(RuntimeEvent.TournamentAAA);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_assets.pallet.EnumEvent>(RuntimeEvent.Assets);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.pallet_asset_registry.pallet.EnumEvent>(RuntimeEvent.AssetRegistry);
        }
    }
}
