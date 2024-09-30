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


namespace Opal.NetApi.Generated.Model.ethereum.transaction
{
    
    
    /// <summary>
    /// >> 345 - Composite[ethereum.transaction.EIP2930Transaction]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class EIP2930Transaction : BaseType
    {
        
        /// <summary>
        /// >> chain_id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 ChainId { get; set; }
        /// <summary>
        /// >> nonce
        /// </summary>
        public Opal.NetApi.Generated.Model.primitive_types.U256 Nonce { get; set; }
        /// <summary>
        /// >> gas_price
        /// </summary>
        public Opal.NetApi.Generated.Model.primitive_types.U256 GasPrice { get; set; }
        /// <summary>
        /// >> gas_limit
        /// </summary>
        public Opal.NetApi.Generated.Model.primitive_types.U256 GasLimit { get; set; }
        /// <summary>
        /// >> action
        /// </summary>
        public Opal.NetApi.Generated.Model.ethereum.transaction.EnumTransactionAction Action { get; set; }
        /// <summary>
        /// >> value
        /// </summary>
        public Opal.NetApi.Generated.Model.primitive_types.U256 Value { get; set; }
        /// <summary>
        /// >> input
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Input { get; set; }
        /// <summary>
        /// >> access_list
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.ethereum.transaction.AccessListItem> AccessList { get; set; }
        /// <summary>
        /// >> odd_y_parity
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool OddYParity { get; set; }
        /// <summary>
        /// >> r
        /// </summary>
        public Opal.NetApi.Generated.Model.primitive_types.H256 R { get; set; }
        /// <summary>
        /// >> s
        /// </summary>
        public Opal.NetApi.Generated.Model.primitive_types.H256 S { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "EIP2930Transaction";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ChainId.Encode());
            result.AddRange(Nonce.Encode());
            result.AddRange(GasPrice.Encode());
            result.AddRange(GasLimit.Encode());
            result.AddRange(Action.Encode());
            result.AddRange(Value.Encode());
            result.AddRange(Input.Encode());
            result.AddRange(AccessList.Encode());
            result.AddRange(OddYParity.Encode());
            result.AddRange(R.Encode());
            result.AddRange(S.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ChainId = new Substrate.NetApi.Model.Types.Primitive.U64();
            ChainId.Decode(byteArray, ref p);
            Nonce = new Opal.NetApi.Generated.Model.primitive_types.U256();
            Nonce.Decode(byteArray, ref p);
            GasPrice = new Opal.NetApi.Generated.Model.primitive_types.U256();
            GasPrice.Decode(byteArray, ref p);
            GasLimit = new Opal.NetApi.Generated.Model.primitive_types.U256();
            GasLimit.Decode(byteArray, ref p);
            Action = new Opal.NetApi.Generated.Model.ethereum.transaction.EnumTransactionAction();
            Action.Decode(byteArray, ref p);
            Value = new Opal.NetApi.Generated.Model.primitive_types.U256();
            Value.Decode(byteArray, ref p);
            Input = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Input.Decode(byteArray, ref p);
            AccessList = new Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.ethereum.transaction.AccessListItem>();
            AccessList.Decode(byteArray, ref p);
            OddYParity = new Substrate.NetApi.Model.Types.Primitive.Bool();
            OddYParity.Decode(byteArray, ref p);
            R = new Opal.NetApi.Generated.Model.primitive_types.H256();
            R.Decode(byteArray, ref p);
            S = new Opal.NetApi.Generated.Model.primitive_types.H256();
            S.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
