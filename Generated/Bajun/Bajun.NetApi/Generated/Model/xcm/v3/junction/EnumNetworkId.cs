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
    /// >> NetworkId
    /// </summary>
    public enum NetworkId
    {
        
        /// <summary>
        /// >> ByGenesis
        /// </summary>
        ByGenesis = 0,
        
        /// <summary>
        /// >> ByFork
        /// </summary>
        ByFork = 1,
        
        /// <summary>
        /// >> Polkadot
        /// </summary>
        Polkadot = 2,
        
        /// <summary>
        /// >> Kusama
        /// </summary>
        Kusama = 3,
        
        /// <summary>
        /// >> Westend
        /// </summary>
        Westend = 4,
        
        /// <summary>
        /// >> Rococo
        /// </summary>
        Rococo = 5,
        
        /// <summary>
        /// >> Wococo
        /// </summary>
        Wococo = 6,
        
        /// <summary>
        /// >> Ethereum
        /// </summary>
        Ethereum = 7,
        
        /// <summary>
        /// >> BitcoinCore
        /// </summary>
        BitcoinCore = 8,
        
        /// <summary>
        /// >> BitcoinCash
        /// </summary>
        BitcoinCash = 9,
        
        /// <summary>
        /// >> PolkadotBulletin
        /// </summary>
        PolkadotBulletin = 10,
    }
    
    /// <summary>
    /// >> 128 - Variant[xcm.v3.junction.NetworkId]
    /// </summary>
    public sealed class EnumNetworkId : BaseEnumRust<NetworkId>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumNetworkId()
        {
				AddTypeDecoder<Bajun.NetApi.Generated.Types.Base.Arr32U8>(NetworkId.ByGenesis);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Bajun.NetApi.Generated.Types.Base.Arr32U8>>(NetworkId.ByFork);
				AddTypeDecoder<BaseVoid>(NetworkId.Polkadot);
				AddTypeDecoder<BaseVoid>(NetworkId.Kusama);
				AddTypeDecoder<BaseVoid>(NetworkId.Westend);
				AddTypeDecoder<BaseVoid>(NetworkId.Rococo);
				AddTypeDecoder<BaseVoid>(NetworkId.Wococo);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>(NetworkId.Ethereum);
				AddTypeDecoder<BaseVoid>(NetworkId.BitcoinCore);
				AddTypeDecoder<BaseVoid>(NetworkId.BitcoinCash);
				AddTypeDecoder<BaseVoid>(NetworkId.PolkadotBulletin);
        }
    }
}
