using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Camera cam;

    [SerializeField] float zoomStep, minCamSize, maxCamSize;

    [SerializeField] SpriteRenderer mapRenderer;
    float mapMinX, mapMaxX, mapMinY, mapMaxY;
    Vector3 dragOrigin;
    TouchControls controls;
    Coroutine zoomCoroutine;
    bool isZoomCoroutineRunning;

    bool shouldPan = false;
    bool isClientOnMobile = false;

    void Awake()
    {
        controls = new TouchControls();
        // Zoom controls
        controls.Touch.SecondaryTouchContact.started += _ => ZoomStart();
        controls.Touch.SecondaryTouchContact.canceled += _ => ZoomEnd();
        controls.Touch.PrimaryTouchContact.canceled += _ => ZoomEnd();

        // Pan controls
        controls.Touch.PrimaryTouchContact.started += _ => StartPanMobile();
        controls.Touch.PrimaryTouchContact.canceled += _ => EndPan();
        controls.Touch.MouseClick.started += _ => StartPanDesktop();
        controls.Touch.MouseClick.canceled += _ => EndPan();

        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;

        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;
    }

    void StartPanDesktop()
    {
        Vector2 tapPosition = controls.Touch.MousePosition.ReadValue<Vector2>();
        // Save initial pos (first time clicked)
        dragOrigin = cam.ScreenToWorldPoint(tapPosition);
        shouldPan = true;
        isClientOnMobile = false;
    }

    void StartPanMobile()
    {
        Vector2 tapPosition = controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>();
        // Save initial pos (first time clicked)
        dragOrigin = cam.ScreenToWorldPoint(tapPosition);
        shouldPan = true;
        isClientOnMobile = true;
    }

    void EndPan()
    {
        shouldPan = false;
    }

    void Update()
    {
        PanCamera();
    }

    void PanCamera()
    {
        if (!shouldPan) return;
        Vector2 tapPosition = isClientOnMobile ? controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>() : controls.Touch.MousePosition.ReadValue<Vector2>();

        // Calc distance between drag origin & new pos if it is still held down
        Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(tapPosition);
        cam.transform.position = ClampCamera(cam.transform.position + difference);
    }

    void ZoomStart()
    {
        if (isZoomCoroutineRunning) return;
        Debug.Log("Zoom started");
        zoomCoroutine = StartCoroutine(ZoomDetection());
        isZoomCoroutineRunning = true;
    }

    void ZoomEnd()
    {
        if (!isZoomCoroutineRunning) return;
        Debug.Log("Zoom ended");
        StopCoroutine(zoomCoroutine);
        isZoomCoroutineRunning = false;
    }

    IEnumerator ZoomDetection()
    {
        Debug.Log("Getting Previous distance: ");

        float previousDistance = Vector2.Distance(controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(),
                                        controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
        Debug.Log("Previous distance: " + previousDistance);

        while (true)
        {
            float distance = Vector2.Distance(controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(),
                                            controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
            // Detection
            // Zoom out
            if (distance > previousDistance)
            {
                Debug.Log("Zooming out");

                ZoomOut();
            }
            // Zoom in 
            else if (distance < previousDistance)
            {
                Debug.Log("Zooming in");

                ZoomIn();
            }
            // Keep track of the distance for the next frame
            previousDistance = distance;
            yield return null;
        }
    }

    void ZoomIn()
    {
        Debug.Log("Zooming in...");
        float newSize = cam.orthographicSize - zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
        cam.transform.position = ClampCamera(cam.transform.position);

    }
    void ZoomOut()
    {
        Debug.Log("Zooming out...");
        float newSize = cam.orthographicSize + zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
        cam.transform.position = ClampCamera(cam.transform.position);
    }

    Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3(newX, newY, targetPosition.z);
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }
}
