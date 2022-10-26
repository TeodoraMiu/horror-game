using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private Transform currentSelection;
    private GameObject flashlight;

    void Start() 
    {
        flashlight = GameObject.Find("FlashlightEquipped");

        // Start with equipped flashlight and spotlight invisible
        flashlight.GetComponent<Renderer>().enabled = false;
        flashlight.transform.Find("FlashlightSpotlight").GetComponent<Light>().intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            var selection = hit.transform;
            if (Input.GetKeyDown(KeyCode.E)) {

                if (selection.name == "Flashlight") {
                    // The player picked up the flashlight
                    selection.gameObject.SetActive(false);
                    flashlight.GetComponent<Renderer>().enabled = true;
                }
                
                else if (selection.name == "Battery") {
                    // The player picked up a battery and refilled 50% of the flashlight's battery
                    selection.gameObject.SetActive(false);
                    flashlight.GetComponent<FlashlightScript>().battery += 50;
                    if (flashlight.GetComponent<FlashlightScript>().battery > 100) {
                        flashlight.GetComponent<FlashlightScript>().battery = 100;
                    }
                }
            }
        }
    }
}
