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


namespace InvArch.NetApi.Generated.Model.cumulus_pallet_xcmp_queue
{
    
    
    /// <summary>
    /// >> 332 - Composite[cumulus_pallet_xcmp_queue.QueueConfigData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class QueueConfigData : BaseType
    {
        
        /// <summary>
        /// >> suspend_threshold
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 SuspendThreshold { get; set; }
        /// <summary>
        /// >> drop_threshold
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 DropThreshold { get; set; }
        /// <summary>
        /// >> resume_threshold
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ResumeThreshold { get; set; }
        /// <summary>
        /// >> threshold_weight
        /// </summary>
        public InvArch.NetApi.Generated.Model.sp_weights.weight_v2.Weight ThresholdWeight { get; set; }
        /// <summary>
        /// >> weight_restrict_decay
        /// </summary>
        public InvArch.NetApi.Generated.Model.sp_weights.weight_v2.Weight WeightRestrictDecay { get; set; }
        /// <summary>
        /// >> xcmp_max_individual_weight
        /// </summary>
        public InvArch.NetApi.Generated.Model.sp_weights.weight_v2.Weight XcmpMaxIndividualWeight { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "QueueConfigData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SuspendThreshold.Encode());
            result.AddRange(DropThreshold.Encode());
            result.AddRange(ResumeThreshold.Encode());
            result.AddRange(ThresholdWeight.Encode());
            result.AddRange(WeightRestrictDecay.Encode());
            result.AddRange(XcmpMaxIndividualWeight.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SuspendThreshold = new Substrate.NetApi.Model.Types.Primitive.U32();
            SuspendThreshold.Decode(byteArray, ref p);
            DropThreshold = new Substrate.NetApi.Model.Types.Primitive.U32();
            DropThreshold.Decode(byteArray, ref p);
            ResumeThreshold = new Substrate.NetApi.Model.Types.Primitive.U32();
            ResumeThreshold.Decode(byteArray, ref p);
            ThresholdWeight = new InvArch.NetApi.Generated.Model.sp_weights.weight_v2.Weight();
            ThresholdWeight.Decode(byteArray, ref p);
            WeightRestrictDecay = new InvArch.NetApi.Generated.Model.sp_weights.weight_v2.Weight();
            WeightRestrictDecay.Decode(byteArray, ref p);
            XcmpMaxIndividualWeight = new InvArch.NetApi.Generated.Model.sp_weights.weight_v2.Weight();
            XcmpMaxIndividualWeight.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
