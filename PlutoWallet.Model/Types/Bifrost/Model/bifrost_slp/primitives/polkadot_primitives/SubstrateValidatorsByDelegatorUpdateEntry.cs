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


namespace Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.polkadot_primitives
{
    
    
    /// <summary>
    /// >> 433 - Composite[bifrost_slp.primitives.polkadot_primitives.SubstrateValidatorsByDelegatorUpdateEntry]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SubstrateValidatorsByDelegatorUpdateEntry : BaseType
    {
        
        /// <summary>
        /// >> currency_id
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId CurrencyId { get; set; }
        /// <summary>
        /// >> delegator_id
        /// </summary>
        public Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation DelegatorId { get; set; }
        /// <summary>
        /// >> validators
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation> Validators { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "SubstrateValidatorsByDelegatorUpdateEntry";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(CurrencyId.Encode());
            result.AddRange(DelegatorId.Encode());
            result.AddRange(Validators.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            CurrencyId = new Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId();
            CurrencyId.Decode(byteArray, ref p);
            DelegatorId = new Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation();
            DelegatorId.Decode(byteArray, ref p);
            Validators = new Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>();
            Validators.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
