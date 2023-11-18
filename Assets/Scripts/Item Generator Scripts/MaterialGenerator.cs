using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialGenerator : MonoBehaviour
{
    private List<ItemMaterial> materialList = new List<ItemMaterial>();
    private float[] materialWeight;

    private const string materialError0 = "Material List is empty";
    private const string materialError1 = "Material is null";

    void Start()
    {
        InstanceMaterials();
    }

    void InstanceMaterials()
    {
        CopperMaterial copperMaterial = ScriptableObject.CreateInstance<CopperMaterial>();
        IronMaterial ironMaterial = ScriptableObject.CreateInstance<IronMaterial>();
        SteelMaterial steelMaterial = ScriptableObject.CreateInstance<SteelMaterial>();
        InvarMaterial invarMaterial = ScriptableObject.CreateInstance<InvarMaterial>();
        HighAlloyMaterial highAlloyMaterial = ScriptableObject.CreateInstance<HighAlloyMaterial>();
        ValeriumMaterial valeriumMaterial = ScriptableObject.CreateInstance<ValeriumMaterial>();
        PhariumMaterial phariumMaterial = ScriptableObject.CreateInstance<PhariumMaterial>();
        MaleveriumMaterial maleveriumMaterial = ScriptableObject.CreateInstance<MaleveriumMaterial>();
        materialList.Add(copperMaterial);
        materialList.Add(ironMaterial);
        materialList.Add(steelMaterial);
        materialList.Add(invarMaterial);
        materialList.Add(highAlloyMaterial);
        materialList.Add(valeriumMaterial);
        materialList.Add(phariumMaterial);
        materialList.Add(maleveriumMaterial);

        materialWeight = new float[]{ 0f, 0.39f, 0.23f, 0.12f, 0.11f, 0.08f, 0.05f, 0.02f };
    }

    public string GetMaterial()
    {
        return GenerateMaterial();
    }

    string GenerateMaterial()
    {
        if (materialList.Count > 0)
        {
            int index = GetMaterialIndex();
            ItemMaterial material = materialList[index];
            if (material != null)
            {
                string materialName = material.MaterialName;
                return materialName;
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

    int GetMaterialIndex()
    {
        float randomValue = UnityEngine.Random.value;
        int selectedMaterialIndex = 1;
        for (int i = 0; i < materialWeight.Length; i++)
        {
            if (randomValue >= materialWeight[i])
            {
                selectedMaterialIndex = i;
                break;
            }
        }
        return selectedMaterialIndex;
    }
}
