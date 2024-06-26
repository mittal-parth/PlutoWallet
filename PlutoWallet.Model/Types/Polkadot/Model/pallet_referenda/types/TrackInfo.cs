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


namespace Polkadot.NetApi.Generated.Model.pallet_referenda.types
{
    
    
    /// <summary>
    /// >> 656 - Composite[pallet_referenda.types.TrackInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class TrackInfo : BaseType
    {
        
        /// <summary>
        /// >> name
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Str Name { get; set; }
        /// <summary>
        /// >> max_deciding
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxDeciding { get; set; }
        /// <summary>
        /// >> decision_deposit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DecisionDeposit { get; set; }
        /// <summary>
        /// >> prepare_period
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 PreparePeriod { get; set; }
        /// <summary>
        /// >> decision_period
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 DecisionPeriod { get; set; }
        /// <summary>
        /// >> confirm_period
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ConfirmPeriod { get; set; }
        /// <summary>
        /// >> min_enactment_period
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MinEnactmentPeriod { get; set; }
        /// <summary>
        /// >> min_approval
        /// </summary>
        public Polkadot.NetApi.Generated.Model.pallet_referenda.types.EnumCurve MinApproval { get; set; }
        /// <summary>
        /// >> min_support
        /// </summary>
        public Polkadot.NetApi.Generated.Model.pallet_referenda.types.EnumCurve MinSupport { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "TrackInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Name.Encode());
            result.AddRange(MaxDeciding.Encode());
            result.AddRange(DecisionDeposit.Encode());
            result.AddRange(PreparePeriod.Encode());
            result.AddRange(DecisionPeriod.Encode());
            result.AddRange(ConfirmPeriod.Encode());
            result.AddRange(MinEnactmentPeriod.Encode());
            result.AddRange(MinApproval.Encode());
            result.AddRange(MinSupport.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Name = new Substrate.NetApi.Model.Types.Primitive.Str();
            Name.Decode(byteArray, ref p);
            MaxDeciding = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxDeciding.Decode(byteArray, ref p);
            DecisionDeposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            DecisionDeposit.Decode(byteArray, ref p);
            PreparePeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            PreparePeriod.Decode(byteArray, ref p);
            DecisionPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            DecisionPeriod.Decode(byteArray, ref p);
            ConfirmPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            ConfirmPeriod.Decode(byteArray, ref p);
            MinEnactmentPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            MinEnactmentPeriod.Decode(byteArray, ref p);
            MinApproval = new Polkadot.NetApi.Generated.Model.pallet_referenda.types.EnumCurve();
            MinApproval.Decode(byteArray, ref p);
            MinSupport = new Polkadot.NetApi.Generated.Model.pallet_referenda.types.EnumCurve();
            MinSupport.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
