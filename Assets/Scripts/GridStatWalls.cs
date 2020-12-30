using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStatWalls : MonoBehaviour
{
    //public int visited = -1;
    public int x = 0;
    public int y = 0;

    private void Update()
    {
        RemoveWall();
    }

    private void RemoveWall()
    {
        if (x < 9 && y < 9 && y != 0 && x != 0)
        {
            gameObject.SetActive(false);
            if (x != 1 && x != 2 && y == 3 || x != 7 && x != 8 && y == 6)
                gameObject.SetActive(true);
        }
    }
}
