using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().freezeRotation = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
