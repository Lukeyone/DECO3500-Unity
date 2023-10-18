using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarControl : MonoBehaviour
{
    public Camera cam;
    TouchControls playerControls;
    RectTransform avatarRectTransform;
    public Vector2 movementInput;
    public float speed = 1;
    void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new TouchControls();
            playerControls.AvatarControl.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playerControls.Enable();
    }

    void Awake()
    {
        avatarRectTransform = GetComponent<RectTransform>();
    }

    void LateUpdate()
    {
        MoveAvatar();
    }

    void MoveAvatar()
    {
        if (movementInput == Vector2.zero) return;
        Vector2 newPosition = avatarRectTransform.anchoredPosition + new Vector2(movementInput.x, movementInput.y) * speed * Time.deltaTime;
        avatarRectTransform.anchoredPosition = newPosition;
        float cameraZ = cam.transform.position.z;
        cam.transform.position = new Vector3(avatarRectTransform.anchoredPosition.x, avatarRectTransform.anchoredPosition.y, cameraZ);
    }

    void OnDisable()
    {
        playerControls.Disable();
    }
}
