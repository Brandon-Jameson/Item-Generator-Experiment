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
            int index = GetRarityValue();
            rarity = rarityList[index];
            color = GetHexColor(rarity);
            return rarity;
        }
        else
        {
            Debug.Log("No Rarity Found");
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
            Debug.LogError($"Rarity {rarity} not found in dictionary");
            return "#000000";
        }
    }

    int GetRarityValue()
    {
        float randomValue = Random.value;
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
