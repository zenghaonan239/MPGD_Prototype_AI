using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform playertransform;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = playertransform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = playertransform.position - offset;
    }
}
