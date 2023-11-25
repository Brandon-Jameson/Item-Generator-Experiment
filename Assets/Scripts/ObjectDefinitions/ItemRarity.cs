using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemRarity", menuName = "ItemRarities/New ItemRarity")]
public class ItemRarity : ScriptableObject
{
    [SerializeField] private string rarityName;
    public string RarityName
    {
        get { return rarityName; }
    }
    [SerializeField] private float rarityWeight;
    public float RarityWeight
    {
        get { return rarityWeight; }
    }
    [SerializeField] private float rarityModifier;
    public float RarityModifier
    {
        get { return rarityModifier; }
    }
    [SerializeField] private string rarityColor;
    public string RarityColor 
    {
        get { return rarityColor; }
    }
}
