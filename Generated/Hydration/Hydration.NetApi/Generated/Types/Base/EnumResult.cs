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


namespace Hydration.NetApi.Generated.Types.Base
{
    
    
    /// <summary>
    /// >> Result
    /// </summary>
    public enum Result
    {
        
        /// <summary>
        /// >> Ok
        /// </summary>
        Ok = 0,
        
        /// <summary>
        /// >> Err
        /// </summary>
        Err = 1,
    }
    
    /// <summary>
    /// >> 38 - Variant[Result]
    /// </summary>
    public sealed class EnumResult : BaseEnumRust<Result>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumResult()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseTuple>(Result.Ok);
				AddTypeDecoder<Hydration.NetApi.Generated.Model.sp_runtime.EnumDispatchError>(Result.Err);
        }
    }
}
