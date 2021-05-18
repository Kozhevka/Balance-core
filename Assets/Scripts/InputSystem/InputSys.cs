// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSystem/InputSys.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSys : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSys()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSys"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""52390ba8-3ce0-404d-a4b9-2487a6cdc6c4"",
            ""actions"": [
                {
                    ""name"": ""Vector2LStick"",
                    ""type"": ""Value"",
                    ""id"": ""e2faaac5-1881-4238-8d31-d8a79ed00c18"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""buttonTest"",
                    ""type"": ""Button"",
                    ""id"": ""d0c5567b-7436-49fd-88b5-956bd8de94c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1696d7b1-d24a-46ae-b9f3-ff61a949be8f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad|Touch|Mouse"",
                    ""action"": ""Vector2LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d7a395f-c7b9-418a-b266-da1da8a58687"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad|Touch|Mouse"",
                    ""action"": ""Vector2LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2884c4d-c562-4118-bdf3-ec0ee786f286"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad|Touch|Mouse"",
                    ""action"": ""Vector2LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""462b91bd-ec60-4cb2-bd11-4d7caab17b16"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad|Touch|Mouse"",
                    ""action"": ""Vector2LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93a24867-c7cf-42ec-879b-942c7b2e0200"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad|Touch|Mouse"",
                    ""action"": ""Vector2LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee9d4889-7b48-4d95-a1a6-65b7d66bbcf6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad|Touch|Mouse"",
                    ""action"": ""buttonTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7df21cad-ca33-432f-98aa-c19f00f19162"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad|Touch|Mouse"",
                    ""action"": ""buttonTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad|Touch|Mouse"",
            ""bindingGroup"": ""Gamepad|Touch|Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<AndroidJoystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Vector2LStick = m_Player.FindAction("Vector2LStick", throwIfNotFound: true);
        m_Player_buttonTest = m_Player.FindAction("buttonTest", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Vector2LStick;
    private readonly InputAction m_Player_buttonTest;
    public struct PlayerActions
    {
        private @InputSys m_Wrapper;
        public PlayerActions(@InputSys wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vector2LStick => m_Wrapper.m_Player_Vector2LStick;
        public InputAction @buttonTest => m_Wrapper.m_Player_buttonTest;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Vector2LStick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector2LStick;
                @Vector2LStick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector2LStick;
                @Vector2LStick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector2LStick;
                @buttonTest.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnButtonTest;
                @buttonTest.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnButtonTest;
                @buttonTest.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnButtonTest;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vector2LStick.started += instance.OnVector2LStick;
                @Vector2LStick.performed += instance.OnVector2LStick;
                @Vector2LStick.canceled += instance.OnVector2LStick;
                @buttonTest.started += instance.OnButtonTest;
                @buttonTest.performed += instance.OnButtonTest;
                @buttonTest.canceled += instance.OnButtonTest;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_GamepadTouchMouseSchemeIndex = -1;
    public InputControlScheme GamepadTouchMouseScheme
    {
        get
        {
            if (m_GamepadTouchMouseSchemeIndex == -1) m_GamepadTouchMouseSchemeIndex = asset.FindControlSchemeIndex("Gamepad|Touch|Mouse");
            return asset.controlSchemes[m_GamepadTouchMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnVector2LStick(InputAction.CallbackContext context);
        void OnButtonTest(InputAction.CallbackContext context);
    }
}
