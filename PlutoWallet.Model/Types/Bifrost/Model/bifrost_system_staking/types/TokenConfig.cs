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


namespace Bifrost.NetApi.Generated.Model.bifrost_system_staking.types
{
    
    
    /// <summary>
    /// >> 779 - Composite[bifrost_system_staking.types.TokenConfig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class TokenConfig : BaseType
    {
        
        /// <summary>
        /// >> exec_delay
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ExecDelay { get; set; }
        /// <summary>
        /// >> system_stakable_farming_rate
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill SystemStakableFarmingRate { get; set; }
        /// <summary>
        /// >> lptoken_rates
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill> LptokenRates { get; set; }
        /// <summary>
        /// >> add_or_sub
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool AddOrSub { get; set; }
        /// <summary>
        /// >> system_stakable_base
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 SystemStakableBase { get; set; }
        /// <summary>
        /// >> farming_poolids
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32> FarmingPoolids { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "TokenConfig";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ExecDelay.Encode());
            result.AddRange(SystemStakableFarmingRate.Encode());
            result.AddRange(LptokenRates.Encode());
            result.AddRange(AddOrSub.Encode());
            result.AddRange(SystemStakableBase.Encode());
            result.AddRange(FarmingPoolids.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ExecDelay = new Substrate.NetApi.Model.Types.Primitive.U32();
            ExecDelay.Decode(byteArray, ref p);
            SystemStakableFarmingRate = new Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            SystemStakableFarmingRate.Decode(byteArray, ref p);
            LptokenRates = new Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill>();
            LptokenRates.Decode(byteArray, ref p);
            AddOrSub = new Substrate.NetApi.Model.Types.Primitive.Bool();
            AddOrSub.Decode(byteArray, ref p);
            SystemStakableBase = new Substrate.NetApi.Model.Types.Primitive.U128();
            SystemStakableBase.Decode(byteArray, ref p);
            FarmingPoolids = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>();
            FarmingPoolids.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
