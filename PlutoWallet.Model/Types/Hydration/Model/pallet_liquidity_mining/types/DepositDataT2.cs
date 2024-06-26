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


namespace Hydration.NetApi.Generated.Model.pallet_liquidity_mining.types
{
    
    
    /// <summary>
    /// >> 585 - Composite[pallet_liquidity_mining.types.DepositDataT2]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DepositDataT2 : BaseType
    {
        
        /// <summary>
        /// >> shares
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Shares { get; set; }
        /// <summary>
        /// >> amm_pool_id
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32 AmmPoolId { get; set; }
        /// <summary>
        /// >> yield_farm_entries
        /// </summary>
        public Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36 YieldFarmEntries { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "DepositDataT2";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Shares.Encode());
            result.AddRange(AmmPoolId.Encode());
            result.AddRange(YieldFarmEntries.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Shares = new Substrate.NetApi.Model.Types.Primitive.U128();
            Shares.Decode(byteArray, ref p);
            AmmPoolId = new Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            AmmPoolId.Decode(byteArray, ref p);
            YieldFarmEntries = new Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36();
            YieldFarmEntries.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
