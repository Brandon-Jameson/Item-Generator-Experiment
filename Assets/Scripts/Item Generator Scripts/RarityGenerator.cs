using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RarityGenerator : MonoBehaviour
{
    private Dictionary<string, string> rarityColorDictionary = new Dictionary<string, string>();
    [SerializeField] private List<string> rarityList;
    private string rarity;
    public string Rarity
    {
        get { return rarity; }
    }
    private string color;
    public string Color
    {
        get { return color; }
    }
    private float[] rarityThreshold;

    private const string rarityError0 = "No Rarity Found";
    private const string rarityError1 = "Rarity {0} not found in dictionary";

    void Start()
    {
        rarityColorDictionary.Add("Common", "#C8C8C8");  // White
        rarityColorDictionary.Add("Uncommon", "#00FF00");  // Green
        rarityColorDictionary.Add("Rare", "#0078FF");  // Blue
        rarityColorDictionary.Add("Epic", "#B300FF");  // Purple
        rarityColorDictionary.Add("Legendary", "#FFBD00");  // Gold
        rarityColorDictionary.Add("Mythic", "#FF0000");  // Red

        rarityThreshold = new float[]{ 0.55f, 0.27f, 0.11f, 0.05f, 0.014f, 0.006f };
    }

    public string GetRarity()
    {
        return GenerateRarity();
    }

    string GenerateRarity()
    {
        if (rarityList.Count > 0)
        {
            int index = GetRarityIndex();
            rarity = rarityList[index];
            color = GetHexColor(rarity);
            return rarity;
        }
        else
        {
            Debug.LogError(String.Format("{0}", rarityError0));
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
