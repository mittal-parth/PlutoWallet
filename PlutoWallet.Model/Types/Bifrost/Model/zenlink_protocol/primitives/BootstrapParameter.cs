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


namespace Bifrost.NetApi.Generated.Model.zenlink_protocol.primitives
{
    
    
    /// <summary>
    /// >> 718 - Composite[zenlink_protocol.primitives.BootstrapParameter]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BootstrapParameter : BaseType
    {
        
        /// <summary>
        /// >> target_supply
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128> TargetSupply { get; set; }
        /// <summary>
        /// >> capacity_supply
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128> CapacitySupply { get; set; }
        /// <summary>
        /// >> accumulated_supply
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128> AccumulatedSupply { get; set; }
        /// <summary>
        /// >> end_block_number
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 EndBlockNumber { get; set; }
        /// <summary>
        /// >> pair_account
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32 PairAccount { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BootstrapParameter";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TargetSupply.Encode());
            result.AddRange(CapacitySupply.Encode());
            result.AddRange(AccumulatedSupply.Encode());
            result.AddRange(EndBlockNumber.Encode());
            result.AddRange(PairAccount.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TargetSupply = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>();
            TargetSupply.Decode(byteArray, ref p);
            CapacitySupply = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>();
            CapacitySupply.Decode(byteArray, ref p);
            AccumulatedSupply = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>();
            AccumulatedSupply.Decode(byteArray, ref p);
            EndBlockNumber = new Substrate.NetApi.Model.Types.Primitive.U32();
            EndBlockNumber.Decode(byteArray, ref p);
            PairAccount = new Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            PairAccount.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
