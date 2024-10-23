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


namespace Unique.NetApi.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 575 - Composite[up_data_structs.PropertiesT1]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PropertiesT1 : BaseType
    {
        
        /// <summary>
        /// >> map
        /// </summary>
        public Unique.NetApi.Generated.Model.up_data_structs.PropertiesMapT1 Map { get; set; }
        /// <summary>
        /// >> consumed_space
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ConsumedSpace { get; set; }
        /// <summary>
        /// >> _reserved
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Reserved { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PropertiesT1";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Map.Encode());
            result.AddRange(ConsumedSpace.Encode());
            result.AddRange(Reserved.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Map = new Unique.NetApi.Generated.Model.up_data_structs.PropertiesMapT1();
            Map.Decode(byteArray, ref p);
            ConsumedSpace = new Substrate.NetApi.Model.Types.Primitive.U32();
            ConsumedSpace.Decode(byteArray, ref p);
            Reserved = new Substrate.NetApi.Model.Types.Primitive.U32();
            Reserved.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}