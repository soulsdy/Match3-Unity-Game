using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    protected override int GetPrefabIndex()
    {
       // int prefabname = 0;
        // switch (ItemType)
        // {
        //     case eNormalType.TYPE_ONE:
        //         prefabname = 0;
        //         break;
        //     case eNormalType.TYPE_TWO:
        //         prefabname = 1;
        //         break;
        //     case eNormalType.TYPE_THREE:
        //         prefabname = 2;
        //         break;
        //     case eNormalType.TYPE_FOUR:
        //         prefabname = 3;
        //         break;
        //     case eNormalType.TYPE_FIVE:
        //         prefabname = 4;
        //         break;
        //     case eNormalType.TYPE_SIX:
        //         prefabname = 5;
        //         break;
        //     case eNormalType.TYPE_SEVEN:
        //         prefabname = 6;
        //         break;
        // }

        return (int)ItemType;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}
