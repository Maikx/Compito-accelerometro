using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Material c_magenta;
    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = c_magenta;
    }
    //This colors the floor beneath the player.
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            col.gameObject.GetComponent<Renderer>().material = c_magenta;
        }
    }
}
