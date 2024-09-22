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


namespace Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> control_auto_migration
        /// See [`Pallet::control_auto_migration`].
        /// </summary>
        control_auto_migration = 0,
        
        /// <summary>
        /// >> continue_migrate
        /// See [`Pallet::continue_migrate`].
        /// </summary>
        continue_migrate = 1,
        
        /// <summary>
        /// >> migrate_custom_top
        /// See [`Pallet::migrate_custom_top`].
        /// </summary>
        migrate_custom_top = 2,
        
        /// <summary>
        /// >> migrate_custom_child
        /// See [`Pallet::migrate_custom_child`].
        /// </summary>
        migrate_custom_child = 3,
        
        /// <summary>
        /// >> set_signed_max_limits
        /// See [`Pallet::set_signed_max_limits`].
        /// </summary>
        set_signed_max_limits = 4,
        
        /// <summary>
        /// >> force_set_progress
        /// See [`Pallet::force_set_progress`].
        /// </summary>
        force_set_progress = 5,
    }
    
    /// <summary>
    /// >> 382 - Variant[pallet_state_trie_migration.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits>>(Call.control_auto_migration);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits, Substrate.NetApi.Model.Types.Primitive.U32, Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask>>(Call.continue_migrate);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.migrate_custom_top);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.migrate_custom_child);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits>(Call.set_signed_max_limits);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.EnumProgress, Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.EnumProgress>>(Call.force_set_progress);
        }
    }
}
