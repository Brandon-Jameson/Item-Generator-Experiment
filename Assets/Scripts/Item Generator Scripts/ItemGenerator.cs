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
    private MaterialGenerator matGen;
    private RarityGenerator rarGen;
    private ItemTypeGenerator itmTypGen;
    private UIManager UI;
    private string itemOutput;

    void Start()
    {
        UI = GameObject.Find("UI").GetComponent<UIManager>();
        matGen = GetComponent<MaterialGenerator>();
        rarGen = GetComponent<RarityGenerator>();
        itmTypGen = GetComponent<ItemTypeGenerator>();
    }

    public void GenerateItem()
    {
        UI.AddItemToLog(itemOutput);
        AssignVariables();
        UI.SetTextColor(rarGen.Color, UI.ItemText);
        itemOutput = String.Format("{0} {1} {2}", rarity, material, itemType);
        UI.UpdateText(itemOutput);
    }

    void AssignVariables()
    {
        itemType = itmTypGen.GetItemType();
        material = matGen.GetMaterial();
        rarity = rarGen.GetRarity();        
    }

    
}
