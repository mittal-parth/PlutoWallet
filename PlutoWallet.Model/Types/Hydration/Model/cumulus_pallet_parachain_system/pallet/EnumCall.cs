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


namespace Hydration.NetApi.Generated.Model.cumulus_pallet_parachain_system.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_validation_data
        /// See [`Pallet::set_validation_data`].
        /// </summary>
        set_validation_data = 0,
        
        /// <summary>
        /// >> sudo_send_upward_message
        /// See [`Pallet::sudo_send_upward_message`].
        /// </summary>
        sudo_send_upward_message = 1,
        
        /// <summary>
        /// >> authorize_upgrade
        /// See [`Pallet::authorize_upgrade`].
        /// </summary>
        authorize_upgrade = 2,
        
        /// <summary>
        /// >> enact_authorized_upgrade
        /// See [`Pallet::enact_authorized_upgrade`].
        /// </summary>
        enact_authorized_upgrade = 3,
    }
    
    /// <summary>
    /// >> 358 - Variant[cumulus_pallet_parachain_system.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Hydration.NetApi.Generated.Model.cumulus_primitives_parachain_inherent.ParachainInherentData, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, BaseTuple<Hydration.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.Bool>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>
    {
    }
}
