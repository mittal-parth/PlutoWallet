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


namespace Opal.NetApi.Generated.Model.pallet_ranked_collective
{
    
    
    /// <summary>
    /// >> 514 - Composite[pallet_ranked_collective.MemberRecord]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MemberRecord : BaseType
    {
        
        /// <summary>
        /// >> rank
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U16 Rank { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MemberRecord";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Rank.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Rank = new Substrate.NetApi.Model.Types.Primitive.U16();
            Rank.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
