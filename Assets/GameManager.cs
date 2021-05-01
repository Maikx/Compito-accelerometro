using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[] m_Cubes;
    public int colorTiles;

    private void Start()
    {
        m_Cubes = GameObject.FindGameObjectsWithTag("Floor");
    }

    void Update()
    {
        int amount = 0;

        //for (int i = 0; i < m_Cubes.Length; i++)
        //{
            //if (m_Cubes[i].GetComponent<Renderer>().material.color == Color.magenta)
            //{
                //amount++;
            //}
        //}

        if (amount >= colorTiles)
        {
            Debug.Log("You win");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color color = Color.magenta;
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Floor");
            foreach (GameObject go in objects)
            {
                MeshRenderer[] renderers = go.GetComponentsInChildren<MeshRenderer>();
                foreach (MeshRenderer r in renderers)
                {
                    foreach (Material m in r.materials)
                    {
                        if (m.HasProperty("_Color"))
                            m.color = color;
                    }
                }
            }
        }
    }
}
