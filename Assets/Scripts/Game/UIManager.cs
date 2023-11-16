using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    private TMP_Text itemText;
    private RarityGenerator rarGen;
    private const string noItemStr = "No Item found";

    void Start()
    {
        rarGen = GameObject.Find("Item Generator").GetComponent<RarityGenerator>();
        itemText = GetComponentInChildren<TMP_Text>();
        itemText.text = String.Format("{0}", noItemStr);
    }

    public void SetTextColor(string rarity)
    {
        string hexColor = rarGen.Color;
        Color color;
        if (ColorUtility.TryParseHtmlString(hexColor, out color))
        {
            itemText.color = color;
        }
        else
        {
            Debug.LogError("Invalid hex color code: " + hexColor);
        }
    }

    public void UpdateText(string itemOutput)
    {
        itemText.text = itemOutput;
    }
}
