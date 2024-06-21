using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    GridManager _grid;

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
        Vector3 _newPos = _origin - _difference;
        float offset = _grid._size / 0.1f;
        _newPos.x = Mathf.Clamp(_newPos.x, 0, 10 * offset);
        _newPos.y = Mathf.Clamp(_newPos.y, 0, 10 * offset);
        transform.position = _newPos;
    }

    Vector3 GetMousePosition => _camera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
}
