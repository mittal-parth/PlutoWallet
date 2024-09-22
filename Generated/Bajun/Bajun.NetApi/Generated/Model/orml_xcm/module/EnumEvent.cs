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


namespace Bajun.NetApi.Generated.Model.orml_xcm.module
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Sent
        /// XCM message sent. \[to, message\]
        /// </summary>
        Sent = 0,
    }
    
    /// <summary>
    /// >> 138 - Variant[orml_xcm.module.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location, Bajun.NetApi.Generated.Model.staging_xcm.v4.XcmT1>>(Event.Sent);
        }
    }
}
