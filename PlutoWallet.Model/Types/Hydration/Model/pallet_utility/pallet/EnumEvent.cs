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


namespace Hydration.NetApi.Generated.Model.pallet_utility.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> BatchInterrupted
        /// Batch of dispatches did not complete fully. Index of first failing dispatch given, as
        /// well as the error.
        /// </summary>
        BatchInterrupted = 0,
        
        /// <summary>
        /// >> BatchCompleted
        /// Batch of dispatches completed fully with no error.
        /// </summary>
        BatchCompleted = 1,
        
        /// <summary>
        /// >> BatchCompletedWithErrors
        /// Batch of dispatches completed but has errors.
        /// </summary>
        BatchCompletedWithErrors = 2,
        
        /// <summary>
        /// >> ItemCompleted
        /// A single item within a Batch of dispatches has completed with no error.
        /// </summary>
        ItemCompleted = 3,
        
        /// <summary>
        /// >> ItemFailed
        /// A single item within a Batch of dispatches has completed with error.
        /// </summary>
        ItemFailed = 4,
        
        /// <summary>
        /// >> DispatchedAs
        /// A call was dispatched.
        /// </summary>
        DispatchedAs = 5,
    }
    
    /// <summary>
    /// >> 34 - Variant[pallet_utility.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.sp_runtime.EnumDispatchError>, BaseVoid, BaseVoid, BaseVoid, Hydration.NetApi.Generated.Model.sp_runtime.EnumDispatchError, Hydration.NetApi.Generated.Types.Base.EnumResult>
    {
    }
}
