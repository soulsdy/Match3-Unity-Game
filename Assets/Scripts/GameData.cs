using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public static  class GameData 
{   
    const string tileDataPath="Assets/GameData/TileData.asset";
    const string objItemPath="Assets/GameData/ObjItem.prefab";
    static TileData tileData;
    static GameObject objItem;
    public static TileData GetTileData(){
        return tileData;
    }
    public static GameObject GetItem(){

        return objItem;
    }
    public static void LoadData(){
        Addressables.LoadAssetAsync<TileData>(tileDataPath).Completed += OnLoadTileDataDone;
        Addressables.LoadAssetAsync<GameObject>(objItemPath).Completed += OnLoadObjItemDone;
    }
    static void OnLoadTileDataDone(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TileData> obj)
    {
       tileData=obj.Result;
    }
    static void OnLoadObjItemDone(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
       objItem=obj.Result;
    }
}
