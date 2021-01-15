using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviorFloor : MonoBehaviour
{
    public int rows;
    public int columns;
    public int scale;
    public GameObject gridPrefab;

    public Vector3 leftBottomLocation = new Vector3(0, 0, 0);
    public GameObject[,] gridArray;

    void Awake()
    {
        // This takes the grid prefab and makes a grid.
        gridArray = new GameObject[columns, rows];
        if (gridPrefab)
            GenerateGrid();
        // This warns you if the gridprefab is missing.
        else print("missing gridprefab, please assign.");
    }

    void GenerateGrid()
    {
        // This generates the grid based on the amount of columns and rows set.
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GameObject obj = Instantiate(gridPrefab, new Vector3(leftBottomLocation.x + scale * i, leftBottomLocation.y, leftBottomLocation.z + scale * j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);
                obj.GetComponent<GridStatFloor>().x = i;
                obj.GetComponent<GridStatFloor>().y = j;
                gridArray[i, j] = obj;
            }
        }
    }
}