using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehavior : MonoBehaviour
{
    public int rows;
    public int columns;
    public int scale;
    [SerializeField] GameObject gridPrefabFloor;
    [SerializeField] GameObject gridPrefabWall;

    public Vector3 leftBottomLocationFloor = new Vector3(0, 0, 0);
    public Vector3 leftBottomLocationWall = new Vector3(0, 0, 0);
    public GameObject[,] gridArray;

    void Awake()
    {
        GridFloorAwake();
        GridWallsAwake();
    }

    void GridFloorAwake()
    {
        // This takes the grid prefab and makes a grid.
        gridArray = new GameObject[columns, rows];
        if (gridPrefabFloor)
            GenerateGridFloor();
        // This warns you if the gridprefab is missing.
        else print("missing Floorprefab, please assign.");
    }

    void GridWallsAwake()
    {
        // This takes the grid prefab and makes a grid.
        gridArray = new GameObject[columns, rows];
        if (gridPrefabWall)
            GenerateGridWall();
        // This warns you if the gridprefab is missing.
        else print("missing Wallprefab, please assign.");
    }

    void GenerateGridFloor()
    {
        // This generates the grid based on the amount of columns and rows set.
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GameObject obj = Instantiate(gridPrefabFloor, new Vector3(leftBottomLocationFloor.x + scale * i, leftBottomLocationFloor.y, leftBottomLocationFloor.z + scale * j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);
                obj.GetComponent<GridStatFloor>().x = i;
                obj.GetComponent<GridStatFloor>().y = j;
                gridArray[i, j] = obj;
            }
        }
    }

    void GenerateGridWall()
    {
        // This generates the grid based on the amount of columns and rows set.
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GameObject obj = Instantiate(gridPrefabWall, new Vector3(leftBottomLocationWall.x + scale * i, leftBottomLocationWall.y, leftBottomLocationFloor.z + scale * j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);
                obj.GetComponent<GridStatWalls>().x = i;
                obj.GetComponent<GridStatWalls>().y = j;
                gridArray[i, j] = obj;
            }
        }
    }
}