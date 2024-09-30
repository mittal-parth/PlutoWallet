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


namespace Hydration.NetApi.Generated.Model.pallet_xyk.types
{
    
    
    /// <summary>
    /// >> 144 - Composite[pallet_xyk.types.AssetPair]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AssetPair : BaseType
    {
        
        /// <summary>
        /// >> asset_in
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AssetIn { get; set; }
        /// <summary>
        /// >> asset_out
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AssetOut { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AssetPair";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AssetIn.Encode());
            result.AddRange(AssetOut.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AssetIn = new Substrate.NetApi.Model.Types.Primitive.U32();
            AssetIn.Decode(byteArray, ref p);
            AssetOut = new Substrate.NetApi.Model.Types.Primitive.U32();
            AssetOut.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
