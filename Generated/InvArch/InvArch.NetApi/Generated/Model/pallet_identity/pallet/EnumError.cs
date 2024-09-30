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


namespace InvArch.NetApi.Generated.Model.pallet_identity.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> TooManySubAccounts
        /// Too many subs-accounts.
        /// </summary>
        TooManySubAccounts = 0,
        
        /// <summary>
        /// >> NotFound
        /// Account isn't found.
        /// </summary>
        NotFound = 1,
        
        /// <summary>
        /// >> NotNamed
        /// Account isn't named.
        /// </summary>
        NotNamed = 2,
        
        /// <summary>
        /// >> EmptyIndex
        /// Empty index.
        /// </summary>
        EmptyIndex = 3,
        
        /// <summary>
        /// >> FeeChanged
        /// Fee is changed.
        /// </summary>
        FeeChanged = 4,
        
        /// <summary>
        /// >> NoIdentity
        /// No identity found.
        /// </summary>
        NoIdentity = 5,
        
        /// <summary>
        /// >> StickyJudgement
        /// Sticky judgement.
        /// </summary>
        StickyJudgement = 6,
        
        /// <summary>
        /// >> JudgementGiven
        /// Judgement given.
        /// </summary>
        JudgementGiven = 7,
        
        /// <summary>
        /// >> InvalidJudgement
        /// Invalid judgement.
        /// </summary>
        InvalidJudgement = 8,
        
        /// <summary>
        /// >> InvalidIndex
        /// The index is invalid.
        /// </summary>
        InvalidIndex = 9,
        
        /// <summary>
        /// >> InvalidTarget
        /// The target is invalid.
        /// </summary>
        InvalidTarget = 10,
        
        /// <summary>
        /// >> TooManyFields
        /// Too many additional fields.
        /// </summary>
        TooManyFields = 11,
        
        /// <summary>
        /// >> TooManyRegistrars
        /// Maximum amount of registrars reached. Cannot add any more.
        /// </summary>
        TooManyRegistrars = 12,
        
        /// <summary>
        /// >> AlreadyClaimed
        /// Account ID is already named.
        /// </summary>
        AlreadyClaimed = 13,
        
        /// <summary>
        /// >> NotSub
        /// Sender is not a sub-account.
        /// </summary>
        NotSub = 14,
        
        /// <summary>
        /// >> NotOwned
        /// Sub-account isn't owned by sender.
        /// </summary>
        NotOwned = 15,
        
        /// <summary>
        /// >> JudgementForDifferentIdentity
        /// The provided judgement was for a different identity.
        /// </summary>
        JudgementForDifferentIdentity = 16,
        
        /// <summary>
        /// >> JudgementPaymentFailed
        /// Error that occurs when there is an issue paying for judgement.
        /// </summary>
        JudgementPaymentFailed = 17,
    }
    
    /// <summary>
    /// >> 353 - Variant[pallet_identity.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
