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


namespace Bifrost.NetApi.Generated.Model.pallet_referenda.types
{
    
    
    /// <summary>
    /// >> ReferendumInfo
    /// </summary>
    public enum ReferendumInfo
    {
        
        /// <summary>
        /// >> Ongoing
        /// </summary>
        Ongoing = 0,
        
        /// <summary>
        /// >> Approved
        /// </summary>
        Approved = 1,
        
        /// <summary>
        /// >> Rejected
        /// </summary>
        Rejected = 2,
        
        /// <summary>
        /// >> Cancelled
        /// </summary>
        Cancelled = 3,
        
        /// <summary>
        /// >> TimedOut
        /// </summary>
        TimedOut = 4,
        
        /// <summary>
        /// >> Killed
        /// </summary>
        Killed = 5,
    }
    
    /// <summary>
    /// >> 805 - Variant[pallet_referenda.types.ReferendumInfo]
    /// </summary>
    public sealed class EnumReferendumInfo : BaseEnumExt<ReferendumInfo, Bifrost.NetApi.Generated.Model.pallet_referenda.types.ReferendumStatusT2, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.pallet_referenda.types.Deposit>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.pallet_referenda.types.Deposit>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.pallet_referenda.types.Deposit>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.pallet_referenda.types.Deposit>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.pallet_referenda.types.Deposit>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.pallet_referenda.types.Deposit>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.pallet_referenda.types.Deposit>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.pallet_referenda.types.Deposit>>, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
