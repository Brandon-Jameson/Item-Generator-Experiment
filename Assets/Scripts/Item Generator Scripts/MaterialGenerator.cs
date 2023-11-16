using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialGenerator : MonoBehaviour
{
    [SerializeField] private List<string> materialList;

    public string GetMaterial()
    {
        return GenerateMaterial();
    }

    string GenerateMaterial()
    {
        if (materialList.Count > 0)
        {
            int index = Random.Range(0, materialList.Count);
            string material = materialList[index];
            return material;
        }
        else
        {
            Debug.Log("No Material Found!");
            return null;
        }
    }
}
