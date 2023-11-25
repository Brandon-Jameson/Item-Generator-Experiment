using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RarityGenerator : MonoBehaviour
{
    private Dictionary<string, string> rarityColorDictionary;
    private ItemRarity[] rarityList;
    private ItemRarity rarity;
    private string color;
    private float[] rarityThreshold;

    private const string rarityError0 = "No Rarity Found";
    private const string rarityError1 = "Rarity {0} not found in dictionary";

    void Start()
    {
        rarityList = Resources.LoadAll<ItemRarity>("ItemRarities");
        rarityColorDictionary = new Dictionary<string, string>();
        rarityColorDictionary.Add(rarityList[0].RarityName, rarityList[0].RarityColor);  // White
        rarityColorDictionary.Add(rarityList[1].RarityName, rarityList[1].RarityColor);  // Green
        rarityColorDictionary.Add(rarityList[2].RarityName, rarityList[2].RarityColor);  // Blue
        rarityColorDictionary.Add(rarityList[3].RarityName, rarityList[3].RarityColor);  // Purple
        rarityColorDictionary.Add(rarityList[4].RarityName, rarityList[4].RarityColor);  // Gold
        rarityColorDictionary.Add(rarityList[5].RarityName, rarityList[5].RarityColor);  // Red

        rarityThreshold = new float[]{ rarityList[0].RarityWeight, rarityList[1].RarityWeight,
                                       rarityList[2].RarityWeight, rarityList[3].RarityWeight,
                                       rarityList[4].RarityWeight, rarityList[5].RarityWeight };
    }

    public ItemRarity GenerateRarity()
    {
        if (rarityList.Length > 0)
        {
            int index = GetRarityIndex();
            rarity = rarityList[index];
            color = GetHexColor(rarity.RarityName);
            return rarity;
        }
        else
        {
            Debug.LogError(String.Format($"{rarityError0}"));
            return null;
        }
    }

    string GetHexColor(string rarity)
    {
        if (rarityColorDictionary.ContainsKey(rarity))
        {
            return rarityColorDictionary[rarity];
        }
        else
        {
            Debug.LogError(String.Format(rarityError1, rarity));
            return "#000000";
        }
    }

    int GetRarityIndex()
    {
        float randomValue = UnityEngine.Random.value;
        int selectedRarityIndex = 0;
        for (int i = 0; i < rarityThreshold.Length; i++)
        {
            if (randomValue >= rarityThreshold[i])
            {
                selectedRarityIndex = i;
                break;
            }
        }
        return selectedRarityIndex;
    }
}
