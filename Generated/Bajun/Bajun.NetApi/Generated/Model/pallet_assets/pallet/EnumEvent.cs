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


namespace Bajun.NetApi.Generated.Model.pallet_assets.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Created
        /// Some asset class was created.
        /// </summary>
        Created = 0,
        
        /// <summary>
        /// >> Issued
        /// Some assets were issued.
        /// </summary>
        Issued = 1,
        
        /// <summary>
        /// >> Transferred
        /// Some assets were transferred.
        /// </summary>
        Transferred = 2,
        
        /// <summary>
        /// >> Burned
        /// Some assets were destroyed.
        /// </summary>
        Burned = 3,
        
        /// <summary>
        /// >> TeamChanged
        /// The management team changed.
        /// </summary>
        TeamChanged = 4,
        
        /// <summary>
        /// >> OwnerChanged
        /// The owner changed.
        /// </summary>
        OwnerChanged = 5,
        
        /// <summary>
        /// >> Frozen
        /// Some account `who` was frozen.
        /// </summary>
        Frozen = 6,
        
        /// <summary>
        /// >> Thawed
        /// Some account `who` was thawed.
        /// </summary>
        Thawed = 7,
        
        /// <summary>
        /// >> AssetFrozen
        /// Some asset `asset_id` was frozen.
        /// </summary>
        AssetFrozen = 8,
        
        /// <summary>
        /// >> AssetThawed
        /// Some asset `asset_id` was thawed.
        /// </summary>
        AssetThawed = 9,
        
        /// <summary>
        /// >> AccountsDestroyed
        /// Accounts were destroyed for given asset.
        /// </summary>
        AccountsDestroyed = 10,
        
        /// <summary>
        /// >> ApprovalsDestroyed
        /// Approvals were destroyed for given asset.
        /// </summary>
        ApprovalsDestroyed = 11,
        
        /// <summary>
        /// >> DestructionStarted
        /// An asset class is in the process of being destroyed.
        /// </summary>
        DestructionStarted = 12,
        
        /// <summary>
        /// >> Destroyed
        /// An asset class was destroyed.
        /// </summary>
        Destroyed = 13,
        
        /// <summary>
        /// >> ForceCreated
        /// Some asset class was force-created.
        /// </summary>
        ForceCreated = 14,
        
        /// <summary>
        /// >> MetadataSet
        /// New metadata has been set for an asset.
        /// </summary>
        MetadataSet = 15,
        
        /// <summary>
        /// >> MetadataCleared
        /// Metadata has been cleared for an asset.
        /// </summary>
        MetadataCleared = 16,
        
        /// <summary>
        /// >> ApprovedTransfer
        /// (Additional) funds have been approved for transfer to a destination account.
        /// </summary>
        ApprovedTransfer = 17,
        
        /// <summary>
        /// >> ApprovalCancelled
        /// An approval for account `delegate` was cancelled by `owner`.
        /// </summary>
        ApprovalCancelled = 18,
        
        /// <summary>
        /// >> TransferredApproved
        /// An `amount` was transferred in its entirety from `owner` to `destination` by
        /// the approved `delegate`.
        /// </summary>
        TransferredApproved = 19,
        
        /// <summary>
        /// >> AssetStatusChanged
        /// An asset has had its attributes changed by the `Force` origin.
        /// </summary>
        AssetStatusChanged = 20,
        
        /// <summary>
        /// >> AssetMinBalanceChanged
        /// The min_balance of an asset has been updated by the asset owner.
        /// </summary>
        AssetMinBalanceChanged = 21,
        
        /// <summary>
        /// >> Touched
        /// Some account `who` was created with a deposit from `depositor`.
        /// </summary>
        Touched = 22,
        
        /// <summary>
        /// >> Blocked
        /// Some account `who` was blocked.
        /// </summary>
        Blocked = 23,
        
        /// <summary>
        /// >> Deposited
        /// Some assets were deposited (e.g. for transaction fees).
        /// </summary>
        Deposited = 24,
        
        /// <summary>
        /// >> Withdrawn
        /// Some assets were withdrawn from the account (e.g. for transaction fees).
        /// </summary>
        Withdrawn = 25,
    }
    
    /// <summary>
    /// >> 202 - Variant[pallet_assets.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.Created);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Issued);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Transferred);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Burned);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.TeamChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.OwnerChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.Frozen);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.Thawed);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.AssetFrozen);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.AssetThawed);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.AccountsDestroyed);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.ApprovalsDestroyed);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.DestructionStarted);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.Destroyed);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.ForceCreated);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.Bool>>(Event.MetadataSet);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.MetadataCleared);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.ApprovedTransfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.ApprovalCancelled);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.TransferredApproved);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.AssetStatusChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.AssetMinBalanceChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.Touched);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.Blocked);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Deposited);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Withdrawn);
        }
    }
}
