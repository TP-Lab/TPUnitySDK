# TPUnitySDK for Android
TokenPocket Unity SDK for Android, U3D developer can use this SDK to pull up TokenPocket do some actions, such as login, token transfer, push transaction etc

Notice: Only version 0.6.5 or higher support this SDK. Now is released to GooglePlay and official website

## How to use

### Copy files
- Copy tpunitysdk-release.aar to  Assets-Plugins->Android->libs directory
- Copy AndroidMainifest.xml to Android directory
- Copy TPSDK.cs to your scripts directory

### Call Api
- Initialize the TPSDK object。here you should take the game object name as parameter.
~~~
public class AndroidU3dTest : MonoBehaviour
{
    TPSDK tpSDK;
   
    void Start()
    {
        tpSDK = new TPSDK("MainCamera");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
~~~

- Defining a callback function to get result
~~~
    public void onTpAuthLogin(string data)
    {
        Debug.Log(data);
    }
~~~

- Call the api
~~~
    public void authLogin()
    {
        string authLoginParam = "{\n" +
                       " \"protocol\": \"TokenPocket\",\n" +
                       " \"version\": \"1.0\",\n" +
                       " \"dappName\": \"testDapp\",\n" +
                       " \"dappIcon\": \"https://testurl.io/img/icon.png\",\n" +
                       " \"action\": \"login\",\n" +
                       " \"actionId\": \"sd8c-90c9-2172decea5\",\n" +
                       " \"callbackUrl\": \"\",\n" +
                       " \"expired\": 1542392547,\n" +
                       " \"memo\": \"test sdk\"\n" +
                       "}";
        tpSDK.authLogin(authLoginParam);
     
    }
~~~

When authLogin finished, you can get result in onTpAuthLogin function

Other apis are similar to authLogin。

## APIs
- tpSDK.authLogin(authLoginParam);// pull up TokenPocket to auth login

- tpSDK.transfer(transferParam); // pull up TokenPocket to transfer token

- tpSDK.pushTransaction(actions);// pull up TokenPocket to push actions;

- tpSDK.getAccount(account);//get eos accountinfo

- tpSDK.getTableRows(tableRowsParam);

- tpSDK.getCurrencyBalance(balanceParam); get account token balance

- tpSDK.sign(signParam);// sign message

## AndroidU3dTest.zip is a unity sample project, you can get more details

## TokenPocket Wallet Protocol
https://github.com/TP-Lab/tp-wallet-sdk
