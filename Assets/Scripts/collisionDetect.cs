using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag == "Guard")
        {
            int index = SceneManager.GetActiveScene().buildIndex;// get index of current scene
            SceneManager.LoadScene(index);//reload current scene
        }
     }
}
