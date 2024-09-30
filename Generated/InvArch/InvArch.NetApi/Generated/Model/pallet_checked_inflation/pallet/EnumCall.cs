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


namespace InvArch.NetApi.Generated.Model.pallet_checked_inflation.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_first_year_supply
        /// </summary>
        set_first_year_supply = 0,
        
        /// <summary>
        /// >> halt_unhalt_pallet
        /// </summary>
        halt_unhalt_pallet = 1,
    }
    
    /// <summary>
    /// >> 234 - Variant[pallet_checked_inflation.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseVoid>(Call.set_first_year_supply);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.Bool>(Call.halt_unhalt_pallet);
        }
    }
}
