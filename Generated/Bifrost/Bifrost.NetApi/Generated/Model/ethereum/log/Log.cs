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


namespace Bifrost.NetApi.Generated.Model.ethereum.log
{
    
    
    /// <summary>
    /// >> 485 - Composite[ethereum.log.Log]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Log : BaseType
    {
        
        /// <summary>
        /// >> address
        /// </summary>
        public Bifrost.NetApi.Generated.Model.primitive_types.H160 Address { get; set; }
        /// <summary>
        /// >> topics
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.primitive_types.H256> Topics { get; set; }
        /// <summary>
        /// >> data
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Data { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Log";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Address.Encode());
            result.AddRange(Topics.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Address = new Bifrost.NetApi.Generated.Model.primitive_types.H160();
            Address.Decode(byteArray, ref p);
            Topics = new Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.primitive_types.H256>();
            Topics.Decode(byteArray, ref p);
            Data = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Data.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
