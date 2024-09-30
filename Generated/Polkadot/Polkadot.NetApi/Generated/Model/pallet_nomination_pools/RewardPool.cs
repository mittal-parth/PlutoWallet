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


namespace Polkadot.NetApi.Generated.Model.pallet_nomination_pools
{
    
    
    /// <summary>
    /// >> 730 - Composite[pallet_nomination_pools.RewardPool]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RewardPool : BaseType
    {
        
        /// <summary>
        /// >> last_recorded_reward_counter
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 LastRecordedRewardCounter { get; set; }
        /// <summary>
        /// >> last_recorded_total_payouts
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 LastRecordedTotalPayouts { get; set; }
        /// <summary>
        /// >> total_rewards_claimed
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TotalRewardsClaimed { get; set; }
        /// <summary>
        /// >> total_commission_pending
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TotalCommissionPending { get; set; }
        /// <summary>
        /// >> total_commission_claimed
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TotalCommissionClaimed { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "RewardPool";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(LastRecordedRewardCounter.Encode());
            result.AddRange(LastRecordedTotalPayouts.Encode());
            result.AddRange(TotalRewardsClaimed.Encode());
            result.AddRange(TotalCommissionPending.Encode());
            result.AddRange(TotalCommissionClaimed.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            LastRecordedRewardCounter = new Polkadot.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            LastRecordedRewardCounter.Decode(byteArray, ref p);
            LastRecordedTotalPayouts = new Substrate.NetApi.Model.Types.Primitive.U128();
            LastRecordedTotalPayouts.Decode(byteArray, ref p);
            TotalRewardsClaimed = new Substrate.NetApi.Model.Types.Primitive.U128();
            TotalRewardsClaimed.Decode(byteArray, ref p);
            TotalCommissionPending = new Substrate.NetApi.Model.Types.Primitive.U128();
            TotalCommissionPending.Decode(byteArray, ref p);
            TotalCommissionClaimed = new Substrate.NetApi.Model.Types.Primitive.U128();
            TotalCommissionClaimed.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
