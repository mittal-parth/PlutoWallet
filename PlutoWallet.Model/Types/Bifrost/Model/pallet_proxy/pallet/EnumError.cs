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


namespace Bifrost.NetApi.Generated.Model.pallet_proxy.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> TooMany
        /// There are too many proxies registered or too many announcements pending.
        /// </summary>
        TooMany = 0,
        
        /// <summary>
        /// >> NotFound
        /// Proxy registration not found.
        /// </summary>
        NotFound = 1,
        
        /// <summary>
        /// >> NotProxy
        /// Sender is not a proxy of the account to be proxied.
        /// </summary>
        NotProxy = 2,
        
        /// <summary>
        /// >> Unproxyable
        /// A call which is incompatible with the proxy type's filter was attempted.
        /// </summary>
        Unproxyable = 3,
        
        /// <summary>
        /// >> Duplicate
        /// Account is already a proxy.
        /// </summary>
        Duplicate = 4,
        
        /// <summary>
        /// >> NoPermission
        /// Call may not be made by proxy because it may escalate its privileges.
        /// </summary>
        NoPermission = 5,
        
        /// <summary>
        /// >> Unannounced
        /// Announcement, if made at all, was made too recently.
        /// </summary>
        Unannounced = 6,
        
        /// <summary>
        /// >> NoSelfProxy
        /// Cannot add self as proxy.
        /// </summary>
        NoSelfProxy = 7,
    }
    
    /// <summary>
    /// >> 654 - Variant[pallet_proxy.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
