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


namespace Bifrost.NetApi.Generated.Model.bifrost_system_maker.pallet
{
    
    
    /// <summary>
    /// >> 348 - Composite[bifrost_system_maker.pallet.Info]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Info : BaseType
    {
        
        /// <summary>
        /// >> vcurrency_id
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId VcurrencyId { get; set; }
        /// <summary>
        /// >> annualization
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Annualization { get; set; }
        /// <summary>
        /// >> granularity
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Granularity { get; set; }
        /// <summary>
        /// >> minimum_redeem
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MinimumRedeem { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Info";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(VcurrencyId.Encode());
            result.AddRange(Annualization.Encode());
            result.AddRange(Granularity.Encode());
            result.AddRange(MinimumRedeem.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            VcurrencyId = new Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId();
            VcurrencyId.Decode(byteArray, ref p);
            Annualization = new Substrate.NetApi.Model.Types.Primitive.U32();
            Annualization.Decode(byteArray, ref p);
            Granularity = new Substrate.NetApi.Model.Types.Primitive.U128();
            Granularity.Decode(byteArray, ref p);
            MinimumRedeem = new Substrate.NetApi.Model.Types.Primitive.U128();
            MinimumRedeem.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}