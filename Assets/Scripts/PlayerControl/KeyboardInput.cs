using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    public class KeyboardInput : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                InputManager.Instance.MoveRight = true;
            }
            else
            {
                InputManager.Instance.MoveRight = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                InputManager.Instance.MoveLeft = true;
            }
            else
            {
                InputManager.Instance.MoveLeft = false;
            }
        }
    }
}
