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


namespace Opal.NetApi.Generated.Model.xcm.v2
{
    
    
    /// <summary>
    /// >> WeightLimit
    /// </summary>
    public enum WeightLimit
    {
        
        /// <summary>
        /// >> Unlimited
        /// </summary>
        Unlimited = 0,
        
        /// <summary>
        /// >> Limited
        /// </summary>
        Limited = 1,
    }
    
    /// <summary>
    /// >> 236 - Variant[xcm.v2.WeightLimit]
    /// </summary>
    public sealed class EnumWeightLimit : BaseEnumRust<WeightLimit>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumWeightLimit()
        {
				AddTypeDecoder<BaseVoid>(WeightLimit.Unlimited);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>(WeightLimit.Limited);
        }
    }
}
