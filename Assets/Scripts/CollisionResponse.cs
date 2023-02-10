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
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0,100.0f,0)); //adds bounciness

        //only work when it collides with the player
        if(collision.collider.gameObject == target) //looking at the collider from the other collider we collided with
        {
            //shooting it in the up direction -> y axis
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0,200.0f,0));


            //shooting it forward from the target (player or anything)

            // we will find the vector position of both objects and add them together 
            // we can also subtract from the resulting vector to get a vector going to the opposite direction

            Vector3 force = this.transform.position - collision.collider.gameObject.transform.position; //define a force

            force.Normalize(); //means that we reduce the length to 1. 
            //so we do this when we want the vector or all vectors to have the same magnitude 
            // and only care about the direction

            force *= 200.0f;

            this.GetComponent<Rigidbody>().AddForce(force);

            
        }

            //what if we wanted to have it bounce off walls?
            // we can use the slope physics to bounce very realistically highly 
            // but give it max bounciness and a very high bounciness level

   
    }
}
