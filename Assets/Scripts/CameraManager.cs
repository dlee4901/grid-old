using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CameraManager : MonoBehaviour
{
    private Vector3 _origin;
    private Vector3 _difference;

    private Camera _camera;
    private bool _isDragging;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnDrag(InputAction.CallbackContext ctx)
    {
        if (ctx.started) _origin = GetMousePosition;
        _isDragging = ctx.started || ctx.performed;

    }

    private void LateUpdate()
    {
        if (!_isDragging) return;
        _difference = GetMousePosition - transform.position;
        Vector3 _newPos = _origin - _difference;
        _newPos.x = Mathf.Clamp(_newPos.x, 0, 10);
        _newPos.y = Mathf.Clamp(_newPos.y, 0, 10);
        transform.position = _newPos;
    }

    private Vector3 GetMousePosition => _camera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
}
