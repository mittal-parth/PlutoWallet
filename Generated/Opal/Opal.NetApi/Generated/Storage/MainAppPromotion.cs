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


namespace Opal.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> AppPromotionStorage
    /// </summary>
    public sealed class AppPromotionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AppPromotionStorage Constructor
        /// </summary>
        public AppPromotionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AppPromotion", "TotalStaked"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AppPromotion", "Admin"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AppPromotion", "Staked"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AppPromotion", "StakesPerAccount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Primitive.U8)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AppPromotion", "PendingUnstake"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AppPromotion", "PreviousCalculatedRecord"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>)));
        }
        
        /// <summary>
        /// >> TotalStakedParams
        ///  Stores the total staked amount.
        /// </summary>
        public static string TotalStakedParams()
        {
            return RequestGenerator.GetStorage("AppPromotion", "TotalStaked", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> TotalStakedDefault
        /// Default value as hex string
        /// </summary>
        public static string TotalStakedDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> TotalStaked
        ///  Stores the total staked amount.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> TotalStaked(string blockhash, CancellationToken token)
        {
            string parameters = AppPromotionStorage.TotalStakedParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AdminParams
        ///  Stores the `admin` account. Some extrinsics can only be executed if they were signed by `admin`.
        /// </summary>
        public static string AdminParams()
        {
            return RequestGenerator.GetStorage("AppPromotion", "Admin", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AdminDefault
        /// Default value as hex string
        /// </summary>
        public static string AdminDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Admin
        ///  Stores the `admin` account. Some extrinsics can only be executed if they were signed by `admin`.
        /// </summary>
        public async Task<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32> Admin(string blockhash, CancellationToken token)
        {
            string parameters = AppPromotionStorage.AdminParams();
            var result = await _client.GetStorageAsync<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> StakedParams
        ///  Stores the amount of tokens staked by account in the blocknumber.
        /// 
        ///  * **Key1** - Staker account.
        ///  * **Key2** - Relay block number when the stake was made.
        ///  * **(Balance, BlockNumber)** - Balance of the stake.
        ///  The number of the relay block in which we must perform the interest recalculation
        /// </summary>
        public static string StakedParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("AppPromotion", "Staked", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> StakedDefault
        /// Default value as hex string
        /// </summary>
        public static string StakedDefault()
        {
            return "0x0000000000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> Staked
        ///  Stores the amount of tokens staked by account in the blocknumber.
        /// 
        ///  * **Key1** - Staker account.
        ///  * **Key2** - Relay block number when the stake was made.
        ///  * **(Balance, BlockNumber)** - Balance of the stake.
        ///  The number of the relay block in which we must perform the interest recalculation
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>> Staked(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = AppPromotionStorage.StakedParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> StakesPerAccountParams
        ///  Stores number of stake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        public static string StakesPerAccountParams(Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("AppPromotion", "StakesPerAccount", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> StakesPerAccountDefault
        /// Default value as hex string
        /// </summary>
        public static string StakesPerAccountDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> StakesPerAccount
        ///  Stores number of stake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U8> StakesPerAccount(Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = AppPromotionStorage.StakesPerAccountParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U8>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PendingUnstakeParams
        ///  Pending unstake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        public static string PendingUnstakeParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("AppPromotion", "PendingUnstake", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PendingUnstakeDefault
        /// Default value as hex string
        /// </summary>
        public static string PendingUnstakeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PendingUnstake
        ///  Pending unstake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        public async Task<Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42> PendingUnstake(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = AppPromotionStorage.PendingUnstakeParams(key);
            var result = await _client.GetStorageAsync<Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PreviousCalculatedRecordParams
        ///  Stores a key for record for which the revenue recalculation was performed.
        ///  If `None`, then recalculation has not yet been performed or calculations have been completed for all stakers.
        /// </summary>
        public static string PreviousCalculatedRecordParams()
        {
            return RequestGenerator.GetStorage("AppPromotion", "PreviousCalculatedRecord", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PreviousCalculatedRecordDefault
        /// Default value as hex string
        /// </summary>
        public static string PreviousCalculatedRecordDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PreviousCalculatedRecord
        ///  Stores a key for record for which the revenue recalculation was performed.
        ///  If `None`, then recalculation has not yet been performed or calculations have been completed for all stakers.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>> PreviousCalculatedRecord(string blockhash, CancellationToken token)
        {
            string parameters = AppPromotionStorage.PreviousCalculatedRecordParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> AppPromotionCalls
    /// </summary>
    public sealed class AppPromotionCalls
    {
        
        /// <summary>
        /// >> set_admin_address
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetAdminAddress(Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr admin)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(admin.Encode());
            return new Method(73, "AppPromotion", 0, "set_admin_address", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> stake
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Stake(Substrate.NetApi.Model.Types.Primitive.U128 amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            return new Method(73, "AppPromotion", 1, "stake", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unstake_all
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UnstakeAll()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(73, "AppPromotion", 2, "unstake_all", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unstake_partial
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UnstakePartial(Substrate.NetApi.Model.Types.Primitive.U128 amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            return new Method(73, "AppPromotion", 8, "unstake_partial", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sponsor_collection
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SponsorCollection(Opal.NetApi.Generated.Model.up_data_structs.CollectionId collection_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(collection_id.Encode());
            return new Method(73, "AppPromotion", 3, "sponsor_collection", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> stop_sponsoring_collection
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method StopSponsoringCollection(Opal.NetApi.Generated.Model.up_data_structs.CollectionId collection_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(collection_id.Encode());
            return new Method(73, "AppPromotion", 4, "stop_sponsoring_collection", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sponsor_contract
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SponsorContract(Opal.NetApi.Generated.Model.primitive_types.H160 contract_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(contract_id.Encode());
            return new Method(73, "AppPromotion", 5, "sponsor_contract", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> stop_sponsoring_contract
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method StopSponsoringContract(Opal.NetApi.Generated.Model.primitive_types.H160 contract_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(contract_id.Encode());
            return new Method(73, "AppPromotion", 6, "stop_sponsoring_contract", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> payout_stakers
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method PayoutStakers(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8> stakers_number)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(stakers_number.Encode());
            return new Method(73, "AppPromotion", 7, "payout_stakers", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_unstake
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ForceUnstake(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32> pending_blocks)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pending_blocks.Encode());
            return new Method(73, "AppPromotion", 9, "force_unstake", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> AppPromotionConstants
    /// </summary>
    public sealed class AppPromotionConstants
    {
        
        /// <summary>
        /// >> PalletId
        ///  The app's pallet id, used for deriving its sovereign account address.
        /// </summary>
        public Opal.NetApi.Generated.Model.frame_support.PalletId PalletId()
        {
            var result = new Opal.NetApi.Generated.Model.frame_support.PalletId();
            result.Create("0x6170707374616B65");
            return result;
        }
        
        /// <summary>
        /// >> FreezeIdentifier
        ///  Freeze identifier used by the pallet
        /// </summary>
        public Opal.NetApi.Generated.Types.Base.Arr16U8 FreezeIdentifier()
        {
            var result = new Opal.NetApi.Generated.Types.Base.Arr16U8();
            result.Create("0x6170707374616B656170707374616B65");
            return result;
        }
        
        /// <summary>
        /// >> RecalculationInterval
        ///  In relay blocks.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 RecalculationInterval()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x40380000");
            return result;
        }
        
        /// <summary>
        /// >> PendingInterval
        ///  In parachain blocks.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 PendingInterval()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xE0C40000");
            return result;
        }
        
        /// <summary>
        /// >> IntervalIncome
        ///  Rate of return for interval in blocks defined in `RecalculationInterval`.
        /// </summary>
        public Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill IntervalIncome()
        {
            var result = new Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill();
            result.Create("0x88EA0600");
            return result;
        }
        
        /// <summary>
        /// >> Nominal
        ///  Decimals for the `Currency`.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Nominal()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x000064A7B3B6E00D0000000000000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> AppPromotionErrors
    /// </summary>
    public enum AppPromotionErrors
    {
        
        /// <summary>
        /// >> AdminNotSet
        /// Error due to action requiring admin to be set.
        /// </summary>
        AdminNotSet,
        
        /// <summary>
        /// >> NoPermission
        /// No permission to perform an action.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> NotSufficientFunds
        /// Insufficient funds to perform an action.
        /// </summary>
        NotSufficientFunds,
        
        /// <summary>
        /// >> PendingForBlockOverflow
        /// Occurs when a pending unstake cannot be added in this block. PENDING_LIMIT_PER_BLOCK` limits exceeded.
        /// </summary>
        PendingForBlockOverflow,
        
        /// <summary>
        /// >> SponsorNotSet
        /// The error is due to the fact that the collection/contract must already be sponsored in order to perform the action.
        /// </summary>
        SponsorNotSet,
        
        /// <summary>
        /// >> InsufficientStakedBalance
        /// Errors caused by insufficient staked balance.
        /// </summary>
        InsufficientStakedBalance,
        
        /// <summary>
        /// >> InconsistencyState
        /// Errors caused by incorrect state of a staker in context of the pallet.
        /// </summary>
        InconsistencyState,
    }
}
