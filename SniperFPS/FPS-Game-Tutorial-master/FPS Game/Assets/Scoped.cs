using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoped : MonoBehaviour
{

    public Camera camName;
    public GameObject scoperi;
    public float scopedFov = 10f;
    public float defaultFOv = 60f;


    void Start()
    {
        
    }
    void Update()
    {
         if (Input.GetKey(KeyCode.Mouse1))
        {
            scoperi.SetActive(true);
            camName.fieldOfView = scopedFov;
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            scoperi.SetActive(false);
            if (scoperi == false)
            {
                scoperi.SetActive(true);
            }
            camName.fieldOfView = defaultFOv;
        }
        
            
    
    }

    //make an app that allows you to chat in online using photon pun and unity 



}

 
