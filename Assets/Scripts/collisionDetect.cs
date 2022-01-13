using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetect : MonoBehaviour
{
    private int index;

    public GameObject WinUI;

    void Start()
    {
        index = SceneManager.GetActiveScene().buildIndex;// get index of current scene
    }

  
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag == "Guard")
        {
            
            SceneManager.LoadScene(index);//reload current scene
        }

        if (collision.transform.tag == "Door")
        {
            WinUI.SetActive(true);
        }
    }



}
