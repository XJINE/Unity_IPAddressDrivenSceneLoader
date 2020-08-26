# Unity_IPAddressDrivenSceneLoader

<img src="https://github.com/XJINE/Unity_IPAddressDrivenSceneLoader/blob/master/Screenshot.png" width="100%" height="auto" />

``IPAddressDrivenSceneLoader`` select and load your scene from IPAddress.

## Import to Your Project

You can import this asset from UnityPackage.

- [IPAddressDrivenSceneLoader.unitypackage](https://github.com/XJINE/Unity_IPAddressDrivenSceneLoader/blob/master/IPAddressDrivenSceneLoader.unitypackage)

### Dependencies

You have to import following assets to use this asset.

- [IPAddressNotifier](https://github.com/XJINE/Unity_IPAddressNotifier)
- [SingletonMonoBehaviour](https://github.com/XJINE/Unity_SingletonMonoBehaviour)

## How to Use

1. Set ``IPAddressDrivenSceneLoader.IPAddressEventHandler`` into ``IPAddressNotifier.Observers.Handler``.
2. Set some ``IPAddress`` and the related ``SceneName`` from Inspector.