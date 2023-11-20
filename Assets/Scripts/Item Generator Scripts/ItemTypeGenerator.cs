using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTypeGenerator : MonoBehaviour
{
    private ItemType[] itemTypeList;
    private ItemType item;
    public ItemType Item
    {
        get { return item; }
    }

    private const string itemTypeError0 = "No ItemTypeFound";
    private const string itemTypeError1 = "ItemType is null!";

    void Start()
    {
        InstanceItemTypes();
    }

    void InstanceItemTypes()
    {
        itemTypeList = Resources.LoadAll<ItemType>("ItemTypes");
    }

    public ItemType GetItemType()
    {
       return GenerateItemType();
    }

    ItemType GenerateItemType()
    {
        if (itemTypeList.Length > 0)
        {
            int index = UnityEngine.Random.Range(0, itemTypeList.Length);
            item = itemTypeList[index];

            if (item != null)
            {
                return item;
            }
            else
            {
                Debug.LogError(String.Format($"{itemTypeError1}"));
                return null;
            }
        }
        else
        {
            Debug.LogError(String.Format("{0}", itemTypeError0));
            return null;
        }
    }
}
