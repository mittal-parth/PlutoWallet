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


namespace PolkadotPeople.NetApi.Generated.Model.pallet_xcm.pallet
{
    
    
    /// <summary>
    /// >> Origin
    /// </summary>
    public enum Origin
    {
        
        /// <summary>
        /// >> Xcm
        /// </summary>
        Xcm = 0,
        
        /// <summary>
        /// >> Response
        /// </summary>
        Response = 1,
    }
    
    /// <summary>
    /// >> 369 - Variant[pallet_xcm.pallet.Origin]
    /// </summary>
    public sealed class EnumOrigin : BaseEnumRust<Origin>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumOrigin()
        {
				AddTypeDecoder<PolkadotPeople.NetApi.Generated.Model.staging_xcm.v4.location.Location>(Origin.Xcm);
				AddTypeDecoder<PolkadotPeople.NetApi.Generated.Model.staging_xcm.v4.location.Location>(Origin.Response);
        }
    }
}
