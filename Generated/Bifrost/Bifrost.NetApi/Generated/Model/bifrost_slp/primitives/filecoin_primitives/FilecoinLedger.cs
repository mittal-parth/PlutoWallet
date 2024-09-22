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


namespace Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.filecoin_primitives
{
    
    
    /// <summary>
    /// >> 372 - Composite[bifrost_slp.primitives.filecoin_primitives.FilecoinLedger]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class FilecoinLedger : BaseType
    {
        
        /// <summary>
        /// >> account
        /// </summary>
        public Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation Account { get; set; }
        /// <summary>
        /// >> initial_pledge
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> InitialPledge { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "FilecoinLedger";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Account.Encode());
            result.AddRange(InitialPledge.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Account = new Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation();
            Account.Decode(byteArray, ref p);
            InitialPledge = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            InitialPledge.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
