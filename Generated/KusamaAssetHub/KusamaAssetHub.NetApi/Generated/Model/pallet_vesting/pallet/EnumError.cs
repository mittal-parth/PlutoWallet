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
    /// >> Error
    /// Error for the vesting pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> NotVesting
        /// The account given is not vesting.
        /// </summary>
        NotVesting = 0,
        
        /// <summary>
        /// >> AtMaxVestingSchedules
        /// The account already has `MaxVestingSchedules` count of schedules and thus
        /// cannot add another one. Consider merging existing schedules in order to add another.
        /// </summary>
        AtMaxVestingSchedules = 1,
        
        /// <summary>
        /// >> AmountLow
        /// Amount being transferred is too low to create a vesting schedule.
        /// </summary>
        AmountLow = 2,
        
        /// <summary>
        /// >> ScheduleIndexOutOfBounds
        /// An index was out of bounds of the vesting schedules.
        /// </summary>
        ScheduleIndexOutOfBounds = 3,
        
        /// <summary>
        /// >> InvalidScheduleParams
        /// Failed to create a new schedule because some parameter was invalid.
        /// </summary>
        InvalidScheduleParams = 4,
    }
    
    /// <summary>
    /// >> 246 - Variant[pallet_vesting.pallet.Error]
    /// Error for the vesting pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
