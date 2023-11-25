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
    public ItemMaterial Material
    {
        get { return material; }
        set { material = value; }
    }
    private ItemRarity rarity;
    public ItemRarity Rarity
    {
        get { return rarity; }
    }
    private ItemType itemType;
    public ItemType ItemType
    {
        get { return itemType; }
    }
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
        UI.SetTextColor(rarity.RarityColor, UI.ItemText);
        itemOutput = String.Format($"{rarityStr} {materialStr} {itemTypeStr}");
        UI.UpdateText(itemOutput);
    }

    void AssignVariables()
    {
        material = matGen.GenerateMaterial();
        itemType = itmTypGen.GenerateItemType(material);
        rarity = rarGen.GenerateRarity();
        materialStr = material.MaterialName;
        itemTypeStr = itemType.ItemTypeName;
        rarityStr = rarity.RarityName;
        itemType.RarityModifier = itemType.UpdateRarityModifier(rarity);
        UpdateItemValues();
    }

    void UpdateItemValues()
    {
        switch (itemType.ItemClass)
        {
            case "Weapon":
                itemType.ItemTypeDamage = itemType.CalculateTotalDamage();
                itemType.ItemTypeValue = itemType.CalculateValue();
                itemType.ItemTypeWeight = itemType.CalculateWeight();
            break;
            case "Trinket":
                itemType.ItemTypeValue = itemType.CalculateValue();
                itemType.ItemTypeWeight = itemType.CalculateWeight();
            break;
            case "Armour":
                itemType.ItemTypeArmour = itemType.CalculateArmour();
                itemType.ItemTypeValue = itemType.CalculateValue();
                itemType.ItemTypeWeight = itemType.CalculateWeight();
            break;
        }
        
    }
}