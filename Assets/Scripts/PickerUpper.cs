using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerUpper : MonoBehaviour
{
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Pickup")) //if the player collides with an object with a tag "Pickup"
        {
            //destroy the object (we picked it up)
            GameObject.Destroy(collision.collider.gameObject);

            count += 1;

            //play the pickup sound
            this.GetComponent<AudioSource>().Play();

            Debug.Log("Pickup count: " + count);
        }
    }
}
