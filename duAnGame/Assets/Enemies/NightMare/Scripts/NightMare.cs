using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightMare : MonoBehaviour
{
    public float HP = 100f;
    public Animator animator;

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <=0)
        {
            AudioManager.instance.Play("DragonDeath");
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 7f);
        }
        else
        {
            AudioManager.instance.Play("DragonHurt");
            animator.SetTrigger("damage");
        }

    }
    
}
