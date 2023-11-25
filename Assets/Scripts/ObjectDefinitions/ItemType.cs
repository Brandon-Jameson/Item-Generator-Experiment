using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemType", menuName = "ItemTypes/New ItemType")]
public class ItemType : ScriptableObject
{
    [SerializeField] private string itemTypeName;
    public virtual string ItemTypeName 
    {
        get { return itemTypeName; }
    }
    [SerializeField] private string itemClass;
    public string ItemClass
    {
        get { return itemClass; }
    }
    [SerializeField] private int baseMaterialCost;
    public virtual float BaseMaterialCost 
    {
        get { return baseMaterialCost; }
    }
    private float itemTypeWeight;
    public virtual float ItemTypeWeight 
    {
        get { return itemTypeWeight; }
        set { itemTypeWeight = value; }
    }
    private float itemTypeValue;
    public virtual float ItemTypeValue 
    {
        get { return itemTypeValue; }
        set { itemTypeValue = value; }
    }
    private float itemTypeDamage;
    public float ItemTypeDamage
    {
        get { return itemTypeDamage; }
        set { itemTypeDamage = value; }
    }
    private float itemTypeArmour;
    public float ItemTypeArmour
    {
        get { return itemTypeArmour; }
        set { itemTypeArmour = value; }
    }
    private ItemMaterial baseMaterial;
    public ItemMaterial BaseMaterial
    {
        get { return baseMaterial; }
        set { baseMaterial = value; }
    }
    // Must be initialized, otherwise first item isn't correctly generated.
    private float rarityModifier = 1; 
    public float RarityModifier
    {
        get { return rarityModifier; }
        set { rarityModifier = value; }
    }

    private const string itemTypeError0 = "BaseMaterial is not set in ItemType.";

    public float CalculateTotalDamage()
    {
        if (baseMaterial != null)
        {
            return Mathf.Round(baseMaterial.MaterialDamage * baseMaterialCost * rarityModifier);
        }
        else
        {
            Debug.LogError(String.Format($"{itemTypeError0}"));
            return 0;
        }
    }

    public float CalculateArmour()
    {
        if (baseMaterial != null)
        {
            return Mathf.Round(baseMaterial.MaterialArmour * baseMaterialCost * rarityModifier);
        }
        else 
        {
            Debug.LogError(String.Format($"{itemTypeError0}"));
            return 0;
        }
    }

    public float CalculateValue()
    {
        if (baseMaterial != null)
        {
            return Mathf.Round(baseMaterial.MaterialValue * baseMaterialCost * rarityModifier); 
        }
        else
        {
            Debug.LogError(String.Format($"{itemTypeError0}"));
            return 0f;
        }
    }

    public float CalculateWeight()
    {
        if (baseMaterial != null && itemClass != "Trinket")
        {
            return Mathf.Round(baseMaterial.MaterialWeight * baseMaterialCost); 
        }
        if (baseMaterial != null && itemClass == "Trinket")
        {
            return Mathf.Round(baseMaterial.MaterialWeight * baseMaterialCost) / 6f; 
        }
        else
        {
            Debug.LogError(String.Format($"{itemTypeError0}"));
            return 0f;
        }
    }

    public float UpdateRarityModifier(ItemRarity rarity)
    {
        return 1 + (rarity.RarityModifier/5);
    }
}
