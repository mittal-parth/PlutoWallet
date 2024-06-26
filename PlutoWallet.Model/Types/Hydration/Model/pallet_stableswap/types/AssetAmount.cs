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


namespace Hydration.NetApi.Generated.Model.pallet_stableswap.types
{
    
    
    /// <summary>
    /// >> 104 - Composite[pallet_stableswap.types.AssetAmount]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AssetAmount : BaseType
    {
        
        /// <summary>
        /// >> asset_id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AssetId { get; set; }
        /// <summary>
        /// >> amount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AssetAmount";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AssetId.Encode());
            result.AddRange(Amount.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AssetId = new Substrate.NetApi.Model.Types.Primitive.U32();
            AssetId.Decode(byteArray, ref p);
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
