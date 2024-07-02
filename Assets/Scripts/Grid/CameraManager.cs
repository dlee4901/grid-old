using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    GridProperties _gridProperties;

    Camera _camera;
    Vector3 _origin;
    Vector3 _difference;
    bool _isDragging;

    void Awake()
    {
        _camera = Camera.main;
    }

    public void OnDrag(InputAction.CallbackContext ctx)
    {
        if (ctx.started) _origin = GetMousePosition;
        _isDragging = ctx.started || ctx.performed;
    }

    void LateUpdate()
    {
        if (!_isDragging) return;
        _difference = GetMousePosition - transform.position;
        Vector3 newPos = _origin - _difference;
        float offset = _gridProperties.size / 0.1f;
        newPos.x = Mathf.Clamp(newPos.x, offset, _gridProperties.x * offset);
        newPos.y = Mathf.Clamp(newPos.y, offset, _gridProperties.y * offset);
        transform.position = newPos;
    }

    Vector3 GetMousePosition => _camera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
}
