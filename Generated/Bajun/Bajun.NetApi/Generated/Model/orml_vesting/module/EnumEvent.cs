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


namespace Bajun.NetApi.Generated.Model.orml_vesting.module
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> VestingScheduleAdded
        /// Added new vesting schedule.
        /// </summary>
        VestingScheduleAdded = 0,
        
        /// <summary>
        /// >> Claimed
        /// Claimed vesting.
        /// </summary>
        Claimed = 1,
        
        /// <summary>
        /// >> VestingSchedulesUpdated
        /// Updated vesting schedules.
        /// </summary>
        VestingSchedulesUpdated = 2,
    }
    
    /// <summary>
    /// >> 51 - Variant[orml_vesting.module.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.orml_vesting.VestingSchedule>>(Event.VestingScheduleAdded);
				AddTypeDecoder<BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Claimed);
				AddTypeDecoder<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Event.VestingSchedulesUpdated);
        }
    }
}
