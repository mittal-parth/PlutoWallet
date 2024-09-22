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


namespace Opal.NetApi.Generated.Model.pallet_configuration
{
    
    
    /// <summary>
    /// >> 322 - Composite[pallet_configuration.AppPromotionConfiguration]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AppPromotionConfiguration : BaseType
    {
        
        /// <summary>
        /// >> recalculation_interval
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> RecalculationInterval { get; set; }
        /// <summary>
        /// >> pending_interval
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> PendingInterval { get; set; }
        /// <summary>
        /// >> interval_income
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill> IntervalIncome { get; set; }
        /// <summary>
        /// >> max_stakers_per_calculation
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8> MaxStakersPerCalculation { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AppPromotionConfiguration";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(RecalculationInterval.Encode());
            result.AddRange(PendingInterval.Encode());
            result.AddRange(IntervalIncome.Encode());
            result.AddRange(MaxStakersPerCalculation.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            RecalculationInterval = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            RecalculationInterval.Decode(byteArray, ref p);
            PendingInterval = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            PendingInterval.Decode(byteArray, ref p);
            IntervalIncome = new Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill>();
            IntervalIncome.Decode(byteArray, ref p);
            MaxStakersPerCalculation = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8>();
            MaxStakersPerCalculation.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
