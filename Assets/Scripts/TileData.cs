using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "Data/TileData", order = 1)]
public class TileData : ScriptableObject
{
    [SerializeField] Sprite[] listIcon;
    public Sprite GetSprite(int index){
        return listIcon[index];
    }
}
