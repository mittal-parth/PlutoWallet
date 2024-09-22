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


namespace Bifrost.NetApi.Generated.Model.bifrost_buy_back.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_vtoken
        /// </summary>
        set_vtoken = 0,
        
        /// <summary>
        /// >> charge
        /// </summary>
        charge = 1,
        
        /// <summary>
        /// >> remove_vtoken
        /// </summary>
        remove_vtoken = 2,
    }
    
    /// <summary>
    /// >> 452 - Variant[bifrost_buy_back.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.set_vtoken);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.charge);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.remove_vtoken);
        }
    }
}
