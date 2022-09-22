using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    public float sensitivity = 100;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Vector2 delta = Mouse.current.delta.ReadValue() * Time.deltaTime * sensitivity;
        player.Rotate(Vector3.up * delta.x);
    }
}
