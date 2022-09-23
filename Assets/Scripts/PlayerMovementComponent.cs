using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementComponent : MonoBehaviour
{
    ActionMap actionMap;
    [SerializeField] float vitesse = 10f;
    [SerializeField] int jumpHeight = 5;

    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        actionMap = new ActionMap();
        actionMap.PlayerMovement.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (actionMap.PlayerMovement.WASD.inProgress)
        {
            transform.Translate(actionMap.PlayerMovement.WASD.ReadValue<Vector3>() * Time.deltaTime * vitesse);
        }
       
        if (actionMap.PlayerMovement.Run.WasPressedThisFrame())
        {
            vitesse *= 1.5f;
        }
        if (actionMap.PlayerMovement.Run.WasReleasedThisFrame())
        {
            vitesse /= 1.5f;
        }
        if (actionMap.PlayerMovement.Jump.IsPressed())
        {
            if(Grounded())
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
            }
                
        }

        bool Grounded()
        {
            RaycastHit hit;
            Ray landingRay = new Ray(transform.position, Vector3.down);

            if (Physics.Raycast(landingRay, out hit, 2f))
                return true;
            else
                return false;
        }
    }
}
