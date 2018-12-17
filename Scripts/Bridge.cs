using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { // if player entered the trigger...
            GetComponent<Rigidbody>().useGravity = true; // turn gravity on
            GetComponent<Rigidbody>().isKinematic = false;// turn kinematic off


            //audio.PlayOneShot(audio.clip, 1.0f); // if player entered the trigger play audio...



            //Destroy(gameObject, 5.0f); // if player entered the trigger destroy after 5 sec...
        }
    }
}