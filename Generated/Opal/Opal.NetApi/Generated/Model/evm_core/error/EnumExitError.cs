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


namespace Opal.NetApi.Generated.Model.evm_core.error
{
    
    
    /// <summary>
    /// >> ExitError
    /// </summary>
    public enum ExitError
    {
        
        /// <summary>
        /// >> StackUnderflow
        /// </summary>
        StackUnderflow = 0,
        
        /// <summary>
        /// >> StackOverflow
        /// </summary>
        StackOverflow = 1,
        
        /// <summary>
        /// >> InvalidJump
        /// </summary>
        InvalidJump = 2,
        
        /// <summary>
        /// >> InvalidRange
        /// </summary>
        InvalidRange = 3,
        
        /// <summary>
        /// >> DesignatedInvalid
        /// </summary>
        DesignatedInvalid = 4,
        
        /// <summary>
        /// >> CallTooDeep
        /// </summary>
        CallTooDeep = 5,
        
        /// <summary>
        /// >> CreateCollision
        /// </summary>
        CreateCollision = 6,
        
        /// <summary>
        /// >> CreateContractLimit
        /// </summary>
        CreateContractLimit = 7,
        
        /// <summary>
        /// >> InvalidCode
        /// </summary>
        InvalidCode = 15,
        
        /// <summary>
        /// >> OutOfOffset
        /// </summary>
        OutOfOffset = 8,
        
        /// <summary>
        /// >> OutOfGas
        /// </summary>
        OutOfGas = 9,
        
        /// <summary>
        /// >> OutOfFund
        /// </summary>
        OutOfFund = 10,
        
        /// <summary>
        /// >> PCUnderflow
        /// </summary>
        PCUnderflow = 11,
        
        /// <summary>
        /// >> CreateEmpty
        /// </summary>
        CreateEmpty = 12,
        
        /// <summary>
        /// >> Other
        /// </summary>
        Other = 13,
        
        /// <summary>
        /// >> MaxNonce
        /// </summary>
        MaxNonce = 14,
    }
    
    /// <summary>
    /// >> 377 - Variant[evm_core.error.ExitError]
    /// </summary>
    public sealed class EnumExitError : BaseEnumRust<ExitError>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumExitError()
        {
				AddTypeDecoder<BaseVoid>(ExitError.StackUnderflow);
				AddTypeDecoder<BaseVoid>(ExitError.StackOverflow);
				AddTypeDecoder<BaseVoid>(ExitError.InvalidJump);
				AddTypeDecoder<BaseVoid>(ExitError.InvalidRange);
				AddTypeDecoder<BaseVoid>(ExitError.DesignatedInvalid);
				AddTypeDecoder<BaseVoid>(ExitError.CallTooDeep);
				AddTypeDecoder<BaseVoid>(ExitError.CreateCollision);
				AddTypeDecoder<BaseVoid>(ExitError.CreateContractLimit);
				AddTypeDecoder<Opal.NetApi.Generated.Model.evm_core.opcode.Opcode>(ExitError.InvalidCode);
				AddTypeDecoder<BaseVoid>(ExitError.OutOfOffset);
				AddTypeDecoder<BaseVoid>(ExitError.OutOfGas);
				AddTypeDecoder<BaseVoid>(ExitError.OutOfFund);
				AddTypeDecoder<BaseVoid>(ExitError.PCUnderflow);
				AddTypeDecoder<BaseVoid>(ExitError.CreateEmpty);
				AddTypeDecoder<Opal.NetApi.Generated.Types.Base.CowT1>(ExitError.Other);
				AddTypeDecoder<BaseVoid>(ExitError.MaxNonce);
        }
    }
}
