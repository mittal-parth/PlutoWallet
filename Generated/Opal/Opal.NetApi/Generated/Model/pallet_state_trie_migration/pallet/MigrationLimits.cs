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


namespace Opal.NetApi.Generated.Model.pallet_state_trie_migration.pallet
{
    
    
    /// <summary>
    /// >> 91 - Composite[pallet_state_trie_migration.pallet.MigrationLimits]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MigrationLimits : BaseType
    {
        
        /// <summary>
        /// >> size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Size { get; set; }
        /// <summary>
        /// >> item
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Item { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MigrationLimits";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Size.Encode());
            result.AddRange(Item.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Size = new Substrate.NetApi.Model.Types.Primitive.U32();
            Size.Decode(byteArray, ref p);
            Item = new Substrate.NetApi.Model.Types.Primitive.U32();
            Item.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
