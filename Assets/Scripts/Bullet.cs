using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Rigidbody>().WakeUp();
        Invoke("HideBullet",2f);
    }

    void HideBullet()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
        GetComponent<Rigidbody>().Sleep();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
       
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }

        gameObject.SetActive(false);
    }
}
