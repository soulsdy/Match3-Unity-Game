using System;
using UnityEngine;
using System.Collections.Generic;

public class Cell : MonoBehaviour
{
    public int BoardX { get; private set; }

    public int BoardY { get; private set; }

    public Item Item { get; private set; }

    public Cell NeighbourUp { get; set; }

    public Cell NeighbourRight { get; set; }

    public Cell NeighbourBottom { get; set; }

    public Cell NeighbourLeft { get; set; }


    public bool IsEmpty => Item == null;

    public void Setup(int cellX, int cellY)
    {
        this.BoardX = cellX;
        this.BoardY = cellY;
    }

    public bool IsNeighbour(Cell other)
    {
        return BoardX == other.BoardX && Mathf.Abs(BoardY - other.BoardY) == 1 ||
            BoardY == other.BoardY && Mathf.Abs(BoardX - other.BoardX) == 1;
    }


    public void Free()
    {
        Item = null;
    }

    public void Assign(Item item)
    {
        Item = item;
        Item.SetCell(this);
    }

    public void ApplyItemPosition(bool withAppearAnimation)
    {
        Item.SetViewPosition(this.transform.position);

        if (withAppearAnimation)
        {
            Item.ShowAppearAnimation();
        }
    }
    public List<NormalItem.eNormalType> GetItemTypesInNeibour()
    {
        List<NormalItem.eNormalType> types = new List<NormalItem.eNormalType>();
        if (!IsNullOrEmpty(NeighbourBottom))
            types.Add(GetItemType(NeighbourBottom));
        if (!IsNullOrEmpty(NeighbourLeft))
            types.Add(GetItemType(NeighbourLeft));
        if (!IsNullOrEmpty(NeighbourRight))
            types.Add(GetItemType(NeighbourRight));
        if (!IsNullOrEmpty(NeighbourUp))
            types.Add(GetItemType(NeighbourUp));
        return types;
    }
    NormalItem.eNormalType GetItemType(Cell cell)
    {
        NormalItem normarlItem = cell.Item as NormalItem;
        return normarlItem.ItemType;
    }
    bool IsNullOrEmpty(Cell cell)
    {
        if (cell == null || cell.Item == null) return true;
        return false;

    }
    internal void Clear()
    {
        if (Item != null)
        {
            Item.Clear();
            Item = null;
        }
    }

    internal bool IsSameType(Cell other)
    {
        return Item != null && other.Item != null && Item.IsSameType(other.Item);
    }

    internal void ExplodeItem()
    {
        if (Item == null) return;

        Item.ExplodeView();
        Item = null;
    }

    internal void AnimateItemForHint()
    {
        Item.AnimateForHint();
    }

    internal void StopHintAnimation()
    {
        Item.StopAnimateForHint();
    }

    internal void ApplyItemMoveToPosition()
    {
        Item.AnimationMoveToPosition();
    }
}
