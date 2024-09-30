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


namespace Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.polkadot_primitives
{
    
    
    /// <summary>
    /// >> 358 - Composite[bifrost_slp.primitives.polkadot_primitives.SubstrateLedger]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SubstrateLedger : BaseType
    {
        
        /// <summary>
        /// >> account
        /// </summary>
        public Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation Account { get; set; }
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
        public Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.polkadot_primitives.UnlockChunk> Unlocking { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "SubstrateLedger";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Account.Encode());
            result.AddRange(Total.Encode());
            result.AddRange(Active.Encode());
            result.AddRange(Unlocking.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Account = new Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation();
            Account.Decode(byteArray, ref p);
            Total = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            Total.Decode(byteArray, ref p);
            Active = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            Active.Decode(byteArray, ref p);
            Unlocking = new Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.polkadot_primitives.UnlockChunk>();
            Unlocking.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
