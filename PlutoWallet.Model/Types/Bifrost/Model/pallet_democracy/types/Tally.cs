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


namespace Bifrost.NetApi.Generated.Model.pallet_democracy.types
{
    
    
    /// <summary>
    /// >> 544 - Composite[pallet_democracy.types.Tally]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Tally : BaseType
    {
        
        /// <summary>
        /// >> ayes
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Ayes { get; set; }
        /// <summary>
        /// >> nays
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Nays { get; set; }
        /// <summary>
        /// >> turnout
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Turnout { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Tally";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Ayes.Encode());
            result.AddRange(Nays.Encode());
            result.AddRange(Turnout.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Ayes = new Substrate.NetApi.Model.Types.Primitive.U128();
            Ayes.Decode(byteArray, ref p);
            Nays = new Substrate.NetApi.Model.Types.Primitive.U128();
            Nays.Decode(byteArray, ref p);
            Turnout = new Substrate.NetApi.Model.Types.Primitive.U128();
            Turnout.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
