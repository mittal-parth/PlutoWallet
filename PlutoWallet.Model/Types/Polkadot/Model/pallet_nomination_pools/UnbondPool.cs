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


namespace Polkadot.NetApi.Generated.Model.pallet_nomination_pools
{
    
    
    /// <summary>
    /// >> 728 - Composite[pallet_nomination_pools.UnbondPool]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UnbondPool : BaseType
    {
        
        /// <summary>
        /// >> points
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Points { get; set; }
        /// <summary>
        /// >> balance
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Balance { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "UnbondPool";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Points.Encode());
            result.AddRange(Balance.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Points = new Substrate.NetApi.Model.Types.Primitive.U128();
            Points.Decode(byteArray, ref p);
            Balance = new Substrate.NetApi.Model.Types.Primitive.U128();
            Balance.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
