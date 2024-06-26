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


namespace Polkadot.NetApi.Generated.Model.sp_npos_elections
{
    
    
    /// <summary>
    /// >> 297 - Composite[sp_npos_elections.ElectionScore]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ElectionScore : BaseType
    {
        
        /// <summary>
        /// >> minimal_stake
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MinimalStake { get; set; }
        /// <summary>
        /// >> sum_stake
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 SumStake { get; set; }
        /// <summary>
        /// >> sum_stake_squared
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 SumStakeSquared { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ElectionScore";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MinimalStake.Encode());
            result.AddRange(SumStake.Encode());
            result.AddRange(SumStakeSquared.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MinimalStake = new Substrate.NetApi.Model.Types.Primitive.U128();
            MinimalStake.Decode(byteArray, ref p);
            SumStake = new Substrate.NetApi.Model.Types.Primitive.U128();
            SumStake.Decode(byteArray, ref p);
            SumStakeSquared = new Substrate.NetApi.Model.Types.Primitive.U128();
            SumStakeSquared.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
