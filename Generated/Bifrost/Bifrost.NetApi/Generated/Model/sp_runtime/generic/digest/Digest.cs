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


namespace Bifrost.NetApi.Generated.Model.sp_runtime.generic.digest
{
    
    
    /// <summary>
    /// >> 15 - Composite[sp_runtime.generic.digest.Digest]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Digest : BaseType
    {
        
        /// <summary>
        /// >> logs
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.sp_runtime.generic.digest.EnumDigestItem> Logs { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Digest";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Logs.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Logs = new Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.sp_runtime.generic.digest.EnumDigestItem>();
            Logs.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
