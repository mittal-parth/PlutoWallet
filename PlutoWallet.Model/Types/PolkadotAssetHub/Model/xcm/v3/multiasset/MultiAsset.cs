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


namespace PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.multiasset
{
    
    
    /// <summary>
    /// >> 111 - Composite[xcm.v3.multiasset.MultiAsset]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MultiAsset : BaseType
    {
        
        /// <summary>
        /// >> id
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.multiasset.EnumAssetId Id { get; set; }
        /// <summary>
        /// >> fun
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.multiasset.EnumFungibility Fun { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MultiAsset";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(Fun.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.multiasset.EnumAssetId();
            Id.Decode(byteArray, ref p);
            Fun = new PolkadotAssetHub.NetApi.Generated.Model.xcm.v3.multiasset.EnumFungibility();
            Fun.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
