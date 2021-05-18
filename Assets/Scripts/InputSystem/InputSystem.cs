// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""2dc1f08f-5e93-4bf9-945b-cf7e249d9d66"",
            ""actions"": [
                {
                    ""name"": ""Vector2LStick"",
                    ""type"": ""Value"",
                    ""id"": ""908185cc-9da8-4b83-acad-e1485f433f7f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vector2Delta"",
                    ""type"": ""Value"",
                    ""id"": ""9629812f-a70c-405e-a36f-24de2438f48b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vector3Gyro"",
                    ""type"": ""Value"",
                    ""id"": ""f2337ac1-af1d-4e3b-be37-137bf7d4a81c"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""efb0d905-3c22-4a75-bad9-dd10a31d9491"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=20,y=20)"",
                    ""groups"": """",
                    ""action"": ""Vector2LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68f89cdb-63a7-4d4b-a057-0d2a6a5033a0"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=20,y=20)"",
                    ""groups"": """",
                    ""action"": ""Vector2LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12594da6-38ec-4205-b555-4c6df5121521"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vector2Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9887f89-2b78-4f37-954c-885b20dc3230"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vector2Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba41cf14-30cf-4f3b-87d2-af674e0fb80d"",
                    ""path"": ""<Gyroscope>/angularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vector3Gyro"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Vector2LStick = m_Player.FindAction("Vector2LStick", throwIfNotFound: true);
        m_Player_Vector2Delta = m_Player.FindAction("Vector2Delta", throwIfNotFound: true);
        m_Player_Vector3Gyro = m_Player.FindAction("Vector3Gyro", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Vector2Delta;
    private readonly InputAction m_Player_Vector3Gyro;
    public struct PlayerActions
    {
        private @InputSystem m_Wrapper;
        public PlayerActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vector2LStick => m_Wrapper.m_Player_Vector2LStick;
        public InputAction @Vector2Delta => m_Wrapper.m_Player_Vector2Delta;
        public InputAction @Vector3Gyro => m_Wrapper.m_Player_Vector3Gyro;
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
                @Vector2Delta.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector2Delta;
                @Vector2Delta.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector2Delta;
                @Vector2Delta.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector2Delta;
                @Vector3Gyro.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector3Gyro;
                @Vector3Gyro.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector3Gyro;
                @Vector3Gyro.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVector3Gyro;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vector2LStick.started += instance.OnVector2LStick;
                @Vector2LStick.performed += instance.OnVector2LStick;
                @Vector2LStick.canceled += instance.OnVector2LStick;
                @Vector2Delta.started += instance.OnVector2Delta;
                @Vector2Delta.performed += instance.OnVector2Delta;
                @Vector2Delta.canceled += instance.OnVector2Delta;
                @Vector3Gyro.started += instance.OnVector3Gyro;
                @Vector3Gyro.performed += instance.OnVector3Gyro;
                @Vector3Gyro.canceled += instance.OnVector3Gyro;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnVector2LStick(InputAction.CallbackContext context);
        void OnVector2Delta(InputAction.CallbackContext context);
        void OnVector3Gyro(InputAction.CallbackContext context);
    }
}
