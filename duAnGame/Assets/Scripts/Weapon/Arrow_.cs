using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_ : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider boxC;
    bool disableRotation;

    AudioSource arrowAudio;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        boxC = GetComponent<BoxCollider>();
        arrowAudio = GetComponent<AudioSource>();
        Destroy(gameObject, 7f);
    }
    void Update()
    {
        if(!disableRotation)
            transform.rotation = Quaternion.LookRotation(rb.velocity);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            //arrowAudio.Play();
            disableRotation = true;
            rb.isKinematic = true;
            boxC.isTrigger = true;
        } 
    }
}
