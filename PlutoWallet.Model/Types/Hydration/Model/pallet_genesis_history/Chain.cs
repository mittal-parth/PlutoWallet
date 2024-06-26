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


namespace Hydration.NetApi.Generated.Model.pallet_genesis_history
{
    
    
    /// <summary>
    /// >> 490 - Composite[pallet_genesis_history.Chain]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Chain : BaseType
    {
        
        /// <summary>
        /// >> genesis_hash
        /// </summary>
        public Hydration.NetApi.Generated.Model.primitive_types.H256 GenesisHash { get; set; }
        /// <summary>
        /// >> last_block_hash
        /// </summary>
        public Hydration.NetApi.Generated.Model.primitive_types.H256 LastBlockHash { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Chain";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(GenesisHash.Encode());
            result.AddRange(LastBlockHash.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            GenesisHash = new Hydration.NetApi.Generated.Model.primitive_types.H256();
            GenesisHash.Decode(byteArray, ref p);
            LastBlockHash = new Hydration.NetApi.Generated.Model.primitive_types.H256();
            LastBlockHash.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
