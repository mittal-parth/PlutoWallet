//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.polkadot_primitives.v6
{
    
    
    /// <summary>
    /// >> 752 - Composite[polkadot_primitives.v6.ScrapedOnChainVotes]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ScrapedOnChainVotes : BaseType
    {
        
        /// <summary>
        /// >> session
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Session { get; set; }
        /// <summary>
        /// >> backing_validators_per_candidate
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CandidateReceipt, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex, Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.EnumValidityAttestation>>>> BackingValidatorsPerCandidate { get; set; }
        /// <summary>
        /// >> disputes
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.DisputeStatementSet> Disputes { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ScrapedOnChainVotes";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Session.Encode());
            result.AddRange(BackingValidatorsPerCandidate.Encode());
            result.AddRange(Disputes.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Session = new Substrate.NetApi.Model.Types.Primitive.U32();
            Session.Decode(byteArray, ref p);
            BackingValidatorsPerCandidate = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CandidateReceipt, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex, Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.EnumValidityAttestation>>>>();
            BackingValidatorsPerCandidate.Decode(byteArray, ref p);
            Disputes = new Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.DisputeStatementSet>();
            Disputes.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
