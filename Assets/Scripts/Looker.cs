using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
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

    void FixedUpdate()
    {
        //We want to get the cylinder to look at the player:

        //takes the transform of the game object and says to look at that location
        //In the local view of the cylinder, whatever face is facing the blue axis is what is going to look at the object
        this.GetComponent<Transform>().LookAt(target.transform);

        
        //we can use this to have people look at the player when we enter a dialogue script
        

    }
}
