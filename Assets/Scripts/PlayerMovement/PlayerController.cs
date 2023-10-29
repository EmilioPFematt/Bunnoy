using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    public float jumpSpeed = 0;    
    public float playerSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Debug.Log("Grounded");
    }

    private bool IsGrounded() {
        return Physics2D.Raycast(transform.position, -transform.up, 0.7f); 
    }

    public void jump(){
        if(IsGrounded()){
            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            Debug.Log("Grounded");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) jump(); 

        int move = (Input.GetKey(KeyCode.D)?1:0) - (Input.GetKey(KeyCode.A)?1:0);
    }
}
