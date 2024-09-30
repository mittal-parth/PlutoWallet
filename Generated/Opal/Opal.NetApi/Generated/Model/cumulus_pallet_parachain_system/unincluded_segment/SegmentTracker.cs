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


namespace Opal.NetApi.Generated.Model.cumulus_pallet_parachain_system.unincluded_segment
{
    
    
    /// <summary>
    /// >> 412 - Composite[cumulus_pallet_parachain_system.unincluded_segment.SegmentTracker]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SegmentTracker : BaseType
    {
        
        /// <summary>
        /// >> used_bandwidth
        /// </summary>
        public Opal.NetApi.Generated.Model.cumulus_pallet_parachain_system.unincluded_segment.UsedBandwidth UsedBandwidth { get; set; }
        /// <summary>
        /// >> hrmp_watermark
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> HrmpWatermark { get; set; }
        /// <summary>
        /// >> consumed_go_ahead_signal
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.polkadot_primitives.v6.EnumUpgradeGoAhead> ConsumedGoAheadSignal { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "SegmentTracker";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UsedBandwidth.Encode());
            result.AddRange(HrmpWatermark.Encode());
            result.AddRange(ConsumedGoAheadSignal.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UsedBandwidth = new Opal.NetApi.Generated.Model.cumulus_pallet_parachain_system.unincluded_segment.UsedBandwidth();
            UsedBandwidth.Decode(byteArray, ref p);
            HrmpWatermark = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            HrmpWatermark.Decode(byteArray, ref p);
            ConsumedGoAheadSignal = new Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.polkadot_primitives.v6.EnumUpgradeGoAhead>();
            ConsumedGoAheadSignal.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
