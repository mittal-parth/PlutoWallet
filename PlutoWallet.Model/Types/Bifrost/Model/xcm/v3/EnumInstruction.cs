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


namespace Bifrost.NetApi.Generated.Model.xcm.v3
{
    
    
    /// <summary>
    /// >> Instruction
    /// </summary>
    public enum Instruction
    {
        
        /// <summary>
        /// >> WithdrawAsset
        /// </summary>
        WithdrawAsset = 0,
        
        /// <summary>
        /// >> ReserveAssetDeposited
        /// </summary>
        ReserveAssetDeposited = 1,
        
        /// <summary>
        /// >> ReceiveTeleportedAsset
        /// </summary>
        ReceiveTeleportedAsset = 2,
        
        /// <summary>
        /// >> QueryResponse
        /// </summary>
        QueryResponse = 3,
        
        /// <summary>
        /// >> TransferAsset
        /// </summary>
        TransferAsset = 4,
        
        /// <summary>
        /// >> TransferReserveAsset
        /// </summary>
        TransferReserveAsset = 5,
        
        /// <summary>
        /// >> Transact
        /// </summary>
        Transact = 6,
        
        /// <summary>
        /// >> HrmpNewChannelOpenRequest
        /// </summary>
        HrmpNewChannelOpenRequest = 7,
        
        /// <summary>
        /// >> HrmpChannelAccepted
        /// </summary>
        HrmpChannelAccepted = 8,
        
        /// <summary>
        /// >> HrmpChannelClosing
        /// </summary>
        HrmpChannelClosing = 9,
        
        /// <summary>
        /// >> ClearOrigin
        /// </summary>
        ClearOrigin = 10,
        
        /// <summary>
        /// >> DescendOrigin
        /// </summary>
        DescendOrigin = 11,
        
        /// <summary>
        /// >> ReportError
        /// </summary>
        ReportError = 12,
        
        /// <summary>
        /// >> DepositAsset
        /// </summary>
        DepositAsset = 13,
        
        /// <summary>
        /// >> DepositReserveAsset
        /// </summary>
        DepositReserveAsset = 14,
        
        /// <summary>
        /// >> ExchangeAsset
        /// </summary>
        ExchangeAsset = 15,
        
        /// <summary>
        /// >> InitiateReserveWithdraw
        /// </summary>
        InitiateReserveWithdraw = 16,
        
        /// <summary>
        /// >> InitiateTeleport
        /// </summary>
        InitiateTeleport = 17,
        
        /// <summary>
        /// >> ReportHolding
        /// </summary>
        ReportHolding = 18,
        
        /// <summary>
        /// >> BuyExecution
        /// </summary>
        BuyExecution = 19,
        
        /// <summary>
        /// >> RefundSurplus
        /// </summary>
        RefundSurplus = 20,
        
        /// <summary>
        /// >> SetErrorHandler
        /// </summary>
        SetErrorHandler = 21,
        
        /// <summary>
        /// >> SetAppendix
        /// </summary>
        SetAppendix = 22,
        
        /// <summary>
        /// >> ClearError
        /// </summary>
        ClearError = 23,
        
        /// <summary>
        /// >> ClaimAsset
        /// </summary>
        ClaimAsset = 24,
        
        /// <summary>
        /// >> Trap
        /// </summary>
        Trap = 25,
        
        /// <summary>
        /// >> SubscribeVersion
        /// </summary>
        SubscribeVersion = 26,
        
        /// <summary>
        /// >> UnsubscribeVersion
        /// </summary>
        UnsubscribeVersion = 27,
        
        /// <summary>
        /// >> BurnAsset
        /// </summary>
        BurnAsset = 28,
        
        /// <summary>
        /// >> ExpectAsset
        /// </summary>
        ExpectAsset = 29,
        
        /// <summary>
        /// >> ExpectOrigin
        /// </summary>
        ExpectOrigin = 30,
        
        /// <summary>
        /// >> ExpectError
        /// </summary>
        ExpectError = 31,
        
        /// <summary>
        /// >> ExpectTransactStatus
        /// </summary>
        ExpectTransactStatus = 32,
        
        /// <summary>
        /// >> QueryPallet
        /// </summary>
        QueryPallet = 33,
        
        /// <summary>
        /// >> ExpectPallet
        /// </summary>
        ExpectPallet = 34,
        
        /// <summary>
        /// >> ReportTransactStatus
        /// </summary>
        ReportTransactStatus = 35,
        
        /// <summary>
        /// >> ClearTransactStatus
        /// </summary>
        ClearTransactStatus = 36,
        
        /// <summary>
        /// >> UniversalOrigin
        /// </summary>
        UniversalOrigin = 37,
        
        /// <summary>
        /// >> ExportMessage
        /// </summary>
        ExportMessage = 38,
        
        /// <summary>
        /// >> LockAsset
        /// </summary>
        LockAsset = 39,
        
        /// <summary>
        /// >> UnlockAsset
        /// </summary>
        UnlockAsset = 40,
        
        /// <summary>
        /// >> NoteUnlockable
        /// </summary>
        NoteUnlockable = 41,
        
        /// <summary>
        /// >> RequestUnlock
        /// </summary>
        RequestUnlock = 42,
        
        /// <summary>
        /// >> SetFeesMode
        /// </summary>
        SetFeesMode = 43,
        
        /// <summary>
        /// >> SetTopic
        /// </summary>
        SetTopic = 44,
        
        /// <summary>
        /// >> ClearTopic
        /// </summary>
        ClearTopic = 45,
        
        /// <summary>
        /// >> AliasOrigin
        /// </summary>
        AliasOrigin = 46,
        
        /// <summary>
        /// >> UnpaidExecution
        /// </summary>
        UnpaidExecution = 47,
    }
    
    /// <summary>
    /// >> 189 - Variant[xcm.v3.Instruction]
    /// </summary>
    public sealed class EnumInstruction : BaseEnumExt<Instruction, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.xcm.v3.EnumResponse, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.xcm.v3.XcmT1>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v2.EnumOriginKind, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Bifrost.NetApi.Generated.Model.xcm.double_encoded.DoubleEncodedT2>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseVoid, Bifrost.NetApi.Generated.Model.xcm.v3.junctions.EnumJunctions, Bifrost.NetApi.Generated.Model.xcm.v3.QueryResponseInfo, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.EnumMultiAssetFilter, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.EnumMultiAssetFilter, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.xcm.v3.XcmT1>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.EnumMultiAssetFilter, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.EnumMultiAssetFilter, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.xcm.v3.XcmT1>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.EnumMultiAssetFilter, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.xcm.v3.XcmT1>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.QueryResponseInfo, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.EnumMultiAssetFilter>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAsset, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseVoid, Bifrost.NetApi.Generated.Model.xcm.v3.XcmT2, Bifrost.NetApi.Generated.Model.xcm.v3.XcmT2, BaseVoid, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight>, BaseVoid, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.xcm.v3.traits.EnumError>>, Bifrost.NetApi.Generated.Model.xcm.v3.EnumMaybeErrorCode, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Bifrost.NetApi.Generated.Model.xcm.v3.QueryResponseInfo>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, Bifrost.NetApi.Generated.Model.xcm.v3.QueryResponseInfo, BaseVoid, Bifrost.NetApi.Generated.Model.xcm.v3.junction.EnumJunction, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.junction.EnumNetworkId, Bifrost.NetApi.Generated.Model.xcm.v3.junctions.EnumJunctions, Bifrost.NetApi.Generated.Model.xcm.v3.XcmT1>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAsset, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAsset, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAsset, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.multiasset.MultiAsset, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Primitive.Bool, Bifrost.NetApi.Generated.Types.Base.Arr32U8, BaseVoid, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>>
    {
    }
}
