using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CameraManager : MonoBehaviour
{
    Camera cam;
    Vector3 origin;
    Vector3 difference;
    bool isDragging;
    bool isZooming;
    float scrollAmount;
    float height;
    float width;
    float zoom;
    float zoomMultiplier = 0.01f;
    float minZoom = 2f;
    float maxZoom = 8f;
    float velocity = 0f;
    float smoothTime = 0.25f;

    void Awake()
    {
        cam = Camera.main;
        zoom = cam.orthographicSize;
        height = 2f * cam.orthographicSize;
        width = height * cam.aspect;
    }

    public void OnDrag(InputAction.CallbackContext ctx)
    {
        if (ctx.started) origin = GetMousePosition;
        isDragging = ctx.started || ctx.performed;
    }

    public void OnZoom(InputAction.CallbackContext ctx)
    {
        if (ctx.started) origin = GetMousePosition;
        scrollAmount = ctx.ReadValue<float>();
        isZooming = ctx.started || ctx.performed;
    }

    void LateUpdate()
    {
        if (isDragging)
        {
            height = 2f * cam.orthographicSize;
            width = height * cam.aspect;
            difference = GetMousePosition - transform.position;
            Vector3 newPos = origin - difference;

            float offset = 10.24f * 0.1f;
            float xMin = 0;
            float yMin = 0;
            float xMax = 0.1f * offset;
            float yMax = 0.1f * offset;
            newPos.x = Mathf.Clamp(newPos.x, xMin, xMax);
            newPos.y = Mathf.Clamp(newPos.y, yMin, yMax);

            transform.position = newPos;
        }
        else if (isZooming)
        {
            Debug.Log(scrollAmount + " " + zoom);
            zoom -= scrollAmount * zoomMultiplier;
            zoom = Mathf.Clamp(zoom, minZoom, maxZoom);

            //cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref velocity, smoothTime);
            cam.orthographicSize = zoom;
        }
    }

    Vector3 GetMousePosition => cam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
}
