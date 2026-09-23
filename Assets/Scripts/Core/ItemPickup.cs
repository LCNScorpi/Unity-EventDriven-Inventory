using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private InventoryController _inventoryController;
    [SerializeField] private ItemData _itemData;
    [SerializeField] private int _amount = 1;

    private void OnMouseDown()
    {
        Debug.Log("Click on the item");
        Pickup();
    }

    private void Pickup()
    {
        if (_inventoryController != null && _itemData != null)
        {
            _inventoryController.AddItem(_itemData, _amount);
            Destroy(gameObject);
        }
    }
}
