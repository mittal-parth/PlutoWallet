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
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Attempted
        /// Execution of an XCM message was attempted.
        /// </summary>
        Attempted = 0,
        
        /// <summary>
        /// >> Sent
        /// A XCM message was sent.
        /// </summary>
        Sent = 1,
        
        /// <summary>
        /// >> UnexpectedResponse
        /// Query response received which does not match a registered query. This may be because a
        /// matching query was never registered, it may be because it is a duplicate response, or
        /// because the query timed out.
        /// </summary>
        UnexpectedResponse = 2,
        
        /// <summary>
        /// >> ResponseReady
        /// Query response has been received and is ready for taking with `take_response`. There is
        /// no registered notification call.
        /// </summary>
        ResponseReady = 3,
        
        /// <summary>
        /// >> Notified
        /// Query response has been received and query is removed. The registered notification has
        /// been dispatched and executed successfully.
        /// </summary>
        Notified = 4,
        
        /// <summary>
        /// >> NotifyOverweight
        /// Query response has been received and query is removed. The registered notification
        /// could not be dispatched because the dispatch weight is greater than the maximum weight
        /// originally budgeted by this runtime for the query result.
        /// </summary>
        NotifyOverweight = 5,
        
        /// <summary>
        /// >> NotifyDispatchError
        /// Query response has been received and query is removed. There was a general error with
        /// dispatching the notification call.
        /// </summary>
        NotifyDispatchError = 6,
        
        /// <summary>
        /// >> NotifyDecodeFailed
        /// Query response has been received and query is removed. The dispatch was unable to be
        /// decoded into a `Call`; this might be due to dispatch function having a signature which
        /// is not `(origin, QueryId, Response)`.
        /// </summary>
        NotifyDecodeFailed = 7,
        
        /// <summary>
        /// >> InvalidResponder
        /// Expected query response has been received but the origin location of the response does
        /// not match that expected. The query remains registered for a later, valid, response to
        /// be received and acted upon.
        /// </summary>
        InvalidResponder = 8,
        
        /// <summary>
        /// >> InvalidResponderVersion
        /// Expected query response has been received but the expected origin location placed in
        /// storage by this runtime previously cannot be decoded. The query remains registered.
        /// 
        /// This is unexpected (since a location placed in storage in a previously executing
        /// runtime should be readable prior to query timeout) and dangerous since the possibly
        /// valid response will be dropped. Manual governance intervention is probably going to be
        /// needed.
        /// </summary>
        InvalidResponderVersion = 9,
        
        /// <summary>
        /// >> ResponseTaken
        /// Received query response has been read and removed.
        /// </summary>
        ResponseTaken = 10,
        
        /// <summary>
        /// >> AssetsTrapped
        /// Some assets have been placed in an asset trap.
        /// </summary>
        AssetsTrapped = 11,
        
        /// <summary>
        /// >> VersionChangeNotified
        /// An XCM version change notification message has been attempted to be sent.
        /// 
        /// The cost of sending it (borne by the chain) is included.
        /// </summary>
        VersionChangeNotified = 12,
        
        /// <summary>
        /// >> SupportedVersionChanged
        /// The supported version of a location has been changed. This might be through an
        /// automatic notification or a manual intervention.
        /// </summary>
        SupportedVersionChanged = 13,
        
        /// <summary>
        /// >> NotifyTargetSendFail
        /// A given location which had a version change subscription was dropped owing to an error
        /// sending the notification to it.
        /// </summary>
        NotifyTargetSendFail = 14,
        
        /// <summary>
        /// >> NotifyTargetMigrationFail
        /// A given location which had a version change subscription was dropped owing to an error
        /// migrating the location to our new XCM format.
        /// </summary>
        NotifyTargetMigrationFail = 15,
        
        /// <summary>
        /// >> InvalidQuerierVersion
        /// Expected query response has been received but the expected querier location placed in
        /// storage by this runtime previously cannot be decoded. The query remains registered.
        /// 
        /// This is unexpected (since a location placed in storage in a previously executing
        /// runtime should be readable prior to query timeout) and dangerous since the possibly
        /// valid response will be dropped. Manual governance intervention is probably going to be
        /// needed.
        /// </summary>
        InvalidQuerierVersion = 16,
        
        /// <summary>
        /// >> InvalidQuerier
        /// Expected query response has been received but the querier location of the response does
        /// not match the expected. The query remains registered for a later, valid, response to
        /// be received and acted upon.
        /// </summary>
        InvalidQuerier = 17,
        
        /// <summary>
        /// >> VersionNotifyStarted
        /// A remote has requested XCM version change notification from us and we have honored it.
        /// A version information message is sent to them and its cost is included.
        /// </summary>
        VersionNotifyStarted = 18,
        
        /// <summary>
        /// >> VersionNotifyRequested
        /// We have requested that a remote chain send us XCM version change notifications.
        /// </summary>
        VersionNotifyRequested = 19,
        
        /// <summary>
        /// >> VersionNotifyUnrequested
        /// We have requested that a remote chain stops sending us XCM version change
        /// notifications.
        /// </summary>
        VersionNotifyUnrequested = 20,
        
        /// <summary>
        /// >> FeesPaid
        /// Fees were paid from a location for an operation (often for using `SendXcm`).
        /// </summary>
        FeesPaid = 21,
        
        /// <summary>
        /// >> AssetsClaimed
        /// Some assets have been claimed from an asset trap
        /// </summary>
        AssetsClaimed = 22,
        
        /// <summary>
        /// >> VersionMigrationFinished
        /// A XCM version migration finished.
        /// </summary>
        VersionMigrationFinished = 23,
    }
    
    /// <summary>
    /// >> 51 - Variant[pallet_xcm.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.traits.EnumOutcome, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.XcmT1, PolkadotAssetHub.NetApi.Generated.Types.Base.Arr32U8>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.EnumResponse>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U8>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U8, PolkadotAssetHub.NetApi.Generated.Model.sp_weights.weight_v2.Weight, PolkadotAssetHub.NetApi.Generated.Model.sp_weights.weight_v2.Weight>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U8>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U8>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location>>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U64>, Substrate.NetApi.Model.Types.Primitive.U64, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.primitive_types.H256, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedAssets>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, PolkadotAssetHub.NetApi.Generated.Types.Base.Arr32U8>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U64, PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.traits.EnumError>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedLocation, Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Primitive.U64, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location>>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, PolkadotAssetHub.NetApi.Generated.Types.Base.Arr32U8>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, PolkadotAssetHub.NetApi.Generated.Types.Base.Arr32U8>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, PolkadotAssetHub.NetApi.Generated.Types.Base.Arr32U8>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.asset.Assets>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.primitive_types.H256, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v4.location.Location, PolkadotAssetHub.NetApi.Generated.Model.xcm.EnumVersionedAssets>, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
