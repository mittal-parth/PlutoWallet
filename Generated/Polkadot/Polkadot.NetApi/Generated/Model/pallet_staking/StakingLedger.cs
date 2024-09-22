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


namespace Polkadot.NetApi.Generated.Model.pallet_staking
{
    
    
    /// <summary>
    /// >> 592 - Composite[pallet_staking.StakingLedger]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class StakingLedger : BaseType
    {
        
        /// <summary>
        /// >> stash
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32 Stash { get; set; }
        /// <summary>
        /// >> total
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> Total { get; set; }
        /// <summary>
        /// >> active
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> Active { get; set; }
        /// <summary>
        /// >> unlocking
        /// </summary>
        public Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 Unlocking { get; set; }
        /// <summary>
        /// >> legacy_claimed_rewards
        /// </summary>
        public Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21 LegacyClaimedRewards { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "StakingLedger";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Stash.Encode());
            result.AddRange(Total.Encode());
            result.AddRange(Active.Encode());
            result.AddRange(Unlocking.Encode());
            result.AddRange(LegacyClaimedRewards.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Stash = new Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Stash.Decode(byteArray, ref p);
            Total = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            Total.Decode(byteArray, ref p);
            Active = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            Active.Decode(byteArray, ref p);
            Unlocking = new Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2();
            Unlocking.Decode(byteArray, ref p);
            LegacyClaimedRewards = new Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21();
            LegacyClaimedRewards.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
