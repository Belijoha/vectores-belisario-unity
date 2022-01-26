using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{ 
    public float speedToLook = 3;
    [SerializeField]public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         LookAtPLayer3();
    }
    private void LookAtPLayer3()
    {
        Quaternion newRotation= Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);
    }
   
}