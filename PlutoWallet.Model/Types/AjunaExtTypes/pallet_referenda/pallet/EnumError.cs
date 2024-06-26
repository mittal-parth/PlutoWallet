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


namespace Substrate.NetApi.Generated.Model.pallet_referenda.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> NotOngoing
        /// Referendum is not ongoing.
        /// </summary>
        NotOngoing = 0,
        
        /// <summary>
        /// >> HasDeposit
        /// Referendum's decision deposit is already paid.
        /// </summary>
        HasDeposit = 1,
        
        /// <summary>
        /// >> BadTrack
        /// The track identifier given was invalid.
        /// </summary>
        BadTrack = 2,
        
        /// <summary>
        /// >> Full
        /// There are already a full complement of referenda in progress for this track.
        /// </summary>
        Full = 3,
        
        /// <summary>
        /// >> QueueEmpty
        /// The queue of the track is empty.
        /// </summary>
        QueueEmpty = 4,
        
        /// <summary>
        /// >> BadReferendum
        /// The referendum index provided is invalid in this context.
        /// </summary>
        BadReferendum = 5,
        
        /// <summary>
        /// >> NothingToDo
        /// There was nothing to do in the advancement.
        /// </summary>
        NothingToDo = 6,
        
        /// <summary>
        /// >> NoTrack
        /// No track exists for the proposal origin.
        /// </summary>
        NoTrack = 7,
        
        /// <summary>
        /// >> Unfinished
        /// Any deposit cannot be refunded until after the decision is over.
        /// </summary>
        Unfinished = 8,
        
        /// <summary>
        /// >> NoPermission
        /// The deposit refunder is not the depositor.
        /// </summary>
        NoPermission = 9,
        
        /// <summary>
        /// >> NoDeposit
        /// The deposit cannot be refunded since none was made.
        /// </summary>
        NoDeposit = 10,
        
        /// <summary>
        /// >> BadStatus
        /// The referendum status is invalid for this operation.
        /// </summary>
        BadStatus = 11,
        
        /// <summary>
        /// >> PreimageNotExist
        /// The preimage does not exist.
        /// </summary>
        PreimageNotExist = 12,
    }
    
    /// <summary>
    /// >> 660 - Variant[pallet_referenda.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
