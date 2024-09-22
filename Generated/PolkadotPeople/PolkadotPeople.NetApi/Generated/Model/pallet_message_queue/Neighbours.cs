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


namespace PolkadotPeople.NetApi.Generated.Model.pallet_message_queue
{
    
    
    /// <summary>
    /// >> 311 - Composite[pallet_message_queue.Neighbours]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Neighbours : BaseType
    {
        
        /// <summary>
        /// >> prev
        /// </summary>
        public PolkadotPeople.NetApi.Generated.Model.cumulus_primitives_core.EnumAggregateMessageOrigin Prev { get; set; }
        /// <summary>
        /// >> next
        /// </summary>
        public PolkadotPeople.NetApi.Generated.Model.cumulus_primitives_core.EnumAggregateMessageOrigin Next { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Neighbours";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Prev.Encode());
            result.AddRange(Next.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Prev = new PolkadotPeople.NetApi.Generated.Model.cumulus_primitives_core.EnumAggregateMessageOrigin();
            Prev.Decode(byteArray, ref p);
            Next = new PolkadotPeople.NetApi.Generated.Model.cumulus_primitives_core.EnumAggregateMessageOrigin();
            Next.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
