//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input/TouchControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @TouchControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControls"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""0774ca83-186b-4cf9-b089-b465ba5a5b4a"",
            ""actions"": [
                {
                    ""name"": ""PrimaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""23ea12cc-6182-4cf4-a8b6-a6cda94ed31e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""0af6ef41-0684-4e5f-8064-52e15937b2e7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PrimaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""9ebb35e9-bc2e-4bb9-96c5-31d35e787f57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""e2dc36bc-e964-4322-809e-74fa78c3fc43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""1e007006-1682-49c5-b818-0527db6840ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""ace4537a-95ed-4938-9f89-9fea3449f6d0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce8de3d1-6974-44c2-88dc-8081870ae7b5"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08c6d850-81c9-488f-9cb3-56029e0540d4"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0111c1ce-e953-4be4-b76f-7aad3ad3c473"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cba74a6f-c83a-4040-8ab4-6928165c3042"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31723fb6-1354-459f-b795-cfe506e269e9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""584f066a-dfec-4d37-adda-a3b620ee9a4b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AvatarControl"",
            ""id"": ""e5224880-712e-4dc1-af71-a6e70a10582f"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1b6e32e8-e2ec-43a9-a40d-59223b6b1ba3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fbc7581b-3367-416b-8c1d-54516d340862"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b8f68f1d-131d-46e7-9df2-1b1f10d2f44d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c76b3591-e3ce-4d3c-b371-cabac143f058"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3a44c3be-3f0c-41e2-af2a-e21b48d6506a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6970573b-f7ba-4e87-b6cd-6172949ae1c2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_PrimaryFingerPosition = m_Touch.FindAction("PrimaryFingerPosition", throwIfNotFound: true);
        m_Touch_SecondaryFingerPosition = m_Touch.FindAction("SecondaryFingerPosition", throwIfNotFound: true);
        m_Touch_PrimaryTouchContact = m_Touch.FindAction("PrimaryTouchContact", throwIfNotFound: true);
        m_Touch_SecondaryTouchContact = m_Touch.FindAction("SecondaryTouchContact", throwIfNotFound: true);
        m_Touch_MouseClick = m_Touch.FindAction("MouseClick", throwIfNotFound: true);
        m_Touch_MousePosition = m_Touch.FindAction("MousePosition", throwIfNotFound: true);
        // AvatarControl
        m_AvatarControl = asset.FindActionMap("AvatarControl", throwIfNotFound: true);
        m_AvatarControl_Movement = m_AvatarControl.FindAction("Movement", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Touch
    private readonly InputActionMap m_Touch;
    private List<ITouchActions> m_TouchActionsCallbackInterfaces = new List<ITouchActions>();
    private readonly InputAction m_Touch_PrimaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryFingerPosition;
    private readonly InputAction m_Touch_PrimaryTouchContact;
    private readonly InputAction m_Touch_SecondaryTouchContact;
    private readonly InputAction m_Touch_MouseClick;
    private readonly InputAction m_Touch_MousePosition;
    public struct TouchActions
    {
        private @TouchControls m_Wrapper;
        public TouchActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Touch_PrimaryFingerPosition;
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Touch_SecondaryFingerPosition;
        public InputAction @PrimaryTouchContact => m_Wrapper.m_Touch_PrimaryTouchContact;
        public InputAction @SecondaryTouchContact => m_Wrapper.m_Touch_SecondaryTouchContact;
        public InputAction @MouseClick => m_Wrapper.m_Touch_MouseClick;
        public InputAction @MousePosition => m_Wrapper.m_Touch_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void AddCallbacks(ITouchActions instance)
        {
            if (instance == null || m_Wrapper.m_TouchActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TouchActionsCallbackInterfaces.Add(instance);
            @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
            @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
            @PrimaryTouchContact.started += instance.OnPrimaryTouchContact;
            @PrimaryTouchContact.performed += instance.OnPrimaryTouchContact;
            @PrimaryTouchContact.canceled += instance.OnPrimaryTouchContact;
            @SecondaryTouchContact.started += instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.performed += instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.canceled += instance.OnSecondaryTouchContact;
            @MouseClick.started += instance.OnMouseClick;
            @MouseClick.performed += instance.OnMouseClick;
            @MouseClick.canceled += instance.OnMouseClick;
            @MousePosition.started += instance.OnMousePosition;
            @MousePosition.performed += instance.OnMousePosition;
            @MousePosition.canceled += instance.OnMousePosition;
        }

        private void UnregisterCallbacks(ITouchActions instance)
        {
            @PrimaryFingerPosition.started -= instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.performed -= instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.canceled -= instance.OnPrimaryFingerPosition;
            @SecondaryFingerPosition.started -= instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.performed -= instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.canceled -= instance.OnSecondaryFingerPosition;
            @PrimaryTouchContact.started -= instance.OnPrimaryTouchContact;
            @PrimaryTouchContact.performed -= instance.OnPrimaryTouchContact;
            @PrimaryTouchContact.canceled -= instance.OnPrimaryTouchContact;
            @SecondaryTouchContact.started -= instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.performed -= instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.canceled -= instance.OnSecondaryTouchContact;
            @MouseClick.started -= instance.OnMouseClick;
            @MouseClick.performed -= instance.OnMouseClick;
            @MouseClick.canceled -= instance.OnMouseClick;
            @MousePosition.started -= instance.OnMousePosition;
            @MousePosition.performed -= instance.OnMousePosition;
            @MousePosition.canceled -= instance.OnMousePosition;
        }

        public void RemoveCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITouchActions instance)
        {
            foreach (var item in m_Wrapper.m_TouchActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TouchActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TouchActions @Touch => new TouchActions(this);

    // AvatarControl
    private readonly InputActionMap m_AvatarControl;
    private List<IAvatarControlActions> m_AvatarControlActionsCallbackInterfaces = new List<IAvatarControlActions>();
    private readonly InputAction m_AvatarControl_Movement;
    public struct AvatarControlActions
    {
        private @TouchControls m_Wrapper;
        public AvatarControlActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_AvatarControl_Movement;
        public InputActionMap Get() { return m_Wrapper.m_AvatarControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AvatarControlActions set) { return set.Get(); }
        public void AddCallbacks(IAvatarControlActions instance)
        {
            if (instance == null || m_Wrapper.m_AvatarControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_AvatarControlActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
        }

        private void UnregisterCallbacks(IAvatarControlActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
        }

        public void RemoveCallbacks(IAvatarControlActions instance)
        {
            if (m_Wrapper.m_AvatarControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IAvatarControlActions instance)
        {
            foreach (var item in m_Wrapper.m_AvatarControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_AvatarControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public AvatarControlActions @AvatarControl => new AvatarControlActions(this);
    public interface ITouchActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
        void OnPrimaryTouchContact(InputAction.CallbackContext context);
        void OnSecondaryTouchContact(InputAction.CallbackContext context);
        void OnMouseClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
    public interface IAvatarControlActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
