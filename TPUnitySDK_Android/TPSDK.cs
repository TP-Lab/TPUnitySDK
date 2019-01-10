using System;
using UnityEngine;
namespace TP
{
    public class TPSDK
    {

        private const int CANCEL = 0;
        private const int SUCCESS = 1;
        private const int ERROR = 2;
        AndroidJavaClass tpSDK;

        public TPSDK(string tpSDKCallbackObj)
        {
            AndroidJavaObject unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            tpSDK = new AndroidJavaClass("com.tokenpocket.opensdk.TPSDK");
            tpSDK.CallStatic("init", currentActivity, tpSDKCallbackObj);
        }

        public void authLogin(string authLoginParam)
        {
            tpSDK.CallStatic("authLogin", authLoginParam);
        }

        public void transfer(string transferParam)
        {
            tpSDK.CallStatic("transfer", transferParam);
        }

        public void pushTransaction(string actions)
        {
            tpSDK.CallStatic("pushTransaction", actions);
        }

        public void getAccount(string account)
        {
            tpSDK.CallStatic("getAccountInfo", account);
        }

        public void getTableRows(string tableRowParam)
        {
            tpSDK.CallStatic("getTableRows", tableRowParam);
        }

        public void getCurrencyBalance(string param)
        {
            tpSDK.CallStatic("getCurrencyBalance", param);

        }
        public void showUnityMsg(string msg)
        {
            tpSDK.CallStatic("showUnityMsg", msg);
        }

     
    }
}
