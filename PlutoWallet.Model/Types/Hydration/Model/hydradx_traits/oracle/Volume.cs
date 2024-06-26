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


namespace Hydration.NetApi.Generated.Model.hydradx_traits.oracle
{
    
    
    /// <summary>
    /// >> 697 - Composite[hydradx_traits.oracle.Volume]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Volume : BaseType
    {
        
        /// <summary>
        /// >> a_in
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 AIn { get; set; }
        /// <summary>
        /// >> b_out
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 BOut { get; set; }
        /// <summary>
        /// >> a_out
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 AOut { get; set; }
        /// <summary>
        /// >> b_in
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 BIn { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Volume";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AIn.Encode());
            result.AddRange(BOut.Encode());
            result.AddRange(AOut.Encode());
            result.AddRange(BIn.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AIn = new Substrate.NetApi.Model.Types.Primitive.U128();
            AIn.Decode(byteArray, ref p);
            BOut = new Substrate.NetApi.Model.Types.Primitive.U128();
            BOut.Decode(byteArray, ref p);
            AOut = new Substrate.NetApi.Model.Types.Primitive.U128();
            AOut.Decode(byteArray, ref p);
            BIn = new Substrate.NetApi.Model.Types.Primitive.U128();
            BIn.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
