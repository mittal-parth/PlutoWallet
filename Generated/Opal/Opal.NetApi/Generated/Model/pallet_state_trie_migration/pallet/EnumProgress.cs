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


namespace Opal.NetApi.Generated.Model.pallet_state_trie_migration.pallet
{
    
    
    /// <summary>
    /// >> Progress
    /// </summary>
    public enum Progress
    {
        
        /// <summary>
        /// >> ToStart
        /// </summary>
        ToStart = 0,
        
        /// <summary>
        /// >> LastKey
        /// </summary>
        LastKey = 1,
        
        /// <summary>
        /// >> Complete
        /// </summary>
        Complete = 2,
    }
    
    /// <summary>
    /// >> 93 - Variant[pallet_state_trie_migration.pallet.Progress]
    /// </summary>
    public sealed class EnumProgress : BaseEnumRust<Progress>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumProgress()
        {
				AddTypeDecoder<BaseVoid>(Progress.ToStart);
				AddTypeDecoder<Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>(Progress.LastKey);
				AddTypeDecoder<BaseVoid>(Progress.Complete);
        }
    }
}
