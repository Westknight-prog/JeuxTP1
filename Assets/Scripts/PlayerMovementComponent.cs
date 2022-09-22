using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementComponent : MonoBehaviour
{
    ActionMap actionMap;
    [SerializeField] int vitesse = 10;
    [SerializeField] int jumpHeight = 10;

    [SerializeField] Transform exitLocation;
    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        actionMap = new ActionMap();
        actionMap.PlayerMovement.Enable();
        actionMap.Interraction.Enable();
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
        if (actionMap.PlayerMovement.Jump.triggered)
        {
            transform.Translate(new Vector3(0, jumpHeight, 0) * Time.deltaTime);
        }
    }
}
