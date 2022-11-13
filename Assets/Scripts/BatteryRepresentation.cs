using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryRepresentation : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        GameObject flashlight = GameObject.Find("FlashlightEquipped");
        if (flashlight.GetComponent<Renderer>().enabled == true) {
            this.gameObject.GetComponent<UnityEngine.UI.Text>().text = "Battery " + (int)flashlight.GetComponent<FlashlightScript>().battery + "%";
        }
    }
}
