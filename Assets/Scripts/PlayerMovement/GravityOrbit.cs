using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOrbit : MonoBehaviour
{
    public float Gravity;
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Collision");
        if(other.GetComponent<GravityController>()){
            other.GetComponent<GravityController>().Gravity = GetComponent<GravityOrbit>();
        }
    }
}
