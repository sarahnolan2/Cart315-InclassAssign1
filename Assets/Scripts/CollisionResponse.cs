using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResponse : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //shooting it in the up direction -> y axis
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0,100.0f,0));

        //only work when it collides with the player
        if(collision.collider.gameObject == target) //looking at the collider from the other collider we collided with
        {
            //shooting it in the up direction -> y axis
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0,200.0f,0));
        }
    }
}
