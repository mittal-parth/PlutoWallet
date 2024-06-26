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


namespace Bifrost.NetApi.Generated.Model.pallet_democracy.types
{
    
    
    /// <summary>
    /// >> 543 - Composite[pallet_democracy.types.ReferendumStatus]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ReferendumStatus : BaseType
    {
        
        /// <summary>
        /// >> end
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 End { get; set; }
        /// <summary>
        /// >> proposal
        /// </summary>
        public Bifrost.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded Proposal { get; set; }
        /// <summary>
        /// >> threshold
        /// </summary>
        public Bifrost.NetApi.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold Threshold { get; set; }
        /// <summary>
        /// >> delay
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Delay { get; set; }
        /// <summary>
        /// >> tally
        /// </summary>
        public Bifrost.NetApi.Generated.Model.pallet_democracy.types.Tally Tally { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ReferendumStatus";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(End.Encode());
            result.AddRange(Proposal.Encode());
            result.AddRange(Threshold.Encode());
            result.AddRange(Delay.Encode());
            result.AddRange(Tally.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            End = new Substrate.NetApi.Model.Types.Primitive.U32();
            End.Decode(byteArray, ref p);
            Proposal = new Bifrost.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded();
            Proposal.Decode(byteArray, ref p);
            Threshold = new Bifrost.NetApi.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold();
            Threshold.Decode(byteArray, ref p);
            Delay = new Substrate.NetApi.Model.Types.Primitive.U32();
            Delay.Decode(byteArray, ref p);
            Tally = new Bifrost.NetApi.Generated.Model.pallet_democracy.types.Tally();
            Tally.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
