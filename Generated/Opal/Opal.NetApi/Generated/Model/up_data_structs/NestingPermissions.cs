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
    /// >> 284 - Composite[up_data_structs.NestingPermissions]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class NestingPermissions : BaseType
    {
        
        /// <summary>
        /// >> token_owner
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool TokenOwner { get; set; }
        /// <summary>
        /// >> collection_admin
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool CollectionAdmin { get; set; }
        /// <summary>
        /// >> restricted
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.up_data_structs.OwnerRestrictedSet> Restricted { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "NestingPermissions";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TokenOwner.Encode());
            result.AddRange(CollectionAdmin.Encode());
            result.AddRange(Restricted.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TokenOwner = new Substrate.NetApi.Model.Types.Primitive.Bool();
            TokenOwner.Decode(byteArray, ref p);
            CollectionAdmin = new Substrate.NetApi.Model.Types.Primitive.Bool();
            CollectionAdmin.Decode(byteArray, ref p);
            Restricted = new Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.up_data_structs.OwnerRestrictedSet>();
            Restricted.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
