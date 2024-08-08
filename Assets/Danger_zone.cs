using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger_zone : MonoBehaviour
{
    public Light lt;
    Color color0 = Color.red;
    Color color1 = Color.white;

    float intensity1 = 1.0f;
    float intensity2 = 0.1f;

    public AudioSource background;
    public AudioSource ramla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        Debug.Log("We are in danger!");
        lt.color = color0;
        lt.intensity = intensity1;
        background.Stop();
        ramla.Play();
    }

    void OnTriggerExit(Collider other){
        Debug.Log("We are Safe!");
        lt.color = color1;
        lt.intensity = intensity2;
        ramla.Stop();
        background.Play();
        
    }
}
