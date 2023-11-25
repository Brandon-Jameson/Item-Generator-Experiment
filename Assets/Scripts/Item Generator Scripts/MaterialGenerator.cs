using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialGenerator : MonoBehaviour
{
    private ItemMaterial[] materialList;
    public ItemMaterial[] MaterialList
    {
        get { return materialList; }
    }
    private float[] materialWeight;
    private ItemMaterial material;
    public ItemMaterial Material
    {
        get { return material; }
    }

    private const string materialError0 = "Material List is empty";
    private const string materialError1 = "Material is null";

    void Start()
    {
        InstanceMaterials();
    }

    void InstanceMaterials()
    {
        materialList = Resources.LoadAll<ItemMaterial>("ItemMaterials/Metals");
    }

    public ItemMaterial GenerateMaterial()
    {
        if (materialList.Length > 0)
        {
            int index = UnityEngine.Random.Range(0, materialList.Length);
            material = materialList[index];
            if (material != null)
            {
                return material;
            }
            else
            {
                Debug.LogError(String.Format($"{materialError1}"));
                return null;
            }
        }
        else
        {
            Debug.LogError(String.Format($"{materialError0}"));
            return null;
        }
    }
}
