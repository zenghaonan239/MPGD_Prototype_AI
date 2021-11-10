using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputSystem : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private Transform transform;
    //public MyControls inputAction;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();

       // inputAction = new MyControls();
       // inputAction.Enable();

       // inputAction.Player.Move2.performed += ctx =>
      //  {
       //     transform.Translate(context.ReadValue<Vector2>().x / 5, 0, 0);
       // };
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("JUMP" + context.phase);
        if (context.performed)
        {
            Debug.Log("JUMP"+context.phase);
            playerRigidbody.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }
        
    }

    public void MoveLeft(InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);
        if (context.started) ;
        {
            playerRigidbody.AddForce(Vector3.right *5* context.ReadValue<Vector2>().x, ForceMode.Impulse);
            //transform.Translate(context.ReadValue<Vector2>().x /5, 0, 0);    
        }
        
        Debug.Log(context.ReadValue<Vector2>());
        //transform.Translate(context.ReadValue<Vector2>().x/2, 0, 0);

        
        //if (context.performed)
        // {
        //    playerRigidbody.AddForce(Vector3.left * 5f, ForceMode.Impulse);
        //   // transform.Translate(Vec3[-0.1, 0.0, 0.0]);
        //}
    }

    //public void MoveRight(InputAction.CallbackContext context)
    //{
    //    if (context.performed)
    //    {
    //        playerRigidbody.AddForce(Vector3.right * 5f, ForceMode.Impulse);
    //    }
    //    
    //}

   // public void Update()
   // {
       //InputAction.CallbackContext context;
        //transform.Translate(context.ReadValue<Vector2>().x, 0, 0);
   // }


}
