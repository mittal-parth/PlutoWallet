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


namespace Bifrost.NetApi.Generated.Model.bifrost_farming.boost
{
    
    
    /// <summary>
    /// >> 773 - Composite[bifrost_farming.boost.UserBoostInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UserBoostInfo : BaseType
    {
        
        /// <summary>
        /// >> vote_amount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 VoteAmount { get; set; }
        /// <summary>
        /// >> vote_list
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT46 VoteList { get; set; }
        /// <summary>
        /// >> last_vote
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LastVote { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "UserBoostInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(VoteAmount.Encode());
            result.AddRange(VoteList.Encode());
            result.AddRange(LastVote.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            VoteAmount = new Substrate.NetApi.Model.Types.Primitive.U128();
            VoteAmount.Decode(byteArray, ref p);
            VoteList = new Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT46();
            VoteList.Decode(byteArray, ref p);
            LastVote = new Substrate.NetApi.Model.Types.Primitive.U32();
            LastVote.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
