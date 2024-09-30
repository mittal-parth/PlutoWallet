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


namespace Bifrost.NetApi.Generated.Model.bifrost_system_maker.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_config
        /// </summary>
        set_config = 0,
        
        /// <summary>
        /// >> charge
        /// </summary>
        charge = 1,
        
        /// <summary>
        /// >> close
        /// </summary>
        close = 2,
        
        /// <summary>
        /// >> payout
        /// </summary>
        payout = 3,
    }
    
    /// <summary>
    /// >> 410 - Variant[bifrost_system_maker.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_system_maker.pallet.Info>>(Call.set_config);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.charge);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.close);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.payout);
        }
    }
}
