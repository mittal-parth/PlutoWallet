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


namespace InvArch.NetApi.Generated.Model.pallet_identity.types
{
    
    
    /// <summary>
    /// >> Judgement
    /// </summary>
    public enum Judgement
    {
        
        /// <summary>
        /// >> Unknown
        /// </summary>
        Unknown = 0,
        
        /// <summary>
        /// >> FeePaid
        /// </summary>
        FeePaid = 1,
        
        /// <summary>
        /// >> Reasonable
        /// </summary>
        Reasonable = 2,
        
        /// <summary>
        /// >> KnownGood
        /// </summary>
        KnownGood = 3,
        
        /// <summary>
        /// >> OutOfDate
        /// </summary>
        OutOfDate = 4,
        
        /// <summary>
        /// >> LowQuality
        /// </summary>
        LowQuality = 5,
        
        /// <summary>
        /// >> Erroneous
        /// </summary>
        Erroneous = 6,
    }
    
    /// <summary>
    /// >> 233 - Variant[pallet_identity.types.Judgement]
    /// </summary>
    public sealed class EnumJudgement : BaseEnumRust<Judgement>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumJudgement()
        {
				AddTypeDecoder<BaseVoid>(Judgement.Unknown);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Judgement.FeePaid);
				AddTypeDecoder<BaseVoid>(Judgement.Reasonable);
				AddTypeDecoder<BaseVoid>(Judgement.KnownGood);
				AddTypeDecoder<BaseVoid>(Judgement.OutOfDate);
				AddTypeDecoder<BaseVoid>(Judgement.LowQuality);
				AddTypeDecoder<BaseVoid>(Judgement.Erroneous);
        }
    }
}
