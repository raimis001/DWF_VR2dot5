// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controllers"",
    ""maps"": [
        {
            ""name"": ""Left"",
            ""id"": ""6cda840b-0dcc-4b6d-9d4d-68a5cee628e6"",
            ""actions"": [
                {
                    ""name"": ""joystick"",
                    ""type"": ""Value"",
                    ""id"": ""87af59e3-f6da-429d-9a7d-7a3edc41fe3c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerDown"",
                    ""type"": ""Button"",
                    ""id"": ""370a1c68-ddc7-4afb-a7a7-2ce97c63a025"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerUp"",
                    ""type"": ""Button"",
                    ""id"": ""675a9611-524b-4f1d-bc7c-83f858bd2cdd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerValue"",
                    ""type"": ""Value"",
                    ""id"": ""a9adc3ac-9be2-4c2c-adde-5b2ab57f95c6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""action"",
                    ""type"": ""Button"",
                    ""id"": ""fe73ea78-974e-4ad1-a6b7-c5293eb675ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""secondary"",
                    ""type"": ""Button"",
                    ""id"": ""f3fa20ae-3f8f-4540-85f4-75b16e1f9e4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""grabUp"",
                    ""type"": ""Button"",
                    ""id"": ""a4fd2f60-e03b-473a-b09b-603ff9f6824f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""grabDown"",
                    ""type"": ""Button"",
                    ""id"": ""bb995ac6-77aa-4c11-b70b-6e0577804181"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerTouch"",
                    ""type"": ""Button"",
                    ""id"": ""06509e17-68b7-48b9-a1fe-4882a7a048b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99360488-c823-41ec-ab28-25fe8e308571"",
                    ""path"": ""<XRController>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""759350c4-aa52-4e56-a070-f0e05515f3be"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21b96f1e-55a6-411e-a84a-1e4c47c915bf"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcabbe6f-8204-46db-ac38-cbfe73bd4233"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerValue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86fb884e-1469-4012-9365-08552a2bd5f3"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d85f9c0b-8f23-4c7e-95b0-56e7629c353f"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""371f921a-bf4d-4971-b3ab-5629aca542b6"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""grabDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20406c2f-56a3-42b7-9dd3-92c84454e4b9"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""grabUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4e513cf-b678-4df5-be17-d64cc4afa6ac"",
                    ""path"": ""<XRController>{LeftHand}/triggerTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Right"",
            ""id"": ""5b2b4d36-3850-482f-afc2-eb5b4727c2f8"",
            ""actions"": [
                {
                    ""name"": ""joystick"",
                    ""type"": ""Value"",
                    ""id"": ""e93dcffc-1b9f-4a5e-9f59-b3539e0d332d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerDown"",
                    ""type"": ""Button"",
                    ""id"": ""d305c616-35fb-4ae0-b2dc-f8ba1a26bde4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerUp"",
                    ""type"": ""Button"",
                    ""id"": ""e66b2d6b-b597-4684-8d20-2d508a1ee791"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerValue"",
                    ""type"": ""Value"",
                    ""id"": ""9234927d-799e-4ad0-b63a-d5c7ffedde18"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""action"",
                    ""type"": ""Button"",
                    ""id"": ""1d70c01d-2121-407a-af5e-d51c56184b0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""secondary"",
                    ""type"": ""Button"",
                    ""id"": ""95306950-20cc-4b5e-977d-0848cad546b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""grabUp"",
                    ""type"": ""Button"",
                    ""id"": ""d3a95003-2239-4d26-b98f-b30711dbed2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""grabDown"",
                    ""type"": ""Button"",
                    ""id"": ""965179fd-ce08-4ebc-82aa-dcefb870cd25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""triggerTouch"",
                    ""type"": ""Button"",
                    ""id"": ""3aa1d8e3-d09f-4440-a9a6-5772785c09b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ae2d34e-4d40-42db-974f-71813e97bfaa"",
                    ""path"": ""<XRController>{RightHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb4a271d-9fb2-4ca2-ba75-fff5e108a48c"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26fe2718-5cc0-4e75-81d7-78b6800efd7e"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3e9d38f-5b16-4067-a079-231ceb1a2f07"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerValue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96d1ad17-39f5-4bcf-9885-222f1532194f"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89bb66ca-8d79-44bd-ad61-d8c3b7edff17"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""183e67db-854e-476d-964e-144682eba7a7"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""grabDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0ad38ba-191b-42c1-ad5c-210b4b9abcf9"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""grabUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e23780e-3fde-4921-8823-994675e33e63"",
                    ""path"": ""<XRController>{RightHand}/triggerTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triggerTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ship"",
            ""id"": ""bf1bd024-f936-4c18-a149-c11fca3c3849"",
            ""actions"": [
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""733aba40-5fac-4831-a828-5ef8bbdff38a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""f87f1ba0-a772-4ead-bb8e-e6255ded353a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""62862dce-13d1-439d-a0df-97c35734e119"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c01d5747-6f32-46fe-b411-a8ea22334a7d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Left
        m_Left = asset.FindActionMap("Left", throwIfNotFound: true);
        m_Left_joystick = m_Left.FindAction("joystick", throwIfNotFound: true);
        m_Left_triggerDown = m_Left.FindAction("triggerDown", throwIfNotFound: true);
        m_Left_triggerUp = m_Left.FindAction("triggerUp", throwIfNotFound: true);
        m_Left_triggerValue = m_Left.FindAction("triggerValue", throwIfNotFound: true);
        m_Left_action = m_Left.FindAction("action", throwIfNotFound: true);
        m_Left_secondary = m_Left.FindAction("secondary", throwIfNotFound: true);
        m_Left_grabUp = m_Left.FindAction("grabUp", throwIfNotFound: true);
        m_Left_grabDown = m_Left.FindAction("grabDown", throwIfNotFound: true);
        m_Left_triggerTouch = m_Left.FindAction("triggerTouch", throwIfNotFound: true);
        // Right
        m_Right = asset.FindActionMap("Right", throwIfNotFound: true);
        m_Right_joystick = m_Right.FindAction("joystick", throwIfNotFound: true);
        m_Right_triggerDown = m_Right.FindAction("triggerDown", throwIfNotFound: true);
        m_Right_triggerUp = m_Right.FindAction("triggerUp", throwIfNotFound: true);
        m_Right_triggerValue = m_Right.FindAction("triggerValue", throwIfNotFound: true);
        m_Right_action = m_Right.FindAction("action", throwIfNotFound: true);
        m_Right_secondary = m_Right.FindAction("secondary", throwIfNotFound: true);
        m_Right_grabUp = m_Right.FindAction("grabUp", throwIfNotFound: true);
        m_Right_grabDown = m_Right.FindAction("grabDown", throwIfNotFound: true);
        m_Right_triggerTouch = m_Right.FindAction("triggerTouch", throwIfNotFound: true);
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_RotateLeft = m_Ship.FindAction("RotateLeft", throwIfNotFound: true);
        m_Ship_RotateRight = m_Ship.FindAction("RotateRight", throwIfNotFound: true);
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

    // Left
    private readonly InputActionMap m_Left;
    private ILeftActions m_LeftActionsCallbackInterface;
    private readonly InputAction m_Left_joystick;
    private readonly InputAction m_Left_triggerDown;
    private readonly InputAction m_Left_triggerUp;
    private readonly InputAction m_Left_triggerValue;
    private readonly InputAction m_Left_action;
    private readonly InputAction m_Left_secondary;
    private readonly InputAction m_Left_grabUp;
    private readonly InputAction m_Left_grabDown;
    private readonly InputAction m_Left_triggerTouch;
    public struct LeftActions
    {
        private @Controllers m_Wrapper;
        public LeftActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @joystick => m_Wrapper.m_Left_joystick;
        public InputAction @triggerDown => m_Wrapper.m_Left_triggerDown;
        public InputAction @triggerUp => m_Wrapper.m_Left_triggerUp;
        public InputAction @triggerValue => m_Wrapper.m_Left_triggerValue;
        public InputAction @action => m_Wrapper.m_Left_action;
        public InputAction @secondary => m_Wrapper.m_Left_secondary;
        public InputAction @grabUp => m_Wrapper.m_Left_grabUp;
        public InputAction @grabDown => m_Wrapper.m_Left_grabDown;
        public InputAction @triggerTouch => m_Wrapper.m_Left_triggerTouch;
        public InputActionMap Get() { return m_Wrapper.m_Left; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftActions set) { return set.Get(); }
        public void SetCallbacks(ILeftActions instance)
        {
            if (m_Wrapper.m_LeftActionsCallbackInterface != null)
            {
                @joystick.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnJoystick;
                @joystick.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnJoystick;
                @joystick.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnJoystick;
                @triggerDown.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerDown;
                @triggerDown.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerDown;
                @triggerDown.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerDown;
                @triggerUp.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerUp;
                @triggerUp.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerUp;
                @triggerUp.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerUp;
                @triggerValue.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerValue;
                @triggerValue.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerValue;
                @triggerValue.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerValue;
                @action.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnAction;
                @action.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnAction;
                @action.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnAction;
                @secondary.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnSecondary;
                @secondary.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnSecondary;
                @secondary.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnSecondary;
                @grabUp.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnGrabUp;
                @grabUp.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnGrabUp;
                @grabUp.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnGrabUp;
                @grabDown.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnGrabDown;
                @grabDown.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnGrabDown;
                @grabDown.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnGrabDown;
                @triggerTouch.started -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerTouch;
                @triggerTouch.performed -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerTouch;
                @triggerTouch.canceled -= m_Wrapper.m_LeftActionsCallbackInterface.OnTriggerTouch;
            }
            m_Wrapper.m_LeftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @joystick.started += instance.OnJoystick;
                @joystick.performed += instance.OnJoystick;
                @joystick.canceled += instance.OnJoystick;
                @triggerDown.started += instance.OnTriggerDown;
                @triggerDown.performed += instance.OnTriggerDown;
                @triggerDown.canceled += instance.OnTriggerDown;
                @triggerUp.started += instance.OnTriggerUp;
                @triggerUp.performed += instance.OnTriggerUp;
                @triggerUp.canceled += instance.OnTriggerUp;
                @triggerValue.started += instance.OnTriggerValue;
                @triggerValue.performed += instance.OnTriggerValue;
                @triggerValue.canceled += instance.OnTriggerValue;
                @action.started += instance.OnAction;
                @action.performed += instance.OnAction;
                @action.canceled += instance.OnAction;
                @secondary.started += instance.OnSecondary;
                @secondary.performed += instance.OnSecondary;
                @secondary.canceled += instance.OnSecondary;
                @grabUp.started += instance.OnGrabUp;
                @grabUp.performed += instance.OnGrabUp;
                @grabUp.canceled += instance.OnGrabUp;
                @grabDown.started += instance.OnGrabDown;
                @grabDown.performed += instance.OnGrabDown;
                @grabDown.canceled += instance.OnGrabDown;
                @triggerTouch.started += instance.OnTriggerTouch;
                @triggerTouch.performed += instance.OnTriggerTouch;
                @triggerTouch.canceled += instance.OnTriggerTouch;
            }
        }
    }
    public LeftActions @Left => new LeftActions(this);

    // Right
    private readonly InputActionMap m_Right;
    private IRightActions m_RightActionsCallbackInterface;
    private readonly InputAction m_Right_joystick;
    private readonly InputAction m_Right_triggerDown;
    private readonly InputAction m_Right_triggerUp;
    private readonly InputAction m_Right_triggerValue;
    private readonly InputAction m_Right_action;
    private readonly InputAction m_Right_secondary;
    private readonly InputAction m_Right_grabUp;
    private readonly InputAction m_Right_grabDown;
    private readonly InputAction m_Right_triggerTouch;
    public struct RightActions
    {
        private @Controllers m_Wrapper;
        public RightActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @joystick => m_Wrapper.m_Right_joystick;
        public InputAction @triggerDown => m_Wrapper.m_Right_triggerDown;
        public InputAction @triggerUp => m_Wrapper.m_Right_triggerUp;
        public InputAction @triggerValue => m_Wrapper.m_Right_triggerValue;
        public InputAction @action => m_Wrapper.m_Right_action;
        public InputAction @secondary => m_Wrapper.m_Right_secondary;
        public InputAction @grabUp => m_Wrapper.m_Right_grabUp;
        public InputAction @grabDown => m_Wrapper.m_Right_grabDown;
        public InputAction @triggerTouch => m_Wrapper.m_Right_triggerTouch;
        public InputActionMap Get() { return m_Wrapper.m_Right; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightActions set) { return set.Get(); }
        public void SetCallbacks(IRightActions instance)
        {
            if (m_Wrapper.m_RightActionsCallbackInterface != null)
            {
                @joystick.started -= m_Wrapper.m_RightActionsCallbackInterface.OnJoystick;
                @joystick.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnJoystick;
                @joystick.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnJoystick;
                @triggerDown.started -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerDown;
                @triggerDown.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerDown;
                @triggerDown.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerDown;
                @triggerUp.started -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerUp;
                @triggerUp.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerUp;
                @triggerUp.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerUp;
                @triggerValue.started -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerValue;
                @triggerValue.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerValue;
                @triggerValue.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerValue;
                @action.started -= m_Wrapper.m_RightActionsCallbackInterface.OnAction;
                @action.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnAction;
                @action.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnAction;
                @secondary.started -= m_Wrapper.m_RightActionsCallbackInterface.OnSecondary;
                @secondary.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnSecondary;
                @secondary.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnSecondary;
                @grabUp.started -= m_Wrapper.m_RightActionsCallbackInterface.OnGrabUp;
                @grabUp.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnGrabUp;
                @grabUp.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnGrabUp;
                @grabDown.started -= m_Wrapper.m_RightActionsCallbackInterface.OnGrabDown;
                @grabDown.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnGrabDown;
                @grabDown.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnGrabDown;
                @triggerTouch.started -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerTouch;
                @triggerTouch.performed -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerTouch;
                @triggerTouch.canceled -= m_Wrapper.m_RightActionsCallbackInterface.OnTriggerTouch;
            }
            m_Wrapper.m_RightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @joystick.started += instance.OnJoystick;
                @joystick.performed += instance.OnJoystick;
                @joystick.canceled += instance.OnJoystick;
                @triggerDown.started += instance.OnTriggerDown;
                @triggerDown.performed += instance.OnTriggerDown;
                @triggerDown.canceled += instance.OnTriggerDown;
                @triggerUp.started += instance.OnTriggerUp;
                @triggerUp.performed += instance.OnTriggerUp;
                @triggerUp.canceled += instance.OnTriggerUp;
                @triggerValue.started += instance.OnTriggerValue;
                @triggerValue.performed += instance.OnTriggerValue;
                @triggerValue.canceled += instance.OnTriggerValue;
                @action.started += instance.OnAction;
                @action.performed += instance.OnAction;
                @action.canceled += instance.OnAction;
                @secondary.started += instance.OnSecondary;
                @secondary.performed += instance.OnSecondary;
                @secondary.canceled += instance.OnSecondary;
                @grabUp.started += instance.OnGrabUp;
                @grabUp.performed += instance.OnGrabUp;
                @grabUp.canceled += instance.OnGrabUp;
                @grabDown.started += instance.OnGrabDown;
                @grabDown.performed += instance.OnGrabDown;
                @grabDown.canceled += instance.OnGrabDown;
                @triggerTouch.started += instance.OnTriggerTouch;
                @triggerTouch.performed += instance.OnTriggerTouch;
                @triggerTouch.canceled += instance.OnTriggerTouch;
            }
        }
    }
    public RightActions @Right => new RightActions(this);

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_RotateLeft;
    private readonly InputAction m_Ship_RotateRight;
    public struct ShipActions
    {
        private @Controllers m_Wrapper;
        public ShipActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateLeft => m_Wrapper.m_Ship_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_Ship_RotateRight;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @RotateLeft.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotateRight;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);
    public interface ILeftActions
    {
        void OnJoystick(InputAction.CallbackContext context);
        void OnTriggerDown(InputAction.CallbackContext context);
        void OnTriggerUp(InputAction.CallbackContext context);
        void OnTriggerValue(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnSecondary(InputAction.CallbackContext context);
        void OnGrabUp(InputAction.CallbackContext context);
        void OnGrabDown(InputAction.CallbackContext context);
        void OnTriggerTouch(InputAction.CallbackContext context);
    }
    public interface IRightActions
    {
        void OnJoystick(InputAction.CallbackContext context);
        void OnTriggerDown(InputAction.CallbackContext context);
        void OnTriggerUp(InputAction.CallbackContext context);
        void OnTriggerValue(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnSecondary(InputAction.CallbackContext context);
        void OnGrabUp(InputAction.CallbackContext context);
        void OnGrabDown(InputAction.CallbackContext context);
        void OnTriggerTouch(InputAction.CallbackContext context);
    }
    public interface IShipActions
    {
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
    }
}
