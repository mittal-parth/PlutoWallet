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


namespace Bifrost.NetApi.Generated.Model.pallet_scheduler
{
    
    
    /// <summary>
    /// >> 643 - Composite[pallet_scheduler.Scheduled]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Scheduled : BaseType
    {
        
        /// <summary>
        /// >> maybe_id
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Types.Base.Arr32U8> MaybeId { get; set; }
        /// <summary>
        /// >> priority
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 Priority { get; set; }
        /// <summary>
        /// >> call
        /// </summary>
        public Bifrost.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded Call { get; set; }
        /// <summary>
        /// >> maybe_periodic
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>> MaybePeriodic { get; set; }
        /// <summary>
        /// >> origin
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_polkadot_runtime.EnumOriginCaller Origin { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Scheduled";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaybeId.Encode());
            result.AddRange(Priority.Encode());
            result.AddRange(Call.Encode());
            result.AddRange(MaybePeriodic.Encode());
            result.AddRange(Origin.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaybeId = new Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Types.Base.Arr32U8>();
            MaybeId.Decode(byteArray, ref p);
            Priority = new Substrate.NetApi.Model.Types.Primitive.U8();
            Priority.Decode(byteArray, ref p);
            Call = new Bifrost.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded();
            Call.Decode(byteArray, ref p);
            MaybePeriodic = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>();
            MaybePeriodic.Decode(byteArray, ref p);
            Origin = new Bifrost.NetApi.Generated.Model.bifrost_polkadot_runtime.EnumOriginCaller();
            Origin.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
