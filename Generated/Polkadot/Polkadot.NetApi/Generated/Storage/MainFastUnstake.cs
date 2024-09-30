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


namespace Polkadot.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> FastUnstakeStorage
    /// </summary>
    public sealed class FastUnstakeStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> FastUnstakeStorage Constructor
        /// </summary>
        public FastUnstakeStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FastUnstake", "Head"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Polkadot.NetApi.Generated.Model.pallet_fast_unstake.types.UnstakeRequest)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FastUnstake", "Queue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FastUnstake", "CounterForQueue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FastUnstake", "ErasToCheckPerBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> HeadParams
        ///  The current "head of the queue" being unstaked.
        /// 
        ///  The head in itself can be a batch of up to [`Config::BatchSize`] stakers.
        /// </summary>
        public static string HeadParams()
        {
            return RequestGenerator.GetStorage("FastUnstake", "Head", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> HeadDefault
        /// Default value as hex string
        /// </summary>
        public static string HeadDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Head
        ///  The current "head of the queue" being unstaked.
        /// 
        ///  The head in itself can be a batch of up to [`Config::BatchSize`] stakers.
        /// </summary>
        public async Task<Polkadot.NetApi.Generated.Model.pallet_fast_unstake.types.UnstakeRequest> Head(string blockhash, CancellationToken token)
        {
            string parameters = FastUnstakeStorage.HeadParams();
            var result = await _client.GetStorageAsync<Polkadot.NetApi.Generated.Model.pallet_fast_unstake.types.UnstakeRequest>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> QueueParams
        ///  The map of all accounts wishing to be unstaked.
        /// 
        ///  Keeps track of `AccountId` wishing to unstake and it's corresponding deposit.
        /// </summary>
        public static string QueueParams(Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("FastUnstake", "Queue", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> QueueDefault
        /// Default value as hex string
        /// </summary>
        public static string QueueDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Queue
        ///  The map of all accounts wishing to be unstaked.
        /// 
        ///  Keeps track of `AccountId` wishing to unstake and it's corresponding deposit.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> Queue(Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = FastUnstakeStorage.QueueParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CounterForQueueParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForQueueParams()
        {
            return RequestGenerator.GetStorage("FastUnstake", "CounterForQueue", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForQueueDefault
        /// Default value as hex string
        /// </summary>
        public static string CounterForQueueDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> CounterForQueue
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> CounterForQueue(string blockhash, CancellationToken token)
        {
            string parameters = FastUnstakeStorage.CounterForQueueParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ErasToCheckPerBlockParams
        ///  Number of eras to check per block.
        /// 
        ///  If set to 0, this pallet does absolutely nothing. Cannot be set to more than
        ///  [`Config::MaxErasToCheckPerBlock`].
        /// 
        ///  Based on the amount of weight available at [`Pallet::on_idle`], up to this many eras are
        ///  checked. The checking is represented by updating [`UnstakeRequest::checked`], which is
        ///  stored in [`Head`].
        /// </summary>
        public static string ErasToCheckPerBlockParams()
        {
            return RequestGenerator.GetStorage("FastUnstake", "ErasToCheckPerBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ErasToCheckPerBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string ErasToCheckPerBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> ErasToCheckPerBlock
        ///  Number of eras to check per block.
        /// 
        ///  If set to 0, this pallet does absolutely nothing. Cannot be set to more than
        ///  [`Config::MaxErasToCheckPerBlock`].
        /// 
        ///  Based on the amount of weight available at [`Pallet::on_idle`], up to this many eras are
        ///  checked. The checking is represented by updating [`UnstakeRequest::checked`], which is
        ///  stored in [`Head`].
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> ErasToCheckPerBlock(string blockhash, CancellationToken token)
        {
            string parameters = FastUnstakeStorage.ErasToCheckPerBlockParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> FastUnstakeCalls
    /// </summary>
    public sealed class FastUnstakeCalls
    {
        
        /// <summary>
        /// >> register_fast_unstake
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RegisterFastUnstake()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(40, "FastUnstake", 0, "register_fast_unstake", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> deregister
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Deregister()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(40, "FastUnstake", 1, "deregister", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> control
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Control(Substrate.NetApi.Model.Types.Primitive.U32 eras_to_check)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(eras_to_check.Encode());
            return new Method(40, "FastUnstake", 2, "control", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> FastUnstakeConstants
    /// </summary>
    public sealed class FastUnstakeConstants
    {
        
        /// <summary>
        /// >> Deposit
        ///  Deposit to take for unstaking, to make sure we're able to slash the it in order to cover
        ///  the costs of resources on unsuccessful unstake.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00E40B54020000000000000000000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> FastUnstakeErrors
    /// </summary>
    public enum FastUnstakeErrors
    {
        
        /// <summary>
        /// >> NotController
        /// The provided Controller account was not found.
        /// 
        /// This means that the given account is not bonded.
        /// </summary>
        NotController,
        
        /// <summary>
        /// >> AlreadyQueued
        /// The bonded account has already been queued.
        /// </summary>
        AlreadyQueued,
        
        /// <summary>
        /// >> NotFullyBonded
        /// The bonded account has active unlocking chunks.
        /// </summary>
        NotFullyBonded,
        
        /// <summary>
        /// >> NotQueued
        /// The provided un-staker is not in the `Queue`.
        /// </summary>
        NotQueued,
        
        /// <summary>
        /// >> AlreadyHead
        /// The provided un-staker is already in Head, and cannot deregister.
        /// </summary>
        AlreadyHead,
        
        /// <summary>
        /// >> CallNotAllowed
        /// The call is not allowed at this point because the pallet is not active.
        /// </summary>
        CallNotAllowed,
    }
}
