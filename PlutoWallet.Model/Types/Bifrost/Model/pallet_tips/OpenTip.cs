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


namespace Bifrost.NetApi.Generated.Model.pallet_tips
{
    
    
    /// <summary>
    /// >> 684 - Composite[pallet_tips.OpenTip]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class OpenTip : BaseType
    {
        
        /// <summary>
        /// >> reason
        /// </summary>
        public Bifrost.NetApi.Generated.Model.primitive_types.H256 Reason { get; set; }
        /// <summary>
        /// >> who
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32 Who { get; set; }
        /// <summary>
        /// >> finder
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32 Finder { get; set; }
        /// <summary>
        /// >> deposit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit { get; set; }
        /// <summary>
        /// >> closes
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> Closes { get; set; }
        /// <summary>
        /// >> tips
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>> Tips { get; set; }
        /// <summary>
        /// >> finders_fee
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool FindersFee { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "OpenTip";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Reason.Encode());
            result.AddRange(Who.Encode());
            result.AddRange(Finder.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Closes.Encode());
            result.AddRange(Tips.Encode());
            result.AddRange(FindersFee.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Reason = new Bifrost.NetApi.Generated.Model.primitive_types.H256();
            Reason.Decode(byteArray, ref p);
            Who = new Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Who.Decode(byteArray, ref p);
            Finder = new Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Finder.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Closes = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            Closes.Decode(byteArray, ref p);
            Tips = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>();
            Tips.Decode(byteArray, ref p);
            FindersFee = new Substrate.NetApi.Model.Types.Primitive.Bool();
            FindersFee.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
