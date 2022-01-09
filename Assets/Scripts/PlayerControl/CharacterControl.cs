using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float Speed;
    public Animator animator;

    void Update()
    {
        if (InputManager.Instance.MoveRight && InputManager.Instance.MoveLeft)
        {
            animator.SetBool("Move", false);
            return;
        }

        if (!InputManager.Instance.MoveRight && !InputManager.Instance.MoveLeft)
        {
        animator.SetBool("Move", false);
        }

        if (InputManager.Instance.MoveRight)
        {
            this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            animator.SetBool("Move", true);
        }

        if (InputManager.Instance.MoveLeft)
        {
            this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            animator.SetBool("Move", true);
        }
    }
}
