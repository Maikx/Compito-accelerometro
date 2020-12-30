using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStatFloor : MonoBehaviour
{
    //public int visited = -1;
    public int x = 0;
    public int y = 0;

    private void Update()
    {
        if(x == 1 && y == 8)
            gameObject.SetActive(false);
    }
}

