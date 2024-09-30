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


namespace KusamaAssetHub.NetApi.Generated.Model.pallet_asset_conversion.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> PoolCreated
        /// A successful call of the `CreatePool` extrinsic will create this event.
        /// </summary>
        PoolCreated = 0,
        
        /// <summary>
        /// >> LiquidityAdded
        /// A successful call of the `AddLiquidity` extrinsic will create this event.
        /// </summary>
        LiquidityAdded = 1,
        
        /// <summary>
        /// >> LiquidityRemoved
        /// A successful call of the `RemoveLiquidity` extrinsic will create this event.
        /// </summary>
        LiquidityRemoved = 2,
        
        /// <summary>
        /// >> SwapExecuted
        /// Assets have been converted from one to another. Both `SwapExactTokenForToken`
        /// and `SwapTokenForExactToken` will generate this event.
        /// </summary>
        SwapExecuted = 3,
        
        /// <summary>
        /// >> SwapCreditExecuted
        /// Assets have been converted from one to another.
        /// </summary>
        SwapCreditExecuted = 4,
        
        /// <summary>
        /// >> Touched
        /// Pool has been touched in order to fulfill operational requirements.
        /// </summary>
        Touched = 5,
    }
    
    /// <summary>
    /// >> 148 - Variant[pallet_asset_conversion.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseTuple<KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.PoolCreated);
				AddTypeDecoder<BaseTuple<KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseTuple<KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.LiquidityAdded);
				AddTypeDecoder<BaseTuple<KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseTuple<KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, KusamaAssetHub.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>>(Event.LiquidityRemoved);
				AddTypeDecoder<BaseTuple<KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U128>>>>(Event.SwapExecuted);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U128>>>>(Event.SwapCreditExecuted);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseTuple<KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, KusamaAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, KusamaAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.Touched);
        }
    }
}
