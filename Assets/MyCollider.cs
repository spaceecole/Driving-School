using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCollider : MonoBehaviour
{

//     public GameObject Fence;

//     public Vector3 fence_position;
//     public Vector3 offset;
//     public float rotationAngle = 90f;
//     public int countHits = 0;

//     // Start is called before the first frame update
//     void Start()
//     {
//         fence_position = Fence.transform.position;
//         offset = fence_position + new Vector3(0f, 0f, 0f);
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     private void OnCollisionEnter(Collision collision)
//     {
//         if(collision.gameObject.tag == "Fence")
//         {
//             countHits += 1;
//             Debug.Log("The fence has been hit " + countHits + " times!");

//             Quaternion rotation = Quaternion.Euler(0f, rotationAngle, 0f);

//             GameObject newFence = Instantiate(Fence, offset, rotation);


//             Destroy(Fence, 2);

//             Fence = newFence;
//         }
//     }
// }

public int scoreValue = 1;

    private void OnTriggerEnter (Collider other)
    {
        console.log("Coin collided with " + other.gameObject.name);
        
        if (other.gameObject.name == "Fence") {
              console.log("Coin collided with " + other.gameObject.name);
        }

    }
}