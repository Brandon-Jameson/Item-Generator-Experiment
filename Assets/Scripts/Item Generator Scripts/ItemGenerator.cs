using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemGenerator : MonoBehaviour
{
    private string rarityStr;
    private string materialStr;
    private string itemTypeStr;
    private MaterialGenerator matGen;
    private RarityGenerator rarGen;
    private ItemTypeGenerator itmTypGen;
    private ItemMaterial material;
    private ItemType itemType;
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
        itemOutput = String.Format($"{rarityStr} {materialStr} {itemTypeStr}");
        UI.UpdateText(itemOutput);
    }

    void AssignVariables()
    {
        itemType = itmTypGen.GetItemType();
        material = matGen.GetMaterial();
        itemTypeStr = itmTypGen.Item.ItemTypeName;
        materialStr = matGen.Material.MaterialName;
        rarityStr = rarGen.GetRarity();        
    }
}