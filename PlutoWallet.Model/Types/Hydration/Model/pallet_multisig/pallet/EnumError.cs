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


namespace Hydration.NetApi.Generated.Model.pallet_multisig.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> MinimumThreshold
        /// Threshold must be 2 or greater.
        /// </summary>
        MinimumThreshold = 0,
        
        /// <summary>
        /// >> AlreadyApproved
        /// Call is already approved by this signatory.
        /// </summary>
        AlreadyApproved = 1,
        
        /// <summary>
        /// >> NoApprovalsNeeded
        /// Call doesn't need any (more) approvals.
        /// </summary>
        NoApprovalsNeeded = 2,
        
        /// <summary>
        /// >> TooFewSignatories
        /// There are too few signatories in the list.
        /// </summary>
        TooFewSignatories = 3,
        
        /// <summary>
        /// >> TooManySignatories
        /// There are too many signatories in the list.
        /// </summary>
        TooManySignatories = 4,
        
        /// <summary>
        /// >> SignatoriesOutOfOrder
        /// The signatories were provided out of order; they should be ordered.
        /// </summary>
        SignatoriesOutOfOrder = 5,
        
        /// <summary>
        /// >> SenderInSignatories
        /// The sender was contained in the other signatories; it shouldn't be.
        /// </summary>
        SenderInSignatories = 6,
        
        /// <summary>
        /// >> NotFound
        /// Multisig operation not found when attempting to cancel.
        /// </summary>
        NotFound = 7,
        
        /// <summary>
        /// >> NotOwner
        /// Only the account that originally created the multisig is able to cancel it.
        /// </summary>
        NotOwner = 8,
        
        /// <summary>
        /// >> NoTimepoint
        /// No timepoint was given, yet the multisig operation is already underway.
        /// </summary>
        NoTimepoint = 9,
        
        /// <summary>
        /// >> WrongTimepoint
        /// A different timepoint was given to the multisig operation that is underway.
        /// </summary>
        WrongTimepoint = 10,
        
        /// <summary>
        /// >> UnexpectedTimepoint
        /// A timepoint was given, yet no multisig operation is underway.
        /// </summary>
        UnexpectedTimepoint = 11,
        
        /// <summary>
        /// >> MaxWeightTooLow
        /// The maximum weight information provided was too low.
        /// </summary>
        MaxWeightTooLow = 12,
        
        /// <summary>
        /// >> AlreadyStored
        /// The data to be stored is already stored.
        /// </summary>
        AlreadyStored = 13,
    }
    
    /// <summary>
    /// >> 477 - Variant[pallet_multisig.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
