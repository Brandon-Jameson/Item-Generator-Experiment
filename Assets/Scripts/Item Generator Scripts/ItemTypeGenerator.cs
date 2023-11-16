using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTypeGenerator : MonoBehaviour
{
    [SerializeField] private List<string> itemTypeList;

    public string GetItemType()
    {
       return GenerateItemType();
    }

    string GenerateItemType()
    {
        if (itemTypeList.Count > 0)
        {
            int index = Random.Range(0, itemTypeList.Count);
            string item = itemTypeList[index];
            return item;
        }
        else
        {
            Debug.Log("No ItemType Found!");
            return null;
        }
    }
}
