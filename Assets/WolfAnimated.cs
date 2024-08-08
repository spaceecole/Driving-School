using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WolfAnimated : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("b")){
            anim.Play("breathes");
        }
        if (Input.GetKey("g")){
            anim.Play("attack2");
        }
        if (Input.GetKey("h")){
            anim.Play("Digs");
        }
        if (Input.GetKey("y")){
            anim.Play("walk");
        }
        
    }
}
