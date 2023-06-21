using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public  class GameData : MonoBehaviour
{   
    public static GameData Instance;
    [SerializeField] public TileData tileData;
    [SerializeField] public GameObject objItem;
    void Awake(){
        Instance=this;
    }
    public static TileData GetTileData(){
        return Instance.tileData;
    }

    
    public static GameObject GetItem(){

        return Instance.objItem;
    }
    
    
}
