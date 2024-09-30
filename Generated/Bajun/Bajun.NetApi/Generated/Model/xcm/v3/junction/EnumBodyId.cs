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


namespace Bajun.NetApi.Generated.Model.xcm.v3.junction
{
    
    
    /// <summary>
    /// >> BodyId
    /// </summary>
    public enum BodyId
    {
        
        /// <summary>
        /// >> Unit
        /// </summary>
        Unit = 0,
        
        /// <summary>
        /// >> Moniker
        /// </summary>
        Moniker = 1,
        
        /// <summary>
        /// >> Index
        /// </summary>
        Index = 2,
        
        /// <summary>
        /// >> Executive
        /// </summary>
        Executive = 3,
        
        /// <summary>
        /// >> Technical
        /// </summary>
        Technical = 4,
        
        /// <summary>
        /// >> Legislative
        /// </summary>
        Legislative = 5,
        
        /// <summary>
        /// >> Judicial
        /// </summary>
        Judicial = 6,
        
        /// <summary>
        /// >> Defense
        /// </summary>
        Defense = 7,
        
        /// <summary>
        /// >> Administration
        /// </summary>
        Administration = 8,
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Treasury = 9,
    }
    
    /// <summary>
    /// >> 69 - Variant[xcm.v3.junction.BodyId]
    /// </summary>
    public sealed class EnumBodyId : BaseEnumRust<BodyId>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumBodyId()
        {
				AddTypeDecoder<BaseVoid>(BodyId.Unit);
				AddTypeDecoder<Bajun.NetApi.Generated.Types.Base.Arr4U8>(BodyId.Moniker);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(BodyId.Index);
				AddTypeDecoder<BaseVoid>(BodyId.Executive);
				AddTypeDecoder<BaseVoid>(BodyId.Technical);
				AddTypeDecoder<BaseVoid>(BodyId.Legislative);
				AddTypeDecoder<BaseVoid>(BodyId.Judicial);
				AddTypeDecoder<BaseVoid>(BodyId.Defense);
				AddTypeDecoder<BaseVoid>(BodyId.Administration);
				AddTypeDecoder<BaseVoid>(BodyId.Treasury);
        }
    }
}
