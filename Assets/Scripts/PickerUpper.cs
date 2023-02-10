using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerUpper : MonoBehaviour
{
    public int count = 0;

    public GameObject particlePrefab;

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
            //instantiate our particle system for feedback on pickup
            GameObject.Instantiate(particlePrefab, collision.collider.gameObject.transform.position, Quaternion.identity);

            //destroy the object (we picked it up)
            GameObject.Destroy(collision.collider.gameObject);

            count += 1;

            //play the pickup sound
            this.GetComponent<AudioSource>().Play();

            Debug.Log("Pickup count: " + count);
        }
    }
}
