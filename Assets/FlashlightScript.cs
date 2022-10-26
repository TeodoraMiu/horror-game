using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// - lightswitch, lumini in camera
// - stamina
// - fuse box
// - obiecte de adunat
// - baterii pentru inlocuit
// - monstru

public class FlashlightScript : MonoBehaviour
{
    public float battery = 100f;
    private bool isOn = false;

    private int flashlightIntensity = 3;
    // Start is called before the first frame update
    void Start()
    {
        // this.gameObject.transform.GetChild(0).GetComponent<Light>().intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /// Toggle Flashlight
        // TO-DO: make local variable for KeyCode
        if (Input.GetKeyDown(KeyCode.F) && this.gameObject.GetComponent<Renderer>().enabled == true) {
            if (this.gameObject.transform.GetChild(0).GetComponent<Light>().intensity == 0) {
                this.gameObject.transform.GetChild(0).GetComponent<Light>().intensity = flashlightIntensity;
                isOn = true;
            } else {
                this.gameObject.transform.GetChild(0).GetComponent<Light>().intensity = 0;
                isOn = false;
            }
        } 

        /// Battery
        // we check if the flashlight is ON
        if (isOn) {
            if (battery > 0) {
                battery -= 0.005f;
            }
        }
    }
}
