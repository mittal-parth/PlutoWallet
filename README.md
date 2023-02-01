# PlutoWallet

description here ...

# Work / milestones

### part 1 - PlutoConnector
0) create 2 new projects inside this solution:
  - 1 a class library (later on will be a Nuget package)
  - 2 mock dApp (testing app) - a simple console app that will connect to the wallet
1) find out how to connect the 2 apps via websocket (look into resources)
2) create the 2 basic call operations/methods:
  - OnConnect - 1st thing called when connection is successful - wallet returns publicKey to the dApp
  - RequestSign - dApp sends a sing request with the transaction data to the wallet and the wallet returns the signed data
  - ??? maybe more
3) make this a modular package -> release to Nuget
  - make this better compatible with Ajuna.NetApi???
4) generate QR

#### WebSocket solution
##### Hierarchy of classes and methods
- Connection Manager:
  - Connect()
  - SendData()
  - ReceiveData()
  - CloseConnection()
- Message Factory:
  - CreateRequestMessage()
  - CreateResponseMessage()
- Message Processor:
  - ParseMessage()
  - ProcessMessage()
- Error Handler:
  - HandleException()
  - LogError()
  - SendErrorInformation()

### part 2 - PlutoWallet
1) generate privateKey and show it to the user
2) save the privateKey securely
3) generate a publicKey from the privateKey
4) (extra) make ss58 encoded publicKeys
5) get the current balance
6) (extra) show the balance in USD (use coingecko free api)
7) add a transfer functionality
8) add the ability to sign any transaction
9) implement the PlutoConnect link (a specialized link that will open PlutoWallet app and pass in all the info needed to allow the connection between the dApp and the wallet)
10) QR scanner
11) improve UI
12) add multiple chain support
13) (extra) NFT implementation
14) (extra) secure with password/biometrics

# Resources to use

### Hackathon:
- https://www.polkadotglobalseries.com/

### Socket solutions:
- https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/sockets/socket-services?source=recommendations
- https://github.com/sta/websocket-sharp / http://sta.github.io/websocket-sharp/#secure-connection

### Polkadot solutions:
- https://github.com/ajuna-network

### Inspiration:
- https://walletconnect.com/
