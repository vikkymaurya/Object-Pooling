using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float bulletSpeed;

    AudioSource audioSource;
    ObjectPooler objectPooler;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        objectPooler = ObjectPooler.Instance;
    }

 
    void Update()
    {
     if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject obj= objectPooler.ObjectFromPool();
        obj.transform.position = transform.position;
        obj.transform.rotation = Quaternion.identity;
        obj.SetActive(true);
        Rigidbody rd = obj.GetComponent<Rigidbody>();
        rd.AddForce(Vector3.forward * bulletSpeed);

        audioSource.Play();

        //GameObject obj = Instantiate(bullet, transform.position, Quaternion.identity);
        //Rigidbody rd = obj.GetComponent<Rigidbody>();
        //rd.AddForce(Vector3.forward * bulletSpeed);
        //Destroy(obj, 1f);


    }
}
