using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{
  public  float moveSpeed =1;  
    void Start()
    {
        
    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * h * moveSpeed);
    }
}
