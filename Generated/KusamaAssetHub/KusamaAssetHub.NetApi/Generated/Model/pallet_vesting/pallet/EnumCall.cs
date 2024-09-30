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


namespace KusamaAssetHub.NetApi.Generated.Model.pallet_vesting.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> vest
        /// Unlock any vested funds of the sender account.
        /// 
        /// The dispatch origin for this call must be _Signed_ and the sender must have funds still
        /// locked under this pallet.
        /// 
        /// Emits either `VestingCompleted` or `VestingUpdated`.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        vest = 0,
        
        /// <summary>
        /// >> vest_other
        /// Unlock any vested funds of a `target` account.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// - `target`: The account whose vested funds should be unlocked. Must have funds still
        /// locked under this pallet.
        /// 
        /// Emits either `VestingCompleted` or `VestingUpdated`.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        vest_other = 1,
        
        /// <summary>
        /// >> vested_transfer
        /// Create a vested transfer.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// - `target`: The account receiving the vested funds.
        /// - `schedule`: The vesting schedule attached to the transfer.
        /// 
        /// Emits `VestingCreated`.
        /// 
        /// NOTE: This will unlock all schedules through the current block.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        vested_transfer = 2,
        
        /// <summary>
        /// >> force_vested_transfer
        /// Force a vested transfer.
        /// 
        /// The dispatch origin for this call must be _Root_.
        /// 
        /// - `source`: The account whose funds should be transferred.
        /// - `target`: The account that should be transferred the vested funds.
        /// - `schedule`: The vesting schedule attached to the transfer.
        /// 
        /// Emits `VestingCreated`.
        /// 
        /// NOTE: This will unlock all schedules through the current block.
        /// 
        /// ## Complexity
        /// - `O(1)`.
        /// </summary>
        force_vested_transfer = 3,
        
        /// <summary>
        /// >> merge_schedules
        /// Merge two vesting schedules together, creating a new vesting schedule that unlocks over
        /// the highest possible start and end blocks. If both schedules have already started the
        /// current block will be used as the schedule start; with the caveat that if one schedule
        /// is finished by the current block, the other will be treated as the new merged schedule,
        /// unmodified.
        /// 
        /// NOTE: If `schedule1_index == schedule2_index` this is a no-op.
        /// NOTE: This will unlock all schedules through the current block prior to merging.
        /// NOTE: If both schedules have ended by the current block, no new schedule will be created
        /// and both will be removed.
        /// 
        /// Merged schedule attributes:
        /// - `starting_block`: `MAX(schedule1.starting_block, scheduled2.starting_block,
        ///   current_block)`.
        /// - `ending_block`: `MAX(schedule1.ending_block, schedule2.ending_block)`.
        /// - `locked`: `schedule1.locked_at(current_block) + schedule2.locked_at(current_block)`.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// - `schedule1_index`: index of the first schedule to merge.
        /// - `schedule2_index`: index of the second schedule to merge.
        /// </summary>
        merge_schedules = 4,
        
        /// <summary>
        /// >> force_remove_vesting_schedule
        /// Force remove a vesting schedule
        /// 
        /// The dispatch origin for this call must be _Root_.
        /// 
        /// - `target`: An account that has a vesting schedule
        /// - `schedule_index`: The vesting schedule index that should be removed
        /// </summary>
        force_remove_vesting_schedule = 5,
    }
    
    /// <summary>
    /// >> 245 - Variant[pallet_vesting.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseVoid>(Call.vest);
				AddTypeDecoder<KusamaAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.vest_other);
				AddTypeDecoder<BaseTuple<KusamaAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, KusamaAssetHub.NetApi.Generated.Model.pallet_vesting.vesting_info.VestingInfo>>(Call.vested_transfer);
				AddTypeDecoder<BaseTuple<KusamaAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, KusamaAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, KusamaAssetHub.NetApi.Generated.Model.pallet_vesting.vesting_info.VestingInfo>>(Call.force_vested_transfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.merge_schedules);
				AddTypeDecoder<BaseTuple<KusamaAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.force_remove_vesting_schedule);
        }
    }
}
