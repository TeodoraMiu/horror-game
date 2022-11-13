using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public GameObject lightSource;
    public float lightIntensity;

    public void toggleLight() {
        if (lightSource.GetComponent<Light>().intensity == 0) {
            lightSource.GetComponent<Light>().intensity = lightIntensity;
        } else {
            lightSource.GetComponent<Light>().intensity = 0;
        }
    }
}
