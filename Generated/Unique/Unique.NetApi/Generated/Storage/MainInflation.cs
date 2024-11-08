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


namespace Unique.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> InflationStorage
    /// </summary>
    public sealed class InflationStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> InflationStorage Constructor
        /// </summary>
        public InflationStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Inflation", "StartingYearTotalIssuance"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Inflation", "BlockInflation"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Inflation", "NextInflationBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Inflation", "NextRecalculationBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Inflation", "StartBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> StartingYearTotalIssuanceParams
        ///  starting year total issuance
        /// </summary>
        public static string StartingYearTotalIssuanceParams()
        {
            return RequestGenerator.GetStorage("Inflation", "StartingYearTotalIssuance", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> StartingYearTotalIssuanceDefault
        /// Default value as hex string
        /// </summary>
        public static string StartingYearTotalIssuanceDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> StartingYearTotalIssuance
        ///  starting year total issuance
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> StartingYearTotalIssuance(string blockhash, CancellationToken token)
        {
            string parameters = InflationStorage.StartingYearTotalIssuanceParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> BlockInflationParams
        ///  Current inflation for `InflationBlockInterval` number of blocks
        /// </summary>
        public static string BlockInflationParams()
        {
            return RequestGenerator.GetStorage("Inflation", "BlockInflation", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> BlockInflationDefault
        /// Default value as hex string
        /// </summary>
        public static string BlockInflationDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> BlockInflation
        ///  Current inflation for `InflationBlockInterval` number of blocks
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> BlockInflation(string blockhash, CancellationToken token)
        {
            string parameters = InflationStorage.BlockInflationParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> NextInflationBlockParams
        ///  Next target (relay) block when inflation will be applied
        /// </summary>
        public static string NextInflationBlockParams()
        {
            return RequestGenerator.GetStorage("Inflation", "NextInflationBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextInflationBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string NextInflationBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> NextInflationBlock
        ///  Next target (relay) block when inflation will be applied
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> NextInflationBlock(string blockhash, CancellationToken token)
        {
            string parameters = InflationStorage.NextInflationBlockParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> NextRecalculationBlockParams
        ///  Next target (relay) block when inflation is recalculated
        /// </summary>
        public static string NextRecalculationBlockParams()
        {
            return RequestGenerator.GetStorage("Inflation", "NextRecalculationBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextRecalculationBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string NextRecalculationBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> NextRecalculationBlock
        ///  Next target (relay) block when inflation is recalculated
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> NextRecalculationBlock(string blockhash, CancellationToken token)
        {
            string parameters = InflationStorage.NextRecalculationBlockParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> StartBlockParams
        ///  Relay block when inflation has started
        /// </summary>
        public static string StartBlockParams()
        {
            return RequestGenerator.GetStorage("Inflation", "StartBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> StartBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string StartBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> StartBlock
        ///  Relay block when inflation has started
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> StartBlock(string blockhash, CancellationToken token)
        {
            string parameters = InflationStorage.StartBlockParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> InflationCalls
    /// </summary>
    public sealed class InflationCalls
    {
        
        /// <summary>
        /// >> start_inflation
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method StartInflation(Substrate.NetApi.Model.Types.Primitive.U32 inflation_start_relay_block)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(inflation_start_relay_block.Encode());
            return new Method(60, "Inflation", 0, "start_inflation", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> InflationConstants
    /// </summary>
    public sealed class InflationConstants
    {
        
        /// <summary>
        /// >> InflationBlockInterval
        ///  Number of blocks that pass between treasury balance updates due to inflation
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 InflationBlockInterval()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
    }
}
