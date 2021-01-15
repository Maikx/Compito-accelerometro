using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.magenta;
    }
    //This colors the floor beneath the player.
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
}
