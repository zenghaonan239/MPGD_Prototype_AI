using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public GameObject ReturnUI;
    public GameObject SettingUI;
    public GameObject StartUI;
    public GameObject needKeyUI;
    public GameObject FindKeyUI;
    public GameObject FindClothesUI;

    public void onTutorial()
    {
        SceneManager.LoadScene(1);//load tutorial scene 
    }

    public void onStart()
    {
        StartUI.SetActive(true);//when press start button
    }

    public void onMap1()
    {
        SceneManager.LoadScene(3);//load map1
    }

    public void onMap2()
    {
        SceneManager.LoadScene(4);//load map2
    }

    public void onReturnFromStart()//when press return button 
    {
        StartUI.SetActive(false);
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
        SceneManager.LoadScene(0);//load main menu scene 
    }

    public void onSetting()//when press return button 
    {
        SettingUI.SetActive(true);
    }

    public void onReturnFromSetting()//when press return button 
    {
        SettingUI.SetActive(false);
    }

    public void onNeedKeyOKbutton()
    {
        needKeyUI.SetActive(false);
    }

    public void onFindKeyOKbutton()
    {
        FindKeyUI.SetActive(false);
    }

    public void onFindClothesOKbutton()
    {
        FindClothesUI.SetActive(false);
    }
}
