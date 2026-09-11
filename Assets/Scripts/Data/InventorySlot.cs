using System;
using UnityEngine;

[Serializable]
public class InventorySlot
{
    [SerializeField] private ItemData _itemData;
    [SerializeField] private int _amount;

    //Getters only to read
    public ItemData ItemData => _itemData;
    public int Amount => _amount;
    public bool IsEmpty => _itemData == null || _amount <= 0;

  

    public InventorySlot()
    {
        _itemData = null;
        _amount = 0;
    }

    public InventorySlot(ItemData itemData, int amount)
    {
        _itemData = itemData;
        _amount = amount;
    }

    public void AddAmount(int value)  => _amount += value;

    public void UpdateSlot(ItemData itemData,int amount)
    {
        _itemData = itemData;
        _amount = amount;
    }

}
