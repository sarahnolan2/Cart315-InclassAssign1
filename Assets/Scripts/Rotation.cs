using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed;

    private bool rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check inputs to enable and disable rotations
        if(Input.GetKey(KeyCode.R)) //old input system 
        {
            //Debug.Log("R was pressed");
            rotate = true;
        }
        else
        {
            rotate = false;
        }
    }

    void FixedUpdate()
    {
        if (rotate) //only rotate if this is true
        {
            this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
        }
        
    }
}
