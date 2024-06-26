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


namespace Bifrost.NetApi.Generated.Model.bifrost_slpx.types
{
    
    
    /// <summary>
    /// >> 448 - Composite[bifrost_slpx.types.Order]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Order : BaseType
    {
        
        /// <summary>
        /// >> source_chain_caller
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumOrderCaller SourceChainCaller { get; set; }
        /// <summary>
        /// >> bifrost_chain_caller
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32 BifrostChainCaller { get; set; }
        /// <summary>
        /// >> derivative_account
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32 DerivativeAccount { get; set; }
        /// <summary>
        /// >> create_block_number
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 CreateBlockNumber { get; set; }
        /// <summary>
        /// >> currency_id
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId CurrencyId { get; set; }
        /// <summary>
        /// >> currency_amount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 CurrencyAmount { get; set; }
        /// <summary>
        /// >> order_type
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumOrderType OrderType { get; set; }
        /// <summary>
        /// >> remark
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 Remark { get; set; }
        /// <summary>
        /// >> target_chain
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumTargetChain TargetChain { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Order";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SourceChainCaller.Encode());
            result.AddRange(BifrostChainCaller.Encode());
            result.AddRange(DerivativeAccount.Encode());
            result.AddRange(CreateBlockNumber.Encode());
            result.AddRange(CurrencyId.Encode());
            result.AddRange(CurrencyAmount.Encode());
            result.AddRange(OrderType.Encode());
            result.AddRange(Remark.Encode());
            result.AddRange(TargetChain.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SourceChainCaller = new Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumOrderCaller();
            SourceChainCaller.Decode(byteArray, ref p);
            BifrostChainCaller = new Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            BifrostChainCaller.Decode(byteArray, ref p);
            DerivativeAccount = new Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            DerivativeAccount.Decode(byteArray, ref p);
            CreateBlockNumber = new Substrate.NetApi.Model.Types.Primitive.U32();
            CreateBlockNumber.Decode(byteArray, ref p);
            CurrencyId = new Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId();
            CurrencyId.Decode(byteArray, ref p);
            CurrencyAmount = new Substrate.NetApi.Model.Types.Primitive.U128();
            CurrencyAmount.Decode(byteArray, ref p);
            OrderType = new Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumOrderType();
            OrderType.Decode(byteArray, ref p);
            Remark = new Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6();
            Remark.Decode(byteArray, ref p);
            TargetChain = new Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumTargetChain();
            TargetChain.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
