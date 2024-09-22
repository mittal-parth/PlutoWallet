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
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Bifrost.NetApi.Generated.Model.bifrost_vtoken_voting.vote
{
    
    
    /// <summary>
    /// >> 915 - Composite[bifrost_vtoken_voting.vote.Casting]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Casting : BaseType
    {
        
        /// <summary>
        /// >> votes
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT62 Votes { get; set; }
        /// <summary>
        /// >> delegations
        /// </summary>
        public Bifrost.NetApi.Generated.Model.pallet_conviction_voting.types.Delegations Delegations { get; set; }
        /// <summary>
        /// >> prior
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_vtoken_voting.vote.PriorLock Prior { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Casting";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Votes.Encode());
            result.AddRange(Delegations.Encode());
            result.AddRange(Prior.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Votes = new Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT62();
            Votes.Decode(byteArray, ref p);
            Delegations = new Bifrost.NetApi.Generated.Model.pallet_conviction_voting.types.Delegations();
            Delegations.Decode(byteArray, ref p);
            Prior = new Bifrost.NetApi.Generated.Model.bifrost_vtoken_voting.vote.PriorLock();
            Prior.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
