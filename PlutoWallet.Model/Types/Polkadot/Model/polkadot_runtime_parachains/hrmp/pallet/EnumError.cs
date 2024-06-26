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


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.hrmp.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> OpenHrmpChannelToSelf
        /// The sender tried to open a channel to themselves.
        /// </summary>
        OpenHrmpChannelToSelf = 0,
        
        /// <summary>
        /// >> OpenHrmpChannelInvalidRecipient
        /// The recipient is not a valid para.
        /// </summary>
        OpenHrmpChannelInvalidRecipient = 1,
        
        /// <summary>
        /// >> OpenHrmpChannelZeroCapacity
        /// The requested capacity is zero.
        /// </summary>
        OpenHrmpChannelZeroCapacity = 2,
        
        /// <summary>
        /// >> OpenHrmpChannelCapacityExceedsLimit
        /// The requested capacity exceeds the global limit.
        /// </summary>
        OpenHrmpChannelCapacityExceedsLimit = 3,
        
        /// <summary>
        /// >> OpenHrmpChannelZeroMessageSize
        /// The requested maximum message size is 0.
        /// </summary>
        OpenHrmpChannelZeroMessageSize = 4,
        
        /// <summary>
        /// >> OpenHrmpChannelMessageSizeExceedsLimit
        /// The open request requested the message size that exceeds the global limit.
        /// </summary>
        OpenHrmpChannelMessageSizeExceedsLimit = 5,
        
        /// <summary>
        /// >> OpenHrmpChannelAlreadyExists
        /// The channel already exists
        /// </summary>
        OpenHrmpChannelAlreadyExists = 6,
        
        /// <summary>
        /// >> OpenHrmpChannelAlreadyRequested
        /// There is already a request to open the same channel.
        /// </summary>
        OpenHrmpChannelAlreadyRequested = 7,
        
        /// <summary>
        /// >> OpenHrmpChannelLimitExceeded
        /// The sender already has the maximum number of allowed outbound channels.
        /// </summary>
        OpenHrmpChannelLimitExceeded = 8,
        
        /// <summary>
        /// >> AcceptHrmpChannelDoesntExist
        /// The channel from the sender to the origin doesn't exist.
        /// </summary>
        AcceptHrmpChannelDoesntExist = 9,
        
        /// <summary>
        /// >> AcceptHrmpChannelAlreadyConfirmed
        /// The channel is already confirmed.
        /// </summary>
        AcceptHrmpChannelAlreadyConfirmed = 10,
        
        /// <summary>
        /// >> AcceptHrmpChannelLimitExceeded
        /// The recipient already has the maximum number of allowed inbound channels.
        /// </summary>
        AcceptHrmpChannelLimitExceeded = 11,
        
        /// <summary>
        /// >> CloseHrmpChannelUnauthorized
        /// The origin tries to close a channel where it is neither the sender nor the recipient.
        /// </summary>
        CloseHrmpChannelUnauthorized = 12,
        
        /// <summary>
        /// >> CloseHrmpChannelDoesntExist
        /// The channel to be closed doesn't exist.
        /// </summary>
        CloseHrmpChannelDoesntExist = 13,
        
        /// <summary>
        /// >> CloseHrmpChannelAlreadyUnderway
        /// The channel close request is already requested.
        /// </summary>
        CloseHrmpChannelAlreadyUnderway = 14,
        
        /// <summary>
        /// >> CancelHrmpOpenChannelUnauthorized
        /// Canceling is requested by neither the sender nor recipient of the open channel request.
        /// </summary>
        CancelHrmpOpenChannelUnauthorized = 15,
        
        /// <summary>
        /// >> OpenHrmpChannelDoesntExist
        /// The open request doesn't exist.
        /// </summary>
        OpenHrmpChannelDoesntExist = 16,
        
        /// <summary>
        /// >> OpenHrmpChannelAlreadyConfirmed
        /// Cannot cancel an HRMP open channel request because it is already confirmed.
        /// </summary>
        OpenHrmpChannelAlreadyConfirmed = 17,
        
        /// <summary>
        /// >> WrongWitness
        /// The provided witness data is wrong.
        /// </summary>
        WrongWitness = 18,
        
        /// <summary>
        /// >> ChannelCreationNotAuthorized
        /// The channel between these two chains cannot be authorized.
        /// </summary>
        ChannelCreationNotAuthorized = 19,
    }
    
    /// <summary>
    /// >> 794 - Variant[polkadot_runtime_parachains.hrmp.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
