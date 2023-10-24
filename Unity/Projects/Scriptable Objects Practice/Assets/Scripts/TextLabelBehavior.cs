using System.Globalization;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]

public class TextLabelBehavior : MonoBehaviour
{
    public TextMeshProUGUI label;
    public FloatData dataObj;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        UpdateLabel();
        
    }

    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
