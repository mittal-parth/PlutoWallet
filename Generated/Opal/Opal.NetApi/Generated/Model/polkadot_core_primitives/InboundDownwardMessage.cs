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


namespace Opal.NetApi.Generated.Model.polkadot_core_primitives
{
    
    
    /// <summary>
    /// >> 102 - Composite[polkadot_core_primitives.InboundDownwardMessage]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class InboundDownwardMessage : BaseType
    {
        
        /// <summary>
        /// >> sent_at
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 SentAt { get; set; }
        /// <summary>
        /// >> msg
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Msg { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "InboundDownwardMessage";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SentAt.Encode());
            result.AddRange(Msg.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SentAt = new Substrate.NetApi.Model.Types.Primitive.U32();
            SentAt.Decode(byteArray, ref p);
            Msg = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Msg.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
