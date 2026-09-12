using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{

    [SerializeField] private Image _iconImage;
    [SerializeField] private TextMeshProUGUI _amountText;

    public void UpdateSlotUI(InventorySlot slot)
    {
        if (slot.IsEmpty)
        {
            _iconImage.gameObject.SetActive(false);
            _amountText.text = string.Empty;

        }
        else
            {
                _iconImage.gameObject.SetActive(true);
                _iconImage.sprite = slot.ItemData.Icon;

                _amountText.text = slot.Amount.ToString();
            }
        }

    }

