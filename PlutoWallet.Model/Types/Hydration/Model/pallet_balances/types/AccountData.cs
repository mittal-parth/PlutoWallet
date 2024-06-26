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
    /// >> 5 - Composite[pallet_balances.types.AccountData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AccountData : BaseType
    {
        
        /// <summary>
        /// >> free
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Free { get; set; }
        /// <summary>
        /// >> reserved
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Reserved { get; set; }
        /// <summary>
        /// >> frozen
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Frozen { get; set; }
        /// <summary>
        /// >> flags
        /// </summary>
        public Hydration.NetApi.Generated.Model.pallet_balances.types.ExtraFlags Flags { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AccountData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Free.Encode());
            result.AddRange(Reserved.Encode());
            result.AddRange(Frozen.Encode());
            result.AddRange(Flags.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Free = new Substrate.NetApi.Model.Types.Primitive.U128();
            Free.Decode(byteArray, ref p);
            Reserved = new Substrate.NetApi.Model.Types.Primitive.U128();
            Reserved.Decode(byteArray, ref p);
            Frozen = new Substrate.NetApi.Model.Types.Primitive.U128();
            Frozen.Decode(byteArray, ref p);
            Flags = new Hydration.NetApi.Generated.Model.pallet_balances.types.ExtraFlags();
            Flags.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
