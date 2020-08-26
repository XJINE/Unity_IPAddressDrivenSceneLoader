using System;
using System.Linq;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IPAddressDrivenSceneLoader : SingletonMonoBehaviour<IPAddressDrivenSceneLoader>
{
    [System.Serializable]
    public class SceneInfo
    {
        public string        ipAddress;
        public string        sceneName;
        public LoadSceneMode loadMode;
    }

    #region Field

    public SceneInfo[] sceneInfos;

    protected bool singleSceneLoaded;

    #endregion Field

    #region Method

    // NOTE:
    // Set into IPAddressNotifier.observers.handler.

    public virtual void IPAddressEventHandler(IPAddress ipAddress)
    {
        // NOTE:
        // Need to avoid load single-scene twice.

        try
        {
            SceneInfo sceneInfo = this.sceneInfos.FirstOrDefault(info => info.ipAddress == ipAddress.ToString());

            if (sceneInfo == null || this.singleSceneLoaded)
            {
                return;
            }

            this.singleSceneLoaded = sceneInfo.loadMode == LoadSceneMode.Single;

            SceneManager.LoadScene(sceneInfo.sceneName, sceneInfo.loadMode);
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
    }

    #endregion Method
}