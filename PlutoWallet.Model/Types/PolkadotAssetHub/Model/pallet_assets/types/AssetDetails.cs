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


namespace PolkadotAssetHub.NetApi.Generated.Model.pallet_assets.types
{
    
    
    /// <summary>
    /// >> 400 - Composite[pallet_assets.types.AssetDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AssetDetails : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32 Owner { get; set; }
        /// <summary>
        /// >> issuer
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32 Issuer { get; set; }
        /// <summary>
        /// >> admin
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32 Admin { get; set; }
        /// <summary>
        /// >> freezer
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32 Freezer { get; set; }
        /// <summary>
        /// >> supply
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Supply { get; set; }
        /// <summary>
        /// >> deposit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit { get; set; }
        /// <summary>
        /// >> min_balance
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MinBalance { get; set; }
        /// <summary>
        /// >> is_sufficient
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool IsSufficient { get; set; }
        /// <summary>
        /// >> accounts
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Accounts { get; set; }
        /// <summary>
        /// >> sufficients
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Sufficients { get; set; }
        /// <summary>
        /// >> approvals
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Approvals { get; set; }
        /// <summary>
        /// >> status
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.pallet_assets.types.EnumAssetStatus Status { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AssetDetails";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Issuer.Encode());
            result.AddRange(Admin.Encode());
            result.AddRange(Freezer.Encode());
            result.AddRange(Supply.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(MinBalance.Encode());
            result.AddRange(IsSufficient.Encode());
            result.AddRange(Accounts.Encode());
            result.AddRange(Sufficients.Encode());
            result.AddRange(Approvals.Encode());
            result.AddRange(Status.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            Issuer = new PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Issuer.Decode(byteArray, ref p);
            Admin = new PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Admin.Decode(byteArray, ref p);
            Freezer = new PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Freezer.Decode(byteArray, ref p);
            Supply = new Substrate.NetApi.Model.Types.Primitive.U128();
            Supply.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            MinBalance = new Substrate.NetApi.Model.Types.Primitive.U128();
            MinBalance.Decode(byteArray, ref p);
            IsSufficient = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IsSufficient.Decode(byteArray, ref p);
            Accounts = new Substrate.NetApi.Model.Types.Primitive.U32();
            Accounts.Decode(byteArray, ref p);
            Sufficients = new Substrate.NetApi.Model.Types.Primitive.U32();
            Sufficients.Decode(byteArray, ref p);
            Approvals = new Substrate.NetApi.Model.Types.Primitive.U32();
            Approvals.Decode(byteArray, ref p);
            Status = new PolkadotAssetHub.NetApi.Generated.Model.pallet_assets.types.EnumAssetStatus();
            Status.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
