using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTypeGenerator : MonoBehaviour
{
    [SerializeField] private List<string> itemTypeList;

    private const string itemTypeError0 = "No ItemTypeFound";

    public string GetItemType()
    {
       return GenerateItemType();
    }

    string GenerateItemType()
    {
        if (itemTypeList.Count > 0)
        {
            int index = UnityEngine.Random.Range(0, itemTypeList.Count);
            string item = itemTypeList[index];
            return item;
        }
        else
        {
            Debug.LogError(String.Format("{0}", itemTypeError0));
            return null;
        }
    }
}
