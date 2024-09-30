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
    /// >> Event
    /// Inner events of this pallet.
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Migrated
        /// Given number of `(top, child)` keys were migrated respectively, with the given
        /// `compute`.
        /// </summary>
        Migrated = 0,
        
        /// <summary>
        /// >> Slashed
        /// Some account got slashed by the given amount.
        /// </summary>
        Slashed = 1,
        
        /// <summary>
        /// >> AutoMigrationFinished
        /// The auto migration task finished.
        /// </summary>
        AutoMigrationFinished = 2,
        
        /// <summary>
        /// >> Halted
        /// Migration got halted due to an error or miss-configuration.
        /// </summary>
        Halted = 3,
    }
    
    /// <summary>
    /// >> 515 - Variant[pallet_state_trie_migration.pallet.Event]
    /// Inner events of this pallet.
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.EnumMigrationCompute>>(Event.Migrated);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Slashed);
				AddTypeDecoder<BaseVoid>(Event.AutoMigrationFinished);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.pallet_state_trie_migration.pallet.EnumError>(Event.Halted);
        }
    }
}
