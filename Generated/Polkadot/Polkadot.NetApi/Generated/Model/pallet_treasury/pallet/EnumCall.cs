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


namespace Polkadot.NetApi.Generated.Model.pallet_treasury.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> propose_spend
        /// See [`Pallet::propose_spend`].
        /// </summary>
        propose_spend = 0,
        
        /// <summary>
        /// >> reject_proposal
        /// See [`Pallet::reject_proposal`].
        /// </summary>
        reject_proposal = 1,
        
        /// <summary>
        /// >> approve_proposal
        /// See [`Pallet::approve_proposal`].
        /// </summary>
        approve_proposal = 2,
        
        /// <summary>
        /// >> spend_local
        /// See [`Pallet::spend_local`].
        /// </summary>
        spend_local = 3,
        
        /// <summary>
        /// >> remove_approval
        /// See [`Pallet::remove_approval`].
        /// </summary>
        remove_approval = 4,
        
        /// <summary>
        /// >> spend
        /// See [`Pallet::spend`].
        /// </summary>
        spend = 5,
        
        /// <summary>
        /// >> payout
        /// See [`Pallet::payout`].
        /// </summary>
        payout = 6,
        
        /// <summary>
        /// >> check_status
        /// See [`Pallet::check_status`].
        /// </summary>
        check_status = 7,
        
        /// <summary>
        /// >> void_spend
        /// See [`Pallet::void_spend`].
        /// </summary>
        void_spend = 8,
    }
    
    /// <summary>
    /// >> 162 - Variant[pallet_treasury.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.propose_spend);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.reject_proposal);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.approve_proposal);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.spend_local);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.remove_approval);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_runtime_common.impls.EnumVersionedLocatableAsset, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Polkadot.NetApi.Generated.Model.xcm.EnumVersionedLocation, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.spend);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.payout);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.check_status);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.void_spend);
        }
    }
}
