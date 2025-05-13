using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int damageAmount = 20;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 7);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if(other.tag == "DragonNightMare")
        {
            transform.parent = other.transform;
            //other.GetComponent<NightMare>().TakeDamage(damageAmount);
        }
    }
}
