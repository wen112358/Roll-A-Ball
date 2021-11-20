using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rigidbody;
    void Start(){
        rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

        rigidbody.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        // Destroy(other.gameObject);
        if(other.gameObject.CompareTag("Pick Up")){
            other.gameObject.SetActive(false);
        }
    }
}
