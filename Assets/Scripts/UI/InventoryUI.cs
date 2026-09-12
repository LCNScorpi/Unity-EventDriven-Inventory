using UnityEngine;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{

    [SerializeField] private InventoryController _inventoryController;
    [SerializeField] private InventorySlotUI _slotPrefab;
    [SerializeField] private Transform _slotParent;// The object with the GridLayoutGroup component (Inventory Panel)

    private List<InventorySlotUI> _uiSlots = new List<InventorySlotUI>();

    private void Start()
    {
        InitUI();
        RedrawUI();

    }

    private void OnEnable()
    {
        if(_inventoryController != null)
        {
            _inventoryController.OnInventoryChanged += RedrawUI;
        }
    }

    private void OnDisable()
    {
        if (_inventoryController != null)
        {
            _inventoryController.OnInventoryChanged -= RedrawUI;
        }
    }

    private void InitUI()
    {
        foreach (Transform child in _slotParent)
        {
            Destroy(child.gameObject);
        }

        for(int i =0; i < _inventoryController.Slots.Count; i++)
        {
            var slotUI = Instantiate(_slotPrefab, _slotParent);
            _uiSlots.Add(slotUI);
        }
    }

    private void RedrawUI()
    {
        for (int i = 0; i < _uiSlots.Count; i++)
        {
            _uiSlots[i].UpdateSlotUI(_inventoryController.Slots[i]);
        }

    }

}
