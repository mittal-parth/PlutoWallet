//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Hydration.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> UnknownTokensStorage
    /// </summary>
    public sealed class UnknownTokensStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> UnknownTokensStorage Constructor
        /// </summary>
        public UnknownTokensStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("UnknownTokens", "ConcreteFungibleBalances"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location, Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location>), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("UnknownTokens", "AbstractFungibleBalances"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
        }
        
        /// <summary>
        /// >> ConcreteFungibleBalancesParams
        ///  Concrete fungible balances under a given location and a concrete
        ///  fungible id.
        /// 
        ///  double_map: who, asset_id => u128
        /// </summary>
        public static string ConcreteFungibleBalancesParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location, Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location> key)
        {
            return RequestGenerator.GetStorage("UnknownTokens", "ConcreteFungibleBalances", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> ConcreteFungibleBalancesDefault
        /// Default value as hex string
        /// </summary>
        public static string ConcreteFungibleBalancesDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> ConcreteFungibleBalances
        ///  Concrete fungible balances under a given location and a concrete
        ///  fungible id.
        /// 
        ///  double_map: who, asset_id => u128
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> ConcreteFungibleBalances(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location, Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location> key, string blockhash, CancellationToken token)
        {
            string parameters = UnknownTokensStorage.ConcreteFungibleBalancesParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AbstractFungibleBalancesParams
        ///  Abstract fungible balances under a given location and a abstract
        ///  fungible id.
        /// 
        ///  double_map: who, asset_id => u128
        /// </summary>
        public static string AbstractFungibleBalancesParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> key)
        {
            return RequestGenerator.GetStorage("UnknownTokens", "AbstractFungibleBalances", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> AbstractFungibleBalancesDefault
        /// Default value as hex string
        /// </summary>
        public static string AbstractFungibleBalancesDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> AbstractFungibleBalances
        ///  Abstract fungible balances under a given location and a abstract
        ///  fungible id.
        /// 
        ///  double_map: who, asset_id => u128
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> AbstractFungibleBalances(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> key, string blockhash, CancellationToken token)
        {
            string parameters = UnknownTokensStorage.AbstractFungibleBalancesParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> UnknownTokensCalls
    /// </summary>
    public sealed class UnknownTokensCalls
    {
    }
    
    /// <summary>
    /// >> UnknownTokensConstants
    /// </summary>
    public sealed class UnknownTokensConstants
    {
    }
    
    /// <summary>
    /// >> UnknownTokensErrors
    /// </summary>
    public enum UnknownTokensErrors
    {
        
        /// <summary>
        /// >> BalanceTooLow
        /// The balance is too low.
        /// </summary>
        BalanceTooLow,
        
        /// <summary>
        /// >> BalanceOverflow
        /// The operation will cause balance to overflow.
        /// </summary>
        BalanceOverflow,
        
        /// <summary>
        /// >> UnhandledAsset
        /// Unhandled asset.
        /// </summary>
        UnhandledAsset,
    }
}
