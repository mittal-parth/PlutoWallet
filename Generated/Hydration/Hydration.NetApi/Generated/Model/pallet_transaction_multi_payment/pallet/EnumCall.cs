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


namespace Hydration.NetApi.Generated.Model.pallet_transaction_multi_payment.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_currency
        /// See [`Pallet::set_currency`].
        /// </summary>
        set_currency = 0,
        
        /// <summary>
        /// >> add_currency
        /// See [`Pallet::add_currency`].
        /// </summary>
        add_currency = 1,
        
        /// <summary>
        /// >> remove_currency
        /// See [`Pallet::remove_currency`].
        /// </summary>
        remove_currency = 2,
        
        /// <summary>
        /// >> reset_payment_currency
        /// See [`Pallet::reset_payment_currency`].
        /// </summary>
        reset_payment_currency = 3,
        
        /// <summary>
        /// >> dispatch_permit
        /// See [`Pallet::dispatch_permit`].
        /// </summary>
        dispatch_permit = 4,
    }
    
    /// <summary>
    /// >> 274 - Variant[pallet_transaction_multi_payment.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.set_currency);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>>(Call.add_currency);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.remove_currency);
				AddTypeDecoder<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Call.reset_payment_currency);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.primitive_types.H160, Hydration.NetApi.Generated.Model.primitive_types.H160, Hydration.NetApi.Generated.Model.primitive_types.U256, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Hydration.NetApi.Generated.Model.primitive_types.U256, Substrate.NetApi.Model.Types.Primitive.U8, Hydration.NetApi.Generated.Model.primitive_types.H256, Hydration.NetApi.Generated.Model.primitive_types.H256>>(Call.dispatch_permit);
        }
    }
}
