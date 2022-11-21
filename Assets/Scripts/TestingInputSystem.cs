using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour


{
    private PlayerInputActions playerInputActions;

    private PlayerInput playerInput;
    private Rigidbody rb;

    private void Awake () {
    
  

    

    rb = GetComponent<Rigidbody>(); 

    playerInput = GetComponent<PlayerInput>();
        PlayerInputActions playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed +=Jump;
        playerInputActions.Player.Movement.performed += Movement_performed;
        
        }

        private void Update () {

            Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2> ();





        }

    private void PlayerInput_onActionTriggered(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    public void Jump(InputAction.CallbackContext context) {
            
            Debug.Log(context);


        Debug.Log ("Jump" + context.phase);

     rb.AddForce(Vector3.up * 5f, ForceMode.Force);
}
    

    private void Movement_performed(InputAction.CallbackContext context){
        Debug.Log(context);

        context.ReadValue<Vector2> ();
        Vector2 inputVector = context.ReadValue<Vector2> (); 

        float speed = 5f; 
        
        rb.AddForce(new Vector3(inputVector. x, 0, inputVector.y * speed), ForceMode.Force); 
         

        }
        
         

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
}
