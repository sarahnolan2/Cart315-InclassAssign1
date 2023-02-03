using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation1 : MonoBehaviour
{
    public float rotationSpeed;
    

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
        //constant rotation   
        this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);

        //could even make the object bob up and down like a ps1 object using this and changing y axis negation up and down:
        // this.transform.Translate(new Vector3(0,0,0.005f), Space.Self);


    }
}
