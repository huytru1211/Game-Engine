using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

        


    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            Debug.Log(" 5 second passed");
            renderer.enabled = true;
            rigidbody.useGravity=true;

        }


    } 
}
