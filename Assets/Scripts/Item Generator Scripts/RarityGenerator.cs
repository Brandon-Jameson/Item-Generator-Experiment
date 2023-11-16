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

    void Start()
    {
        rarityColorDictionary.Add("Common", "#C8C8C8");  // White
        rarityColorDictionary.Add("Uncommon", "#00FF00");  // Green
        rarityColorDictionary.Add("Rare", "#0078FF");  // Blue
        rarityColorDictionary.Add("Epic", "#B300FF");  // Purple
        rarityColorDictionary.Add("Legendary", "#FFBD00");  // Gold
        rarityColorDictionary.Add("Mythic", "#FF0000");  // Red
    }

    public string GetRarity()
    {
        return GenerateRarity();
    }

    string GenerateRarity()
    {
        if (rarityList.Count > 0)
        {
            int index = Random.Range(0, rarityList.Count);
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
}
