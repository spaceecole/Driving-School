// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class followCar : MonoBehaviour
// {
//     public GameObject atachedVehicle;
//     private GameObject CameraFolder;
//     private Transform camLocation;
//     private float locationIndicator;

//     [SerializeField] GameObject car;
//     // Start is called before the first frame update
//     void Start()
//     {
//         attachedVehicle =GameObject.FindGameObjectWithTag("Player");
//         CameraFolder = attachedVehicle.transform.Find("CAMERA").gameObject;
//         camLocations = CameraFolder.GetComponentsInChildren<Transform>();

        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.Tab)){
//         if(locationIndicator>= 4 || locationIndicator < 2)locationIndicator =2;
//          }
//     }
// }
