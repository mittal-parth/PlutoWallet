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


namespace Polkadot.NetApi.Generated.Model.pallet_grandpa
{
    
    
    /// <summary>
    /// >> StoredState
    /// </summary>
    public enum StoredState
    {
        
        /// <summary>
        /// >> Live
        /// </summary>
        Live = 0,
        
        /// <summary>
        /// >> PendingPause
        /// </summary>
        PendingPause = 1,
        
        /// <summary>
        /// >> Paused
        /// </summary>
        Paused = 2,
        
        /// <summary>
        /// >> PendingResume
        /// </summary>
        PendingResume = 3,
    }
    
    /// <summary>
    /// >> 621 - Variant[pallet_grandpa.StoredState]
    /// </summary>
    public sealed class EnumStoredState : BaseEnumRust<StoredState>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumStoredState()
        {
				AddTypeDecoder<BaseVoid>(StoredState.Live);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(StoredState.PendingPause);
				AddTypeDecoder<BaseVoid>(StoredState.Paused);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(StoredState.PendingResume);
        }
    }
}
