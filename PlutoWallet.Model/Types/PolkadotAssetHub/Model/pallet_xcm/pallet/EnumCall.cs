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


namespace PolkadotAssetHub.NetApi.Generated.Model.pallet_xcm.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> send
        /// See [`Pallet::send`].
        /// </summary>
        send = 0,
        
        /// <summary>
        /// >> teleport_assets
        /// See [`Pallet::teleport_assets`].
        /// </summary>
        teleport_assets = 1,
        
        /// <summary>
        /// >> reserve_transfer_assets
        /// See [`Pallet::reserve_transfer_assets`].
        /// </summary>
        reserve_transfer_assets = 2,
        
        /// <summary>
        /// >> execute
        /// See [`Pallet::execute`].
        /// </summary>
        execute = 3,
        
        /// <summary>
        /// >> force_xcm_version
        /// See [`Pallet::force_xcm_version`].
        /// </summary>
        force_xcm_version = 4,
        
        /// <summary>
        /// >> force_default_xcm_version
        /// See [`Pallet::force_default_xcm_version`].
        /// </summary>
        force_default_xcm_version = 5,
        
        /// <summary>
        /// >> force_subscribe_version_notify
        /// See [`Pallet::force_subscribe_version_notify`].
        /// </summary>
        force_subscribe_version_notify = 6,
        
        /// <summary>
        /// >> force_unsubscribe_version_notify
        /// See [`Pallet::force_unsubscribe_version_notify`].
        /// </summary>
        force_unsubscribe_version_notify = 7,
        
        /// <summary>
        /// >> limited_reserve_transfer_assets
        /// See [`Pallet::limited_reserve_transfer_assets`].
        /// </summary>
        limited_reserve_transfer_assets = 8,
        
        /// <summary>
        /// >> limited_teleport_assets
        /// See [`Pallet::limited_teleport_assets`].
        /// </summary>
        limited_teleport_assets = 9,
        
        /// <summary>
        /// >> force_suspension
        /// See [`Pallet::force_suspension`].
        /// </summary>
        force_suspension = 10,
        
        /// <summary>
        /// >> transfer_assets
        /// See [`Pallet::transfer_assets`].
        /// </summary>
        transfer_assets = 11,
        
        /// <summary>
        /// >> claim_assets
        /// See [`Pallet::claim_assets`].
        /// </summary>
        claim_assets = 12,
    }
    
    /// <summary>
    /// >> 297 - Variant[pallet_xcm.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedXcm>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedAssets, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedAssets, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedXcm, PolkadotAssetHub.NetApi.Generated.Model.sp_weights.weight_v2.Weight>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedAssets, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedAssets, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, Substrate.NetApi.Model.Types.Primitive.Bool, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedAssets, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedAssets, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation>>
    {
    }
}
