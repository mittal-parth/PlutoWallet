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


namespace Hydration.NetApi.Generated.Model.pallet_dynamic_fees.types
{
    
    
    /// <summary>
    /// >> 521 - Composite[pallet_dynamic_fees.types.FeeParams]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class FeeParams : BaseType
    {
        
        /// <summary>
        /// >> min_fee
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill MinFee { get; set; }
        /// <summary>
        /// >> max_fee
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill MaxFee { get; set; }
        /// <summary>
        /// >> decay
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 Decay { get; set; }
        /// <summary>
        /// >> amplification
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 Amplification { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "FeeParams";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MinFee.Encode());
            result.AddRange(MaxFee.Encode());
            result.AddRange(Decay.Encode());
            result.AddRange(Amplification.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MinFee = new Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            MinFee.Decode(byteArray, ref p);
            MaxFee = new Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            MaxFee.Decode(byteArray, ref p);
            Decay = new Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            Decay.Decode(byteArray, ref p);
            Amplification = new Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            Amplification.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
