//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.pallet_staking
{
    
    
    /// <summary>
    /// >> RewardDestination
    /// </summary>
    public enum RewardDestination
    {
        
        /// <summary>
        /// >> Staked
        /// </summary>
        Staked = 0,
        
        /// <summary>
        /// >> Stash
        /// </summary>
        Stash = 1,
        
        /// <summary>
        /// >> Controller
        /// </summary>
        Controller = 2,
        
        /// <summary>
        /// >> Account
        /// </summary>
        Account = 3,
        
        /// <summary>
        /// >> None
        /// </summary>
        None = 4,
    }
    
    /// <summary>
    /// >> 42 - Variant[pallet_staking.RewardDestination]
    /// </summary>
    public sealed class EnumRewardDestination : BaseEnumRust<RewardDestination>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRewardDestination()
        {
				AddTypeDecoder<BaseVoid>(RewardDestination.Staked);
				AddTypeDecoder<BaseVoid>(RewardDestination.Stash);
				AddTypeDecoder<BaseVoid>(RewardDestination.Controller);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32>(RewardDestination.Account);
				AddTypeDecoder<BaseVoid>(RewardDestination.None);
        }
    }
}
