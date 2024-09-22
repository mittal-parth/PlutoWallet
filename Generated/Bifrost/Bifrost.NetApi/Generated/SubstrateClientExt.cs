//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bifrost.NetApi.Generated.Storage;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Bifrost.NetApi.Generated
{
    
    
    /// <summary>
    /// >> Substrate Client Extension, including all Storage classes direct access.
    /// </summary>
    public sealed class SubstrateClientExt : Substrate.NetApi.SubstrateClient
    {
        
        /// <summary>
        /// StorageKeyDict for key definition informations.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>> StorageKeyDict;
        
        /// <summary>
        /// SystemStorage storage calls.
        /// </summary>
        public SystemStorage SystemStorage;
        
        /// <summary>
        /// TimestampStorage storage calls.
        /// </summary>
        public TimestampStorage TimestampStorage;
        
        /// <summary>
        /// IndicesStorage storage calls.
        /// </summary>
        public IndicesStorage IndicesStorage;
        
        /// <summary>
        /// ParachainSystemStorage storage calls.
        /// </summary>
        public ParachainSystemStorage ParachainSystemStorage;
        
        /// <summary>
        /// ParachainInfoStorage storage calls.
        /// </summary>
        public ParachainInfoStorage ParachainInfoStorage;
        
        /// <summary>
        /// TxPauseStorage storage calls.
        /// </summary>
        public TxPauseStorage TxPauseStorage;
        
        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public BalancesStorage BalancesStorage;
        
        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public TransactionPaymentStorage TransactionPaymentStorage;
        
        /// <summary>
        /// AuthorshipStorage storage calls.
        /// </summary>
        public AuthorshipStorage AuthorshipStorage;
        
        /// <summary>
        /// CollatorSelectionStorage storage calls.
        /// </summary>
        public CollatorSelectionStorage CollatorSelectionStorage;
        
        /// <summary>
        /// SessionStorage storage calls.
        /// </summary>
        public SessionStorage SessionStorage;
        
        /// <summary>
        /// AuraStorage storage calls.
        /// </summary>
        public AuraStorage AuraStorage;
        
        /// <summary>
        /// AuraExtStorage storage calls.
        /// </summary>
        public AuraExtStorage AuraExtStorage;
        
        /// <summary>
        /// DemocracyStorage storage calls.
        /// </summary>
        public DemocracyStorage DemocracyStorage;
        
        /// <summary>
        /// CouncilStorage storage calls.
        /// </summary>
        public CouncilStorage CouncilStorage;
        
        /// <summary>
        /// TechnicalCommitteeStorage storage calls.
        /// </summary>
        public TechnicalCommitteeStorage TechnicalCommitteeStorage;
        
        /// <summary>
        /// PhragmenElectionStorage storage calls.
        /// </summary>
        public PhragmenElectionStorage PhragmenElectionStorage;
        
        /// <summary>
        /// CouncilMembershipStorage storage calls.
        /// </summary>
        public CouncilMembershipStorage CouncilMembershipStorage;
        
        /// <summary>
        /// TechnicalMembershipStorage storage calls.
        /// </summary>
        public TechnicalMembershipStorage TechnicalMembershipStorage;
        
        /// <summary>
        /// ConvictionVotingStorage storage calls.
        /// </summary>
        public ConvictionVotingStorage ConvictionVotingStorage;
        
        /// <summary>
        /// ReferendaStorage storage calls.
        /// </summary>
        public ReferendaStorage ReferendaStorage;
        
        /// <summary>
        /// OriginsStorage storage calls.
        /// </summary>
        public OriginsStorage OriginsStorage;
        
        /// <summary>
        /// WhitelistStorage storage calls.
        /// </summary>
        public WhitelistStorage WhitelistStorage;
        
        /// <summary>
        /// XcmpQueueStorage storage calls.
        /// </summary>
        public XcmpQueueStorage XcmpQueueStorage;
        
        /// <summary>
        /// PolkadotXcmStorage storage calls.
        /// </summary>
        public PolkadotXcmStorage PolkadotXcmStorage;
        
        /// <summary>
        /// CumulusXcmStorage storage calls.
        /// </summary>
        public CumulusXcmStorage CumulusXcmStorage;
        
        /// <summary>
        /// MessageQueueStorage storage calls.
        /// </summary>
        public MessageQueueStorage MessageQueueStorage;
        
        /// <summary>
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// SchedulerStorage storage calls.
        /// </summary>
        public SchedulerStorage SchedulerStorage;
        
        /// <summary>
        /// ProxyStorage storage calls.
        /// </summary>
        public ProxyStorage ProxyStorage;
        
        /// <summary>
        /// MultisigStorage storage calls.
        /// </summary>
        public MultisigStorage MultisigStorage;
        
        /// <summary>
        /// IdentityStorage storage calls.
        /// </summary>
        public IdentityStorage IdentityStorage;
        
        /// <summary>
        /// VestingStorage storage calls.
        /// </summary>
        public VestingStorage VestingStorage;
        
        /// <summary>
        /// TreasuryStorage storage calls.
        /// </summary>
        public TreasuryStorage TreasuryStorage;
        
        /// <summary>
        /// PreimageStorage storage calls.
        /// </summary>
        public PreimageStorage PreimageStorage;
        
        /// <summary>
        /// EthereumStorage storage calls.
        /// </summary>
        public EthereumStorage EthereumStorage;
        
        /// <summary>
        /// EVMStorage storage calls.
        /// </summary>
        public EVMStorage EVMStorage;
        
        /// <summary>
        /// EVMChainIdStorage storage calls.
        /// </summary>
        public EVMChainIdStorage EVMChainIdStorage;
        
        /// <summary>
        /// DynamicFeeStorage storage calls.
        /// </summary>
        public DynamicFeeStorage DynamicFeeStorage;
        
        /// <summary>
        /// EVMAccountsStorage storage calls.
        /// </summary>
        public EVMAccountsStorage EVMAccountsStorage;
        
        /// <summary>
        /// XTokensStorage storage calls.
        /// </summary>
        public XTokensStorage XTokensStorage;
        
        /// <summary>
        /// TokensStorage storage calls.
        /// </summary>
        public TokensStorage TokensStorage;
        
        /// <summary>
        /// CurrenciesStorage storage calls.
        /// </summary>
        public CurrenciesStorage CurrenciesStorage;
        
        /// <summary>
        /// UnknownTokensStorage storage calls.
        /// </summary>
        public UnknownTokensStorage UnknownTokensStorage;
        
        /// <summary>
        /// OrmlXcmStorage storage calls.
        /// </summary>
        public OrmlXcmStorage OrmlXcmStorage;
        
        /// <summary>
        /// ZenlinkProtocolStorage storage calls.
        /// </summary>
        public ZenlinkProtocolStorage ZenlinkProtocolStorage;
        
        /// <summary>
        /// MerkleDistributorStorage storage calls.
        /// </summary>
        public MerkleDistributorStorage MerkleDistributorStorage;
        
        /// <summary>
        /// FlexibleFeeStorage storage calls.
        /// </summary>
        public FlexibleFeeStorage FlexibleFeeStorage;
        
        /// <summary>
        /// SalpStorage storage calls.
        /// </summary>
        public SalpStorage SalpStorage;
        
        /// <summary>
        /// AssetRegistryStorage storage calls.
        /// </summary>
        public AssetRegistryStorage AssetRegistryStorage;
        
        /// <summary>
        /// VtokenMintingStorage storage calls.
        /// </summary>
        public VtokenMintingStorage VtokenMintingStorage;
        
        /// <summary>
        /// SlpStorage storage calls.
        /// </summary>
        public SlpStorage SlpStorage;
        
        /// <summary>
        /// XcmInterfaceStorage storage calls.
        /// </summary>
        public XcmInterfaceStorage XcmInterfaceStorage;
        
        /// <summary>
        /// TokenConversionStorage storage calls.
        /// </summary>
        public TokenConversionStorage TokenConversionStorage;
        
        /// <summary>
        /// FarmingStorage storage calls.
        /// </summary>
        public FarmingStorage FarmingStorage;
        
        /// <summary>
        /// SystemStakingStorage storage calls.
        /// </summary>
        public SystemStakingStorage SystemStakingStorage;
        
        /// <summary>
        /// SystemMakerStorage storage calls.
        /// </summary>
        public SystemMakerStorage SystemMakerStorage;
        
        /// <summary>
        /// FeeShareStorage storage calls.
        /// </summary>
        public FeeShareStorage FeeShareStorage;
        
        /// <summary>
        /// CrossInOutStorage storage calls.
        /// </summary>
        public CrossInOutStorage CrossInOutStorage;
        
        /// <summary>
        /// VeMintingStorage storage calls.
        /// </summary>
        public VeMintingStorage VeMintingStorage;
        
        /// <summary>
        /// SlpxStorage storage calls.
        /// </summary>
        public SlpxStorage SlpxStorage;
        
        /// <summary>
        /// FellowshipCollectiveStorage storage calls.
        /// </summary>
        public FellowshipCollectiveStorage FellowshipCollectiveStorage;
        
        /// <summary>
        /// FellowshipReferendaStorage storage calls.
        /// </summary>
        public FellowshipReferendaStorage FellowshipReferendaStorage;
        
        /// <summary>
        /// StableAssetStorage storage calls.
        /// </summary>
        public StableAssetStorage StableAssetStorage;
        
        /// <summary>
        /// StablePoolStorage storage calls.
        /// </summary>
        public StablePoolStorage StablePoolStorage;
        
        /// <summary>
        /// VtokenVotingStorage storage calls.
        /// </summary>
        public VtokenVotingStorage VtokenVotingStorage;
        
        /// <summary>
        /// LendMarketStorage storage calls.
        /// </summary>
        public LendMarketStorage LendMarketStorage;
        
        /// <summary>
        /// PricesStorage storage calls.
        /// </summary>
        public PricesStorage PricesStorage;
        
        /// <summary>
        /// OracleStorage storage calls.
        /// </summary>
        public OracleStorage OracleStorage;
        
        /// <summary>
        /// OracleMembershipStorage storage calls.
        /// </summary>
        public OracleMembershipStorage OracleMembershipStorage;
        
        /// <summary>
        /// LeverageStakingStorage storage calls.
        /// </summary>
        public LeverageStakingStorage LeverageStakingStorage;
        
        /// <summary>
        /// ChannelCommissionStorage storage calls.
        /// </summary>
        public ChannelCommissionStorage ChannelCommissionStorage;
        
        /// <summary>
        /// CloudsConvertStorage storage calls.
        /// </summary>
        public CloudsConvertStorage CloudsConvertStorage;
        
        /// <summary>
        /// BuyBackStorage storage calls.
        /// </summary>
        public BuyBackStorage BuyBackStorage;
        
        public SubstrateClientExt(System.Uri uri, Substrate.NetApi.Model.Extrinsics.ChargeType chargeType) : 
                base(uri, chargeType)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new SystemStorage(this);
            this.TimestampStorage = new TimestampStorage(this);
            this.IndicesStorage = new IndicesStorage(this);
            this.ParachainSystemStorage = new ParachainSystemStorage(this);
            this.ParachainInfoStorage = new ParachainInfoStorage(this);
            this.TxPauseStorage = new TxPauseStorage(this);
            this.BalancesStorage = new BalancesStorage(this);
            this.TransactionPaymentStorage = new TransactionPaymentStorage(this);
            this.AuthorshipStorage = new AuthorshipStorage(this);
            this.CollatorSelectionStorage = new CollatorSelectionStorage(this);
            this.SessionStorage = new SessionStorage(this);
            this.AuraStorage = new AuraStorage(this);
            this.AuraExtStorage = new AuraExtStorage(this);
            this.DemocracyStorage = new DemocracyStorage(this);
            this.CouncilStorage = new CouncilStorage(this);
            this.TechnicalCommitteeStorage = new TechnicalCommitteeStorage(this);
            this.PhragmenElectionStorage = new PhragmenElectionStorage(this);
            this.CouncilMembershipStorage = new CouncilMembershipStorage(this);
            this.TechnicalMembershipStorage = new TechnicalMembershipStorage(this);
            this.ConvictionVotingStorage = new ConvictionVotingStorage(this);
            this.ReferendaStorage = new ReferendaStorage(this);
            this.OriginsStorage = new OriginsStorage(this);
            this.WhitelistStorage = new WhitelistStorage(this);
            this.XcmpQueueStorage = new XcmpQueueStorage(this);
            this.PolkadotXcmStorage = new PolkadotXcmStorage(this);
            this.CumulusXcmStorage = new CumulusXcmStorage(this);
            this.MessageQueueStorage = new MessageQueueStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.SchedulerStorage = new SchedulerStorage(this);
            this.ProxyStorage = new ProxyStorage(this);
            this.MultisigStorage = new MultisigStorage(this);
            this.IdentityStorage = new IdentityStorage(this);
            this.VestingStorage = new VestingStorage(this);
            this.TreasuryStorage = new TreasuryStorage(this);
            this.PreimageStorage = new PreimageStorage(this);
            this.EthereumStorage = new EthereumStorage(this);
            this.EVMStorage = new EVMStorage(this);
            this.EVMChainIdStorage = new EVMChainIdStorage(this);
            this.DynamicFeeStorage = new DynamicFeeStorage(this);
            this.EVMAccountsStorage = new EVMAccountsStorage(this);
            this.XTokensStorage = new XTokensStorage(this);
            this.TokensStorage = new TokensStorage(this);
            this.CurrenciesStorage = new CurrenciesStorage(this);
            this.UnknownTokensStorage = new UnknownTokensStorage(this);
            this.OrmlXcmStorage = new OrmlXcmStorage(this);
            this.ZenlinkProtocolStorage = new ZenlinkProtocolStorage(this);
            this.MerkleDistributorStorage = new MerkleDistributorStorage(this);
            this.FlexibleFeeStorage = new FlexibleFeeStorage(this);
            this.SalpStorage = new SalpStorage(this);
            this.AssetRegistryStorage = new AssetRegistryStorage(this);
            this.VtokenMintingStorage = new VtokenMintingStorage(this);
            this.SlpStorage = new SlpStorage(this);
            this.XcmInterfaceStorage = new XcmInterfaceStorage(this);
            this.TokenConversionStorage = new TokenConversionStorage(this);
            this.FarmingStorage = new FarmingStorage(this);
            this.SystemStakingStorage = new SystemStakingStorage(this);
            this.SystemMakerStorage = new SystemMakerStorage(this);
            this.FeeShareStorage = new FeeShareStorage(this);
            this.CrossInOutStorage = new CrossInOutStorage(this);
            this.VeMintingStorage = new VeMintingStorage(this);
            this.SlpxStorage = new SlpxStorage(this);
            this.FellowshipCollectiveStorage = new FellowshipCollectiveStorage(this);
            this.FellowshipReferendaStorage = new FellowshipReferendaStorage(this);
            this.StableAssetStorage = new StableAssetStorage(this);
            this.StablePoolStorage = new StablePoolStorage(this);
            this.VtokenVotingStorage = new VtokenVotingStorage(this);
            this.LendMarketStorage = new LendMarketStorage(this);
            this.PricesStorage = new PricesStorage(this);
            this.OracleStorage = new OracleStorage(this);
            this.OracleMembershipStorage = new OracleMembershipStorage(this);
            this.LeverageStakingStorage = new LeverageStakingStorage(this);
            this.ChannelCommissionStorage = new ChannelCommissionStorage(this);
            this.CloudsConvertStorage = new CloudsConvertStorage(this);
            this.BuyBackStorage = new BuyBackStorage(this);
        }
    }
}
