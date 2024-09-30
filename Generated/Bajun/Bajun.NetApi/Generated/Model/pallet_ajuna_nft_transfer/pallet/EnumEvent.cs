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


namespace Bajun.NetApi.Generated.Model.pallet_ajuna_nft_transfer.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> ItemStored
        /// Item has been stored as an NFT [collection_id, item_id, owner]
        /// </summary>
        ItemStored = 0,
        
        /// <summary>
        /// >> ItemRestored
        /// Item has been restored back from its NFT representation [collection_id, item_id, owner]
        /// </summary>
        ItemRestored = 1,
    }
    
    /// <summary>
    /// >> 198 - Variant[pallet_ajuna_nft_transfer.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.primitive_types.H256, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.ItemStored);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.primitive_types.H256, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.ItemRestored);
        }
    }
}
