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


namespace PolkadotAssetHub.NetApi.Generated.Model.cumulus_pallet_dmp_queue.pallet
{
    
    
    /// <summary>
    /// >> MigrationState
    /// </summary>
    public enum MigrationState
    {
        
        /// <summary>
        /// >> NotStarted
        /// </summary>
        NotStarted = 0,
        
        /// <summary>
        /// >> StartedExport
        /// </summary>
        StartedExport = 1,
        
        /// <summary>
        /// >> CompletedExport
        /// </summary>
        CompletedExport = 2,
        
        /// <summary>
        /// >> StartedOverweightExport
        /// </summary>
        StartedOverweightExport = 3,
        
        /// <summary>
        /// >> CompletedOverweightExport
        /// </summary>
        CompletedOverweightExport = 4,
        
        /// <summary>
        /// >> StartedCleanup
        /// </summary>
        StartedCleanup = 5,
        
        /// <summary>
        /// >> Completed
        /// </summary>
        Completed = 6,
    }
    
    /// <summary>
    /// >> 327 - Variant[cumulus_pallet_dmp_queue.pallet.MigrationState]
    /// </summary>
    public sealed class EnumMigrationState : BaseEnumExt<MigrationState, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U64, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19>, BaseVoid>
    {
    }
}
