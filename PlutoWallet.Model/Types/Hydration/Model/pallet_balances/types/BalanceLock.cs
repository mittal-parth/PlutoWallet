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


namespace Hydration.NetApi.Generated.Model.pallet_balances.types
{
    
    
    /// <summary>
    /// >> 230 - Composite[pallet_balances.types.BalanceLock]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BalanceLock : BaseType
    {
        
        /// <summary>
        /// >> id
        /// </summary>
        public Hydration.NetApi.Generated.Types.Base.Arr8U8 Id { get; set; }
        /// <summary>
        /// >> amount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount { get; set; }
        /// <summary>
        /// >> reasons
        /// </summary>
        public Hydration.NetApi.Generated.Model.pallet_balances.types.EnumReasons Reasons { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BalanceLock";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(Amount.Encode());
            result.AddRange(Reasons.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new Hydration.NetApi.Generated.Types.Base.Arr8U8();
            Id.Decode(byteArray, ref p);
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Reasons = new Hydration.NetApi.Generated.Model.pallet_balances.types.EnumReasons();
            Reasons.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
