    using System.Collections.Generic;
    using System;
    using UnityEngine;


public class InventoryController : MonoBehaviour
    {
       
        public event Action OnInventoryChanged;

        [SerializeField] private int _capacity = 10;
        [SerializeField] private List<InventorySlot> _slots;
        
        public IReadOnlyList<InventorySlot> Slots => _slots; // public access to read only

        private void Awake()
        {
            _slots = new List<InventorySlot>(_capacity);

            for(int i = 0; i < _capacity; i++)
            {
                _slots.Add(new InventorySlot());
            }
        }

    public bool AddItem(ItemData item, int amount)
        {
            // STAGE 0: FoolProof
            if (item == null || amount <= 0)
            {
                return false;
            }
            // STAGE 1: An attempt to add to the existing stack
            if (item.IsStackable)
            {
                foreach (var slot in _slots) {

                    if (!slot.IsEmpty && slot.ItemData.ID == item.ID && slot.Amount < item.MaxStack)
                    {
                        int spaceLeft = item.MaxStack - slot.Amount;

                        if (amount <= spaceLeft)
                        {
                            slot.AddAmount(amount);
                            OnInventoryChanged?.Invoke();
                            return true; // Everything fits in this stack!
                        }
                        else
                        {
                            slot.AddAmount(spaceLeft); // Fill the slot to the maximum (99)
                            amount -= spaceLeft;       // Reduce remaining amount by added value
                            // Let's go further in the cycle to look for a place for the rest!
                        }
                    }
            }
            }
        // STAGE 2: Checking into a new free slot if there are any Items left
        foreach (var slot in _slots)
        {
            if (slot.IsEmpty)
            {
                int addAmount = Mathf.Min(amount, item.MaxStack); //this line will take the minimum number
                slot.UpdateSlot(item, addAmount);
                amount -= addAmount;
                if (amount <= 0)
                {
                    OnInventoryChanged?.Invoke();
                    return true; //Everything successfully stacked  
                }
            }
        }
            // STAGE 3: Inventory is full
            Debug.LogWarning("[Inventory] Some of the items didn't fit, the Inventory is full!");
            return false;
        }
    }
