using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed;

    private bool rotate;

    public PickerUpper player;
    //^ now we have access to count variable

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
        //if there is no player defined
        if(player != null)
        {
            //only rotate if this is true
            //if we pressed R
            // and if we have picked up more than 3 objects
            if (rotate && player.count >= 3)
            {

                this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
                //can now create cases for stuff to happen one after the other (pickup thing, open blocked path, etc)
            }
        }
        else //if there's no player defined (no reference to the player)
        {
            this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
            //this allows us to still have a case if we forget to assign reference, in this case we still rotate
        }
        
        
    }
}
