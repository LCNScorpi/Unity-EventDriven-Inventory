using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData", menuName = "Inventory/Item Data")]
public class ItemData : ScriptableObject
{
    [Header("Base Info")]
    [SerializeField] private string _id;
    [SerializeField] private string _displayName;
    [TextArea(2, 4)]
    [SerializeField] private string _description;
    [SerializeField] private Sprite _icon;

    [Header("Stack Settings")]
    [SerializeField] private bool _isStackable = true;
    [SerializeField] private int _maxStack = 99;

    // Public features  only for reading (Getters)

    public string ID => _id;
    public string DisplayName => _displayName;
    public string Description => _description;
    public Sprite Icon => _icon;

    public bool IsStackable => _isStackable;
    public int MaxStack => _maxStack;
}
