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


namespace InvArch.NetApi.Generated.Model.xcm.v2.multiasset
{
    
    
    /// <summary>
    /// >> Fungibility
    /// </summary>
    public enum Fungibility
    {
        
        /// <summary>
        /// >> Fungible
        /// </summary>
        Fungible = 0,
        
        /// <summary>
        /// >> NonFungible
        /// </summary>
        NonFungible = 1,
    }
    
    /// <summary>
    /// >> 105 - Variant[xcm.v2.multiasset.Fungibility]
    /// </summary>
    public sealed class EnumFungibility : BaseEnumRust<Fungibility>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumFungibility()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>(Fungibility.Fungible);
				AddTypeDecoder<InvArch.NetApi.Generated.Model.xcm.v2.multiasset.EnumAssetInstance>(Fungibility.NonFungible);
        }
    }
}
