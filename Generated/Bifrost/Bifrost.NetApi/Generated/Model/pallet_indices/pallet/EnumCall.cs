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


namespace Bifrost.NetApi.Generated.Model.pallet_indices.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> claim
        /// Assign an previously unassigned index.
        /// 
        /// Payment: `Deposit` is reserved from the sender account.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// - `index`: the index to be claimed. This must not be in use.
        /// 
        /// Emits `IndexAssigned` if successful.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        claim = 0,
        
        /// <summary>
        /// >> transfer
        /// Assign an index already owned by the sender to another account. The balance reservation
        /// is effectively transferred to the new account.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// - `index`: the index to be re-assigned. This must be owned by the sender.
        /// - `new`: the new owner of the index. This function is a no-op if it is equal to sender.
        /// 
        /// Emits `IndexAssigned` if successful.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        transfer = 1,
        
        /// <summary>
        /// >> free
        /// Free up an index owned by the sender.
        /// 
        /// Payment: Any previous deposit placed for the index is unreserved in the sender account.
        /// 
        /// The dispatch origin for this call must be _Signed_ and the sender must own the index.
        /// 
        /// - `index`: the index to be freed. This must be owned by the sender.
        /// 
        /// Emits `IndexFreed` if successful.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        free = 2,
        
        /// <summary>
        /// >> force_transfer
        /// Force an index to an account. This doesn't require a deposit. If the index is already
        /// held, then any deposit is reimbursed to its current owner.
        /// 
        /// The dispatch origin for this call must be _Root_.
        /// 
        /// - `index`: the index to be (re-)assigned.
        /// - `new`: the new owner of the index. This function is a no-op if it is equal to sender.
        /// - `freeze`: if set to `true`, will freeze the index so it cannot be transferred.
        /// 
        /// Emits `IndexAssigned` if successful.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        force_transfer = 3,
        
        /// <summary>
        /// >> freeze
        /// Freeze an index so it will always point to the sender account. This consumes the
        /// deposit.
        /// 
        /// The dispatch origin for this call must be _Signed_ and the signing account must have a
        /// non-frozen account `index`.
        /// 
        /// - `index`: the index to be frozen in place.
        /// 
        /// Emits `IndexFrozen` if successful.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        freeze = 4,
    }
    
    /// <summary>
    /// >> 67 - Variant[pallet_indices.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.claim);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.transfer);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.free);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.force_transfer);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.freeze);
        }
    }
}
