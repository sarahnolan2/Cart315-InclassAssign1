using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupUI : MonoBehaviour
{
    public PickerUpper player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We can put UI stuff in update
        this.GetComponent<TextMeshProUGUI>().text = "Pickup Count: "+player.count;
    }
}
