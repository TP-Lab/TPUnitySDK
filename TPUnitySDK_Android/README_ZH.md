# TPUnitySDK for Android
U3D开发者可以使用该SDK拉起TokenPocket钱包执行授权登陆，转账，pushTransaction, 获取tableRows, 获取代币余额等操作。

注意：V0.6.5及以上的TokenPocket 支持该SDK，现已发布到官网和GooglePlay

## 使用

### 拷贝相关文件
- 拷贝 tpunitysdk-release.aar to  Assets-Plugins->Android->libs 目录
- 拷贝 AndroidMainifest.xml 到Android目录
- 拷贝 TPSDK.cs到scripts目录


### 函数调用
- 将当前游戏对象的名字传递给TPSDK 初始化SDK对象，游戏对象绑定了脚本文件，脚本文件定义了操作回调方法
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

- 调用函数，这里以授权登陆为例说明
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

登陆结束后，钱包会回调通知Unity, 注意，必须在游戏对象绑定的脚本中定义onTpAuthLogin方法才能收到回调

其他方法调用方式类似

## API列表
- tpSDK.authLogin(authLoginParam);// 拉起TokenPocket 授权登陆

- tpSDK.transfer(transferParam); // 拉起TokenPocket转账

- tpSDK.pushTransaction(actions);// 拉起TokenPocket执行pushTransaction 操作

- tpSDK.getAccount(account);// 获取账号信息

- tpSDK.getTableRows(tableRowsParam); //获取tableRows信息

- tpSDK.getCurrencyBalance(balanceParam); 获取账号代币余额

- tpSDK.sign(signParam);// 信息签名

## 更多使用细节参照AndroidU3dTest.zip工程

## 协议文档
https://github.com/TP-Lab/tp-wallet-sdk

