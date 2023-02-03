using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
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
        //when following, we also want the thing to look at the target:
        this.GetComponent<Transform>().LookAt(target.transform);

        //follow the target
        //Space.self is used because the thing is looking at the player, and we can move forward in the relative space/local axis of z
        //doesn't use physics so goes through walls
        this.transform.Translate(new Vector3(0,0,0.005f), Space.Self);


        //"this." is optional, transform is already pointing to this object, it's just to demonstrate where it's coming from
    }
}
