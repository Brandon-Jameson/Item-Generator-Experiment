using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ItemGenerator : MonoBehaviour
{
    private string rarity;
    private string material;
    private string itemType;
    private TMP_Text itemText;
    private MaterialGenerator matGen;
    private RarityGenerator rarGen;
    private ItemTypeGenerator itmTypGen;
    private const string noItemStr = "No Item found";

    void Start()
    {
        itemText = GameObject.Find("ItemText").GetComponent<TMP_Text>();
        matGen = GetComponent<MaterialGenerator>();
        rarGen = GetComponent<RarityGenerator>();
        itmTypGen = GetComponent<ItemTypeGenerator>();
        itemText.text = String.Format("{0}", noItemStr);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GenerateItem();
        }
    }

    void GenerateItem()
    {
        AssignVariables();
        SetTextColor(rarGen.Color);
        string s = String.Format("Generated Item: {0} {1} {2}", rarity, material, itemType);
        itemText.text = s;
    }

    void AssignVariables()
    {
        itemType = itmTypGen.GetItemType();
        material = matGen.GetMaterial();
        rarity = rarGen.GetRarity();        
    }

    void SetTextColor(string rarity)
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
}
