using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldConstructor : MonoBehaviour
{

    [SerializeField] private Transform areaCube;
    
    private int[] areaPosition;
    
    void Start()
    {
        LoadField();
    }


    private void LoadField()
    {
        for (int j = 0; j < 20; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                var newCube = Instantiate(areaCube, transform);
                newCube.localPosition = new Vector3(i * 2, 2 * j, 0);
            }
        }
        
    }

    
    
}
