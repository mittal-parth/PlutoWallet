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


namespace Opal.NetApi.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 310 - Composite[up_data_structs.CreateNftExData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CreateNftExData : BaseType
    {
        
        /// <summary>
        /// >> properties
        /// </summary>
        public Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13 Properties { get; set; }
        /// <summary>
        /// >> owner
        /// </summary>
        public Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr Owner { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CreateNftExData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Properties.Encode());
            result.AddRange(Owner.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Properties = new Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13();
            Properties.Decode(byteArray, ref p);
            Owner = new Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr();
            Owner.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
