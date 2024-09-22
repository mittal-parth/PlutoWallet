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


namespace InvArch.NetApi.Generated.Model.orml_vesting.module
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> claim
        /// </summary>
        claim = 0,
        
        /// <summary>
        /// >> vested_transfer
        /// </summary>
        vested_transfer = 1,
        
        /// <summary>
        /// >> update_vesting_schedules
        /// </summary>
        update_vesting_schedules = 2,
        
        /// <summary>
        /// >> claim_for
        /// </summary>
        claim_for = 3,
    }
    
    /// <summary>
    /// >> 162 - Variant[orml_vesting.module.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseVoid>(Call.claim);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, InvArch.NetApi.Generated.Model.orml_vesting.VestingSchedule>>(Call.vested_transfer);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseVec<InvArch.NetApi.Generated.Model.orml_vesting.VestingSchedule>>>(Call.update_vesting_schedules);
				AddTypeDecoder<InvArch.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.claim_for);
        }
    }
}
