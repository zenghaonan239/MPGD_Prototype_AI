using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Transform player;
    public Transform guard1, guard2, guard3;
    public Transform destination;
    public Text winText;


    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position, guard1.position) <= 1.5f)
        {
            Fail();
        }

        if (Vector3.Distance(player.position, guard2.position) <= 1.5f)
        {
            Fail();
        }

        if (Vector3.Distance(player.position, guard3.position) <= 1.5f)
        {
            Fail();
        }

        if (Vector3.Distance(player.position, destination.position) <= 1.0f)
        {
            Win();
        }

    }

    public void Win()
    {
        /*SceneManager.LoadScene(0);*/
        winText.text = "Congratulations!";
    }

    public void Fail()
    {
        SceneManager.LoadScene(0);
    }
}
