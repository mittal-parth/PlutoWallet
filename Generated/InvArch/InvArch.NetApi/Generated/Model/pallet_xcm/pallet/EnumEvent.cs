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


namespace InvArch.NetApi.Generated.Model.pallet_xcm.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Attempted
        /// Execution of an XCM message was attempted.
        /// 
        /// \[ outcome \]
        /// </summary>
        Attempted = 0,
        
        /// <summary>
        /// >> Sent
        /// A XCM message was sent.
        /// 
        /// \[ origin, destination, message \]
        /// </summary>
        Sent = 1,
        
        /// <summary>
        /// >> UnexpectedResponse
        /// Query response received which does not match a registered query. This may be because a
        /// matching query was never registered, it may be because it is a duplicate response, or
        /// because the query timed out.
        /// 
        /// \[ origin location, id \]
        /// </summary>
        UnexpectedResponse = 2,
        
        /// <summary>
        /// >> ResponseReady
        /// Query response has been received and is ready for taking with `take_response`. There is
        /// no registered notification call.
        /// 
        /// \[ id, response \]
        /// </summary>
        ResponseReady = 3,
        
        /// <summary>
        /// >> Notified
        /// Query response has been received and query is removed. The registered notification has
        /// been dispatched and executed successfully.
        /// 
        /// \[ id, pallet index, call index \]
        /// </summary>
        Notified = 4,
        
        /// <summary>
        /// >> NotifyOverweight
        /// Query response has been received and query is removed. The registered notification could
        /// not be dispatched because the dispatch weight is greater than the maximum weight
        /// originally budgeted by this runtime for the query result.
        /// 
        /// \[ id, pallet index, call index, actual weight, max budgeted weight \]
        /// </summary>
        NotifyOverweight = 5,
        
        /// <summary>
        /// >> NotifyDispatchError
        /// Query response has been received and query is removed. There was a general error with
        /// dispatching the notification call.
        /// 
        /// \[ id, pallet index, call index \]
        /// </summary>
        NotifyDispatchError = 6,
        
        /// <summary>
        /// >> NotifyDecodeFailed
        /// Query response has been received and query is removed. The dispatch was unable to be
        /// decoded into a `Call`; this might be due to dispatch function having a signature which
        /// is not `(origin, QueryId, Response)`.
        /// 
        /// \[ id, pallet index, call index \]
        /// </summary>
        NotifyDecodeFailed = 7,
        
        /// <summary>
        /// >> InvalidResponder
        /// Expected query response has been received but the origin location of the response does
        /// not match that expected. The query remains registered for a later, valid, response to
        /// be received and acted upon.
        /// 
        /// \[ origin location, id, expected location \]
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
        /// 
        /// \[ origin location, id \]
        /// </summary>
        InvalidResponderVersion = 9,
        
        /// <summary>
        /// >> ResponseTaken
        /// Received query response has been read and removed.
        /// 
        /// \[ id \]
        /// </summary>
        ResponseTaken = 10,
        
        /// <summary>
        /// >> AssetsTrapped
        /// Some assets have been placed in an asset trap.
        /// 
        /// \[ hash, origin, assets \]
        /// </summary>
        AssetsTrapped = 11,
        
        /// <summary>
        /// >> VersionChangeNotified
        /// An XCM version change notification message has been attempted to be sent.
        /// 
        /// The cost of sending it (borne by the chain) is included.
        /// 
        /// \[ destination, result, cost \]
        /// </summary>
        VersionChangeNotified = 12,
        
        /// <summary>
        /// >> SupportedVersionChanged
        /// The supported version of a location has been changed. This might be through an
        /// automatic notification or a manual intervention.
        /// 
        /// \[ location, XCM version \]
        /// </summary>
        SupportedVersionChanged = 13,
        
        /// <summary>
        /// >> NotifyTargetSendFail
        /// A given location which had a version change subscription was dropped owing to an error
        /// sending the notification to it.
        /// 
        /// \[ location, query ID, error \]
        /// </summary>
        NotifyTargetSendFail = 14,
        
        /// <summary>
        /// >> NotifyTargetMigrationFail
        /// A given location which had a version change subscription was dropped owing to an error
        /// migrating the location to our new XCM format.
        /// 
        /// \[ location, query ID \]
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
        /// 
        /// \[ origin location, id \]
        /// </summary>
        InvalidQuerierVersion = 16,
        
        /// <summary>
        /// >> InvalidQuerier
        /// Expected query response has been received but the querier location of the response does
        /// not match the expected. The query remains registered for a later, valid, response to
        /// be received and acted upon.
        /// 
        /// \[ origin location, id, expected querier, maybe actual querier \]
        /// </summary>
        InvalidQuerier = 17,
        
        /// <summary>
        /// >> VersionNotifyStarted
        /// A remote has requested XCM version change notification from us and we have honored it.
        /// A version information message is sent to them and its cost is included.
        /// 
        /// \[ destination location, cost \]
        /// </summary>
        VersionNotifyStarted = 18,
        
        /// <summary>
        /// >> VersionNotifyRequested
        /// We have requested that a remote chain sends us XCM version change notifications.
        /// 
        /// \[ destination location, cost \]
        /// </summary>
        VersionNotifyRequested = 19,
        
        /// <summary>
        /// >> VersionNotifyUnrequested
        /// We have requested that a remote chain stops sending us XCM version change notifications.
        /// 
        /// \[ destination location, cost \]
        /// </summary>
        VersionNotifyUnrequested = 20,
        
        /// <summary>
        /// >> FeesPaid
        /// Fees were paid from a location for an operation (often for using `SendXcm`).
        /// 
        /// \[ paying location, fees \]
        /// </summary>
        FeesPaid = 21,
        
        /// <summary>
        /// >> AssetsClaimed
        /// Some assets have been claimed from an asset trap
        /// 
        /// \[ hash, origin, assets \]
        /// </summary>
        AssetsClaimed = 22,
    }
    
    /// <summary>
    /// >> 53 - Variant[pallet_xcm.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<InvArch.NetApi.Generated.Model.xcm.v3.traits.EnumOutcome>(Event.Attempted);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, InvArch.NetApi.Generated.Model.xcm.v3.XcmT1>>(Event.Sent);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U64>>(Event.UnexpectedResponse);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, InvArch.NetApi.Generated.Model.xcm.v3.EnumResponse>>(Event.ResponseReady);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U8>>(Event.Notified);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U8, InvArch.NetApi.Generated.Model.sp_weights.weight_v2.Weight, InvArch.NetApi.Generated.Model.sp_weights.weight_v2.Weight>>(Event.NotifyOverweight);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U8>>(Event.NotifyDispatchError);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U8>>(Event.NotifyDecodeFailed);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Base.BaseOpt<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation>>>(Event.InvalidResponder);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U64>>(Event.InvalidResponderVersion);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U64>(Event.ResponseTaken);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.primitive_types.H256, InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, InvArch.NetApi.Generated.Model.xcm.EnumVersionedMultiAssets>>(Event.AssetsTrapped);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U32, InvArch.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets>>(Event.VersionChangeNotified);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.SupportedVersionChanged);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U64, InvArch.NetApi.Generated.Model.xcm.v3.traits.EnumError>>(Event.NotifyTargetSendFail);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.NetApi.Model.Types.Primitive.U64>>(Event.NotifyTargetMigrationFail);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U64>>(Event.InvalidQuerierVersion);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U64, InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseOpt<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation>>>(Event.InvalidQuerier);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, InvArch.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets>>(Event.VersionNotifyStarted);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, InvArch.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets>>(Event.VersionNotifyRequested);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, InvArch.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets>>(Event.VersionNotifyUnrequested);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, InvArch.NetApi.Generated.Model.xcm.v3.multiasset.MultiAssets>>(Event.FeesPaid);
				AddTypeDecoder<BaseTuple<InvArch.NetApi.Generated.Model.primitive_types.H256, InvArch.NetApi.Generated.Model.xcm.v3.multilocation.MultiLocation, InvArch.NetApi.Generated.Model.xcm.EnumVersionedMultiAssets>>(Event.AssetsClaimed);
        }
    }
}
