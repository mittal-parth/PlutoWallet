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


namespace Hydration.NetApi.Generated.Model.pallet_asset_registry.types
{
    
    
    /// <summary>
    /// >> 557 - Composite[pallet_asset_registry.types.AssetDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AssetDetails : BaseType
    {
        
        /// <summary>
        /// >> name
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5> Name { get; set; }
        /// <summary>
        /// >> asset_type
        /// </summary>
        public Hydration.NetApi.Generated.Model.pallet_asset_registry.types.EnumAssetType AssetType { get; set; }
        /// <summary>
        /// >> existential_deposit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 ExistentialDeposit { get; set; }
        /// <summary>
        /// >> symbol
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5> Symbol { get; set; }
        /// <summary>
        /// >> decimals
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8> Decimals { get; set; }
        /// <summary>
        /// >> xcm_rate_limit
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> XcmRateLimit { get; set; }
        /// <summary>
        /// >> is_sufficient
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool IsSufficient { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AssetDetails";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Name.Encode());
            result.AddRange(AssetType.Encode());
            result.AddRange(ExistentialDeposit.Encode());
            result.AddRange(Symbol.Encode());
            result.AddRange(Decimals.Encode());
            result.AddRange(XcmRateLimit.Encode());
            result.AddRange(IsSufficient.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Name = new Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5>();
            Name.Decode(byteArray, ref p);
            AssetType = new Hydration.NetApi.Generated.Model.pallet_asset_registry.types.EnumAssetType();
            AssetType.Decode(byteArray, ref p);
            ExistentialDeposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            ExistentialDeposit.Decode(byteArray, ref p);
            Symbol = new Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5>();
            Symbol.Decode(byteArray, ref p);
            Decimals = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8>();
            Decimals.Decode(byteArray, ref p);
            XcmRateLimit = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>();
            XcmRateLimit.Decode(byteArray, ref p);
            IsSufficient = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IsSufficient.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
