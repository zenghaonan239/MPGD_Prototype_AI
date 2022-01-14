using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetect : MonoBehaviour
{
    private int index;
    private bool hasKey;
    private bool hasClothes;

    public GameObject WinUI;
    public GameObject needKeyUI;
    public GameObject FindKeyUI;
    public GameObject FindClothesUI;
    public GameObject Key;
    public GameObject GuardClothes;
   

    void Start()
    {
        index = SceneManager.GetActiveScene().buildIndex;// get index of current scene
        hasKey = false;
        hasClothes = false;
    }

  
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {

        if (collision.transform.tag == "Guard Clothes")
        {
            FindClothesUI.SetActive(true);
            GuardClothes.SetActive(false);
            hasClothes = true;
        }
                
        if (collision.transform.tag == "Guard")
        {
            if (hasClothes)
                return;
            else
                SceneManager.LoadScene(index);//reload current scene
        }

        if (collision.transform.tag == "Key")
        {
            FindKeyUI.SetActive(true);
            Key.SetActive(false);
            hasKey = true;
        }
        

        if (collision.transform.tag == "Door")
        {
            if (hasKey)
                WinUI.SetActive(true);
            else
                needKeyUI.SetActive(true);
        }
    }




}
