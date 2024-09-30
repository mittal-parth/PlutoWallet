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


namespace InvArch.NetApi.Generated.Model.polkadot_core_primitives
{
    
    
    /// <summary>
    /// >> 277 - Composite[polkadot_core_primitives.OutboundHrmpMessage]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class OutboundHrmpMessage : BaseType
    {
        
        /// <summary>
        /// >> recipient
        /// </summary>
        public InvArch.NetApi.Generated.Model.polkadot_parachain.primitives.Id Recipient { get; set; }
        /// <summary>
        /// >> data
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Data { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "OutboundHrmpMessage";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Recipient.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Recipient = new InvArch.NetApi.Generated.Model.polkadot_parachain.primitives.Id();
            Recipient.Decode(byteArray, ref p);
            Data = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Data.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
