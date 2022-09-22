using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInterractionComponent : MonoBehaviour
{
    ActionMap actionMap;
    [SerializeField] Transform interractibleObject;
    [SerializeField] int maxDistance = 5;

    // Start is called before the first frame update
    void Start()    
    {
        actionMap = new ActionMap();
        actionMap.Interraction.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        if (actionMap.Interraction.interract.triggered)
        {
            float dist = Vector3.Distance(interractibleObject.position, transform.position);
            if (dist < maxDistance && 
                interractibleObject.position.y - transform.position.y <= 1 &&
                interractibleObject.position.y - transform.position.y >= -1)
            {
                Debug.Log("test");
            }
        }
    }
}
