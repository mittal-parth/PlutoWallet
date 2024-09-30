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


namespace Polkadot.NetApi.Generated.Model.pallet_identity.types
{
    
    
    /// <summary>
    /// >> 682 - Composite[pallet_identity.types.RegistrarInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RegistrarInfo : BaseType
    {
        
        /// <summary>
        /// >> account
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32 Account { get; set; }
        /// <summary>
        /// >> fee
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Fee { get; set; }
        /// <summary>
        /// >> fields
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 Fields { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "RegistrarInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Account.Encode());
            result.AddRange(Fee.Encode());
            result.AddRange(Fields.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Account = new Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Account.Decode(byteArray, ref p);
            Fee = new Substrate.NetApi.Model.Types.Primitive.U128();
            Fee.Decode(byteArray, ref p);
            Fields = new Substrate.NetApi.Model.Types.Primitive.U64();
            Fields.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
