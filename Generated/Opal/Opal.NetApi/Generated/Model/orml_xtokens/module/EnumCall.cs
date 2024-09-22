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


namespace Opal.NetApi.Generated.Model.orml_xtokens.module
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> transfer
        /// See [`Pallet::transfer`].
        /// </summary>
        transfer = 0,
        
        /// <summary>
        /// >> transfer_multiasset
        /// See [`Pallet::transfer_multiasset`].
        /// </summary>
        transfer_multiasset = 1,
        
        /// <summary>
        /// >> transfer_with_fee
        /// See [`Pallet::transfer_with_fee`].
        /// </summary>
        transfer_with_fee = 2,
        
        /// <summary>
        /// >> transfer_multiasset_with_fee
        /// See [`Pallet::transfer_multiasset_with_fee`].
        /// </summary>
        transfer_multiasset_with_fee = 3,
        
        /// <summary>
        /// >> transfer_multicurrencies
        /// See [`Pallet::transfer_multicurrencies`].
        /// </summary>
        transfer_multicurrencies = 4,
        
        /// <summary>
        /// >> transfer_multiassets
        /// See [`Pallet::transfer_multiassets`].
        /// </summary>
        transfer_multiassets = 5,
    }
    
    /// <summary>
    /// >> 125 - Variant[orml_xtokens.module.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Substrate.NetApi.Model.Types.Primitive.U128, Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiLocation, Opal.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>>(Call.transfer);
				AddTypeDecoder<BaseTuple<Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiAsset, Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiLocation, Opal.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>>(Call.transfer_multiasset);
				AddTypeDecoder<BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiLocation, Opal.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>>(Call.transfer_with_fee);
				AddTypeDecoder<BaseTuple<Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiAsset, Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiAsset, Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiLocation, Opal.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>>(Call.transfer_multiasset_with_fee);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Primitive.U32, Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiLocation, Opal.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>>(Call.transfer_multicurrencies);
				AddTypeDecoder<BaseTuple<Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiAssets, Substrate.NetApi.Model.Types.Primitive.U32, Opal.NetApi.Generated.Model.xcm.EnumVersionedMultiLocation, Opal.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>>(Call.transfer_multiassets);
        }
    }
}
