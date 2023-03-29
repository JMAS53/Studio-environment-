using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnFaceCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // This function is called when the mask object collides with the controller object
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object that we collided with is tagged as "controller"
        if (collision.gameObject.tag == "controller")
        {
            // Get the object that is tagged as "Face"
            GameObject face = GameObject.FindWithTag("Face");

            // Add a CapsuleCollider component to the "Face" object if it exists
            if (face != null) 
            {
                face.AddComponent<CapsuleCollider>();
            }
        }
    }
}
