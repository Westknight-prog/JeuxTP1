using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementComponent : MonoBehaviour
{
    ActionMap actionMap;
    [SerializeField] float vitesse = 10f;
    [SerializeField] int jumpHeight = 10;

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
        if (actionMap.PlayerMovement.Forward.IsPressed())
        {
            transform.Translate(Vector3.forward * Time.deltaTime * vitesse);
        }
        if (actionMap.PlayerMovement.Backward.IsPressed())
        {
            transform.Translate(Vector3.back* Time.deltaTime * vitesse);
        }
        if (actionMap.PlayerMovement.Right.IsPressed())
        {
            transform.Translate(Vector3.right * Time.deltaTime * vitesse);
        }
        if (actionMap.PlayerMovement.Left.IsPressed())
        {
            transform.Translate(Vector3.left * Time.deltaTime * vitesse);
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
                transform.Translate(new Vector3(0, jumpHeight, 0) * Time.deltaTime);
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
