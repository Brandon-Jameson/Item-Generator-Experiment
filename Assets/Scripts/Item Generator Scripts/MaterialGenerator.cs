using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialGenerator : MonoBehaviour
{
    [SerializeField] private List<string> materialList;

    private const string materialError0 = "No Material Found";

    public string GetMaterial()
    {
        return GenerateMaterial();
    }

    string GenerateMaterial()
    {
        if (materialList.Count > 0)
        {
            int index = UnityEngine.Random.Range(0, materialList.Count);
            string material = materialList[index];
            return material;
        }
        else
        {
            Debug.LogError(String.Format("{0}", materialError0));
            return null;
        }
    }
}
