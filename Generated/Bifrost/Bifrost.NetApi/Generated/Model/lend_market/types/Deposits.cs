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


namespace Bifrost.NetApi.Generated.Model.lend_market.types
{
    
    
    /// <summary>
    /// >> 881 - Composite[lend_market.types.Deposits]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Deposits : BaseType
    {
        
        /// <summary>
        /// >> voucher_balance
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 VoucherBalance { get; set; }
        /// <summary>
        /// >> is_collateral
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool IsCollateral { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Deposits";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(VoucherBalance.Encode());
            result.AddRange(IsCollateral.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            VoucherBalance = new Substrate.NetApi.Model.Types.Primitive.U128();
            VoucherBalance.Decode(byteArray, ref p);
            IsCollateral = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IsCollateral.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}