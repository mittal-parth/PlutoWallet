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


namespace Polkadot.NetApi.Generated.Model.frame_support.dispatch
{
    
    
    /// <summary>
    /// >> 484 - Composite[frame_support.dispatch.PostDispatchInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PostDispatchInfo : BaseType
    {
        
        /// <summary>
        /// >> actual_weight
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Polkadot.NetApi.Generated.Model.sp_weights.weight_v2.Weight> ActualWeight { get; set; }
        /// <summary>
        /// >> pays_fee
        /// </summary>
        public Polkadot.NetApi.Generated.Model.frame_support.dispatch.EnumPays PaysFee { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PostDispatchInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ActualWeight.Encode());
            result.AddRange(PaysFee.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ActualWeight = new Substrate.NetApi.Model.Types.Base.BaseOpt<Polkadot.NetApi.Generated.Model.sp_weights.weight_v2.Weight>();
            ActualWeight.Decode(byteArray, ref p);
            PaysFee = new Polkadot.NetApi.Generated.Model.frame_support.dispatch.EnumPays();
            PaysFee.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
