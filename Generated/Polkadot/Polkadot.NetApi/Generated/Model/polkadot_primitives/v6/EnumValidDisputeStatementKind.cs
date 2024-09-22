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


namespace Polkadot.NetApi.Generated.Model.polkadot_primitives.v6
{
    
    
    /// <summary>
    /// >> ValidDisputeStatementKind
    /// </summary>
    public enum ValidDisputeStatementKind
    {
        
        /// <summary>
        /// >> Explicit
        /// </summary>
        Explicit = 0,
        
        /// <summary>
        /// >> BackingSeconded
        /// </summary>
        BackingSeconded = 1,
        
        /// <summary>
        /// >> BackingValid
        /// </summary>
        BackingValid = 2,
        
        /// <summary>
        /// >> ApprovalChecking
        /// </summary>
        ApprovalChecking = 3,
        
        /// <summary>
        /// >> ApprovalCheckingMultipleCandidates
        /// </summary>
        ApprovalCheckingMultipleCandidates = 4,
    }
    
    /// <summary>
    /// >> 362 - Variant[polkadot_primitives.v6.ValidDisputeStatementKind]
    /// </summary>
    public sealed class EnumValidDisputeStatementKind : BaseEnumRust<ValidDisputeStatementKind>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumValidDisputeStatementKind()
        {
				AddTypeDecoder<BaseVoid>(ValidDisputeStatementKind.Explicit);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.primitive_types.H256>(ValidDisputeStatementKind.BackingSeconded);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.primitive_types.H256>(ValidDisputeStatementKind.BackingValid);
				AddTypeDecoder<BaseVoid>(ValidDisputeStatementKind.ApprovalChecking);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_core_primitives.CandidateHash>>(ValidDisputeStatementKind.ApprovalCheckingMultipleCandidates);
        }
    }
}
