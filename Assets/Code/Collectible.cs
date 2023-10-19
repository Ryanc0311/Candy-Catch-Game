using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectible : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.transform.tag == "Player")
            {
                // Display a message in the console when the collectible is collected.
                Debug.Log("Collectible has been collected!");

                // Destroy the collectible GameObject.
                Destroy(gameObject);
            }
        }

    }

}

