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


namespace Bifrost.NetApi.Generated.Model.bifrost_vesting.vesting_info
{
    
    
    /// <summary>
    /// >> 244 - Composite[bifrost_vesting.vesting_info.VestingInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class VestingInfo : BaseType
    {
        
        /// <summary>
        /// >> locked
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Locked { get; set; }
        /// <summary>
        /// >> per_block
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 PerBlock { get; set; }
        /// <summary>
        /// >> starting_block
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 StartingBlock { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "VestingInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Locked.Encode());
            result.AddRange(PerBlock.Encode());
            result.AddRange(StartingBlock.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Locked = new Substrate.NetApi.Model.Types.Primitive.U128();
            Locked.Decode(byteArray, ref p);
            PerBlock = new Substrate.NetApi.Model.Types.Primitive.U128();
            PerBlock.Decode(byteArray, ref p);
            StartingBlock = new Substrate.NetApi.Model.Types.Primitive.U32();
            StartingBlock.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
