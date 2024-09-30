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


namespace Opal.NetApi.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 602 - Composite[up_data_structs.CollectionStats]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CollectionStats : BaseType
    {
        
        /// <summary>
        /// >> created
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Created { get; set; }
        /// <summary>
        /// >> destroyed
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Destroyed { get; set; }
        /// <summary>
        /// >> alive
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Alive { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CollectionStats";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Created.Encode());
            result.AddRange(Destroyed.Encode());
            result.AddRange(Alive.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Created = new Substrate.NetApi.Model.Types.Primitive.U32();
            Created.Decode(byteArray, ref p);
            Destroyed = new Substrate.NetApi.Model.Types.Primitive.U32();
            Destroyed.Decode(byteArray, ref p);
            Alive = new Substrate.NetApi.Model.Types.Primitive.U32();
            Alive.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
