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
    /// >> 331 - Composite[polkadot_primitives.v6.InherentData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class InherentData : BaseType
    {
        
        /// <summary>
        /// >> bitfields
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.signed.UncheckedSigned> Bitfields { get; set; }
        /// <summary>
        /// >> backed_candidates
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.BackedCandidate> BackedCandidates { get; set; }
        /// <summary>
        /// >> disputes
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.DisputeStatementSet> Disputes { get; set; }
        /// <summary>
        /// >> parent_header
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_runtime.generic.header.Header ParentHeader { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "InherentData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Bitfields.Encode());
            result.AddRange(BackedCandidates.Encode());
            result.AddRange(Disputes.Encode());
            result.AddRange(ParentHeader.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Bitfields = new Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.signed.UncheckedSigned>();
            Bitfields.Decode(byteArray, ref p);
            BackedCandidates = new Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.BackedCandidate>();
            BackedCandidates.Decode(byteArray, ref p);
            Disputes = new Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.DisputeStatementSet>();
            Disputes.Decode(byteArray, ref p);
            ParentHeader = new Polkadot.NetApi.Generated.Model.sp_runtime.generic.header.Header();
            ParentHeader.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
