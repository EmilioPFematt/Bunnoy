using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public GravityOrbit Gravity; 
    private Rigidbody2D Rb;

    public float RotationSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Gravity){
            Vector2 gravityUp = Vector2.zero;
            gravityUp = (transform.position - Gravity.transform.position).normalized;

            Vector2 localUp = transform.up;

            Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * transform.rotation;

            transform.up = Vector2.Lerp(transform.up, gravityUp, RotationSpeed*Time.deltaTime);

            Rb.AddForce(-gravityUp * Gravity.Gravity * Rb.mass);
        }   
    }
}
