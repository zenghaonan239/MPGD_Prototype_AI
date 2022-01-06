using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public GameObject ReturnUI;
    public GameObject SettingUI;

    public void onTutorial()
    {
        SceneManager.LoadScene(0);//load tutorial scene 
    }

    public void onStart()
    {
        SceneManager.LoadScene(2);//load Game scene 
    }


    public void onReturn()//when press return button 
    {
        ReturnUI.SetActive(true);
    }

    public void onResume()//when press resume button
    {
        ReturnUI.SetActive(false);
    }

    public void onReturnToMain()//go back to main menu
    {
        SceneManager.LoadScene(1);//load main menu scene 
    }

    public void onSetting()//when press return button 
    {
        SettingUI.SetActive(true);
    }

    public void onReturnFromSetting()//when press return button 
    {
        SettingUI.SetActive(false);
    }


}
