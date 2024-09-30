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


namespace Polkadot.NetApi.Generated.Model.polkadot_primitives.v6
{
    
    
    /// <summary>
    /// >> 346 - Composite[polkadot_primitives.v6.CandidateCommitments]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CandidateCommitments : BaseType
    {
        
        /// <summary>
        /// >> upward_messages
        /// </summary>
        public Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5 UpwardMessages { get; set; }
        /// <summary>
        /// >> horizontal_messages
        /// </summary>
        public Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 HorizontalMessages { get; set; }
        /// <summary>
        /// >> new_validation_code
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCode> NewValidationCode { get; set; }
        /// <summary>
        /// >> head_data
        /// </summary>
        public Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.HeadData HeadData { get; set; }
        /// <summary>
        /// >> processed_downward_messages
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ProcessedDownwardMessages { get; set; }
        /// <summary>
        /// >> hrmp_watermark
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpWatermark { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CandidateCommitments";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UpwardMessages.Encode());
            result.AddRange(HorizontalMessages.Encode());
            result.AddRange(NewValidationCode.Encode());
            result.AddRange(HeadData.Encode());
            result.AddRange(ProcessedDownwardMessages.Encode());
            result.AddRange(HrmpWatermark.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UpwardMessages = new Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5();
            UpwardMessages.Decode(byteArray, ref p);
            HorizontalMessages = new Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6();
            HorizontalMessages.Decode(byteArray, ref p);
            NewValidationCode = new Substrate.NetApi.Model.Types.Base.BaseOpt<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCode>();
            NewValidationCode.Decode(byteArray, ref p);
            HeadData = new Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.HeadData();
            HeadData.Decode(byteArray, ref p);
            ProcessedDownwardMessages = new Substrate.NetApi.Model.Types.Primitive.U32();
            ProcessedDownwardMessages.Decode(byteArray, ref p);
            HrmpWatermark = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpWatermark.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
