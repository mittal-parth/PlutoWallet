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


namespace Hydration.NetApi.Generated.Model.pallet_liquidity_mining.types
{
    
    
    /// <summary>
    /// >> 92 - Composite[pallet_liquidity_mining.types.LoyaltyCurve]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class LoyaltyCurve : BaseType
    {
        
        /// <summary>
        /// >> initial_reward_percentage
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 InitialRewardPercentage { get; set; }
        /// <summary>
        /// >> scale_coef
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ScaleCoef { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "LoyaltyCurve";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(InitialRewardPercentage.Encode());
            result.AddRange(ScaleCoef.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            InitialRewardPercentage = new Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            InitialRewardPercentage.Decode(byteArray, ref p);
            ScaleCoef = new Substrate.NetApi.Model.Types.Primitive.U32();
            ScaleCoef.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
