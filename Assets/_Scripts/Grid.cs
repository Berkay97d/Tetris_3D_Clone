using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private Vector3 m_GridSize = Vector3.one;
    public int xIndex;
    public int yIndex;
    public bool isFull = false;

    
    public Vector3 GetGridSize()
    {
        return m_GridSize;
    }
}
