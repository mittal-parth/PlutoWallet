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


namespace Bifrost.NetApi.Generated.Model.bifrost_slp.primitives
{
    
    
    /// <summary>
    /// >> 377 - Composite[bifrost_slp.primitives.MinimumsMaximums]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MinimumsMaximums : BaseType
    {
        
        /// <summary>
        /// >> delegator_bonded_minimum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> DelegatorBondedMinimum { get; set; }
        /// <summary>
        /// >> bond_extra_minimum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> BondExtraMinimum { get; set; }
        /// <summary>
        /// >> unbond_minimum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> UnbondMinimum { get; set; }
        /// <summary>
        /// >> rebond_minimum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> RebondMinimum { get; set; }
        /// <summary>
        /// >> unbond_record_maximum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> UnbondRecordMaximum { get; set; }
        /// <summary>
        /// >> validators_back_maximum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> ValidatorsBackMaximum { get; set; }
        /// <summary>
        /// >> delegator_active_staking_maximum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> DelegatorActiveStakingMaximum { get; set; }
        /// <summary>
        /// >> validators_reward_maximum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> ValidatorsRewardMaximum { get; set; }
        /// <summary>
        /// >> delegation_amount_minimum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> DelegationAmountMinimum { get; set; }
        /// <summary>
        /// >> delegators_maximum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U16> DelegatorsMaximum { get; set; }
        /// <summary>
        /// >> validators_maximum
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U16> ValidatorsMaximum { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MinimumsMaximums";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(DelegatorBondedMinimum.Encode());
            result.AddRange(BondExtraMinimum.Encode());
            result.AddRange(UnbondMinimum.Encode());
            result.AddRange(RebondMinimum.Encode());
            result.AddRange(UnbondRecordMaximum.Encode());
            result.AddRange(ValidatorsBackMaximum.Encode());
            result.AddRange(DelegatorActiveStakingMaximum.Encode());
            result.AddRange(ValidatorsRewardMaximum.Encode());
            result.AddRange(DelegationAmountMinimum.Encode());
            result.AddRange(DelegatorsMaximum.Encode());
            result.AddRange(ValidatorsMaximum.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            DelegatorBondedMinimum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            DelegatorBondedMinimum.Decode(byteArray, ref p);
            BondExtraMinimum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            BondExtraMinimum.Decode(byteArray, ref p);
            UnbondMinimum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            UnbondMinimum.Decode(byteArray, ref p);
            RebondMinimum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            RebondMinimum.Decode(byteArray, ref p);
            UnbondRecordMaximum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            UnbondRecordMaximum.Decode(byteArray, ref p);
            ValidatorsBackMaximum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            ValidatorsBackMaximum.Decode(byteArray, ref p);
            DelegatorActiveStakingMaximum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            DelegatorActiveStakingMaximum.Decode(byteArray, ref p);
            ValidatorsRewardMaximum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            ValidatorsRewardMaximum.Decode(byteArray, ref p);
            DelegationAmountMinimum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            DelegationAmountMinimum.Decode(byteArray, ref p);
            DelegatorsMaximum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U16>();
            DelegatorsMaximum.Decode(byteArray, ref p);
            ValidatorsMaximum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U16>();
            ValidatorsMaximum.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
