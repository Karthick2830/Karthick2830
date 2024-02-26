using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI BoxText;

    // Start is called before the first frame update
    void Start()
    {
        BoxText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBoxText(PlayerInventory playerInventory)
    {
        BoxText.text = playerInventory.NumberOfBox.ToString();
    }
}
