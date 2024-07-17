using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    GridProperties gridProperties;

    Camera cam;
    Vector3 origin;
    Vector3 difference;
    bool isDragging;

    void Awake()
    {
        cam = Camera.main;
    }

    public void OnDrag(InputAction.CallbackContext ctx)
    {
        if (ctx.started) origin = GetMousePosition;
        isDragging = ctx.started || ctx.performed;
    }

    void LateUpdate()
    {
        if (!isDragging) return;
        difference = GetMousePosition - transform.position;
        Vector3 newPos = origin - difference;
        float offset = 10.24f * gridProperties.size;
        newPos.x = Mathf.Clamp(newPos.x, offset, gridProperties.x * offset);
        newPos.y = Mathf.Clamp(newPos.y, offset, gridProperties.y * offset);
        transform.position = newPos;
    }

    Vector3 GetMousePosition => cam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
}
