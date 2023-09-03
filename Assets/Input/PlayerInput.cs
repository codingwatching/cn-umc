//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""576bffcc-68f6-4b69-bd84-424b8e003918"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""772cad8b-041d-40e0-b142-03b6ef01a36d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseDrag"",
                    ""type"": ""Value"",
                    ""id"": ""7c398186-9883-47f0-a0f5-16b062c12570"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Value"",
                    ""id"": ""0c243735-8dfe-4d6c-a381-3d160cdfdc9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Value"",
                    ""id"": ""316811c0-5afd-43e0-9712-78ab9a6d8f35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0e38b210-3109-402c-92ec-672612120960"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SpeedUp"",
                    ""type"": ""Button"",
                    ""id"": ""885248b1-4b7d-4782-93ed-9aa1226c06b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DropItem"",
                    ""type"": ""Button"",
                    ""id"": ""a183b9b4-9341-4743-a914-a63386b4cb0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""c8c4b500-e297-4b68-b013-1d91bdc7468f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchItemSlot"",
                    ""type"": ""Value"",
                    ""id"": ""8fbab21d-1ccb-42d3-a095-66e32e8ebc29"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseDragSec"",
                    ""type"": ""Value"",
                    ""id"": ""79edb2f1-dee1-49c0-9475-1629b6dd42c1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseDragTri"",
                    ""type"": ""Value"",
                    ""id"": ""0204c45d-6e7a-4160-ad03-ff4529c4787b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""13ed6b1a-125c-41a0-8002-638f5c2dfef1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""df2d9116-4b41-44dc-9ec7-948c6e75fe8f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f17e382f-af1b-47c3-9dea-c790e2042e30"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9bb00691-1a78-4728-9ec1-aaf073f17378"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""76c31273-cd38-48b7-9e16-7d0ce6e6a6b1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f6f977ab-791d-4b78-a602-c4c1920342fe"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48e5f8e3-f1e5-4734-8a87-664d2d7203c3"",
                    ""path"": ""<Touchscreen>/touch0/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c2c8242-51a8-42da-b638-e2866bdb4698"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d68f7e65-763b-4a67-9a90-6603e2abdaac"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f51e615-03c9-4b90-94b0-a5b6eeed8268"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fc6b34c-c934-4d0b-902c-60792231e617"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e796720c-ff25-4493-9119-e2d070d0dd02"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e33d3d48-2524-4ef6-86f7-7c4abbf8b59b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cce1ad4e-2dfc-4e5e-aa41-c11798d240a2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemSlot"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d1e1c0b2-b7b4-4edd-a601-43996b50bb07"",
                    ""path"": ""<Mouse>/scroll/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9bd20c25-91ba-4717-8fc1-463fc44cc47c"",
                    ""path"": ""<Mouse>/scroll/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac010aa2-5932-4462-aecf-2ed6a2bd6529"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0a155781-85c6-4cfd-b421-5b9f006848b7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ea4630cc-980c-44ef-bfe6-280d2d837baf"",
                    ""path"": ""<Touchscreen>/touch1/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDragSec"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""833f9e10-c1a0-45d2-a915-1fbde1bc6918"",
                    ""path"": ""<Touchscreen>/touch2/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDragTri"",
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
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_MouseDrag = m_Player.FindAction("MouseDrag", throwIfNotFound: true);
        m_Player_LeftClick = m_Player.FindAction("LeftClick", throwIfNotFound: true);
        m_Player_RightClick = m_Player.FindAction("RightClick", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_SpeedUp = m_Player.FindAction("SpeedUp", throwIfNotFound: true);
        m_Player_DropItem = m_Player.FindAction("DropItem", throwIfNotFound: true);
        m_Player_PauseGame = m_Player.FindAction("PauseGame", throwIfNotFound: true);
        m_Player_SwitchItemSlot = m_Player.FindAction("SwitchItemSlot", throwIfNotFound: true);
        m_Player_MouseDragSec = m_Player.FindAction("MouseDragSec", throwIfNotFound: true);
        m_Player_MouseDragTri = m_Player.FindAction("MouseDragTri", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_MouseDrag;
    private readonly InputAction m_Player_LeftClick;
    private readonly InputAction m_Player_RightClick;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_SpeedUp;
    private readonly InputAction m_Player_DropItem;
    private readonly InputAction m_Player_PauseGame;
    private readonly InputAction m_Player_SwitchItemSlot;
    private readonly InputAction m_Player_MouseDragSec;
    private readonly InputAction m_Player_MouseDragTri;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @MouseDrag => m_Wrapper.m_Player_MouseDrag;
        public InputAction @LeftClick => m_Wrapper.m_Player_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_Player_RightClick;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @SpeedUp => m_Wrapper.m_Player_SpeedUp;
        public InputAction @DropItem => m_Wrapper.m_Player_DropItem;
        public InputAction @PauseGame => m_Wrapper.m_Player_PauseGame;
        public InputAction @SwitchItemSlot => m_Wrapper.m_Player_SwitchItemSlot;
        public InputAction @MouseDragSec => m_Wrapper.m_Player_MouseDragSec;
        public InputAction @MouseDragTri => m_Wrapper.m_Player_MouseDragTri;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @MouseDrag.started += instance.OnMouseDrag;
            @MouseDrag.performed += instance.OnMouseDrag;
            @MouseDrag.canceled += instance.OnMouseDrag;
            @LeftClick.started += instance.OnLeftClick;
            @LeftClick.performed += instance.OnLeftClick;
            @LeftClick.canceled += instance.OnLeftClick;
            @RightClick.started += instance.OnRightClick;
            @RightClick.performed += instance.OnRightClick;
            @RightClick.canceled += instance.OnRightClick;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @SpeedUp.started += instance.OnSpeedUp;
            @SpeedUp.performed += instance.OnSpeedUp;
            @SpeedUp.canceled += instance.OnSpeedUp;
            @DropItem.started += instance.OnDropItem;
            @DropItem.performed += instance.OnDropItem;
            @DropItem.canceled += instance.OnDropItem;
            @PauseGame.started += instance.OnPauseGame;
            @PauseGame.performed += instance.OnPauseGame;
            @PauseGame.canceled += instance.OnPauseGame;
            @SwitchItemSlot.started += instance.OnSwitchItemSlot;
            @SwitchItemSlot.performed += instance.OnSwitchItemSlot;
            @SwitchItemSlot.canceled += instance.OnSwitchItemSlot;
            @MouseDragSec.started += instance.OnMouseDragSec;
            @MouseDragSec.performed += instance.OnMouseDragSec;
            @MouseDragSec.canceled += instance.OnMouseDragSec;
            @MouseDragTri.started += instance.OnMouseDragTri;
            @MouseDragTri.performed += instance.OnMouseDragTri;
            @MouseDragTri.canceled += instance.OnMouseDragTri;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @MouseDrag.started -= instance.OnMouseDrag;
            @MouseDrag.performed -= instance.OnMouseDrag;
            @MouseDrag.canceled -= instance.OnMouseDrag;
            @LeftClick.started -= instance.OnLeftClick;
            @LeftClick.performed -= instance.OnLeftClick;
            @LeftClick.canceled -= instance.OnLeftClick;
            @RightClick.started -= instance.OnRightClick;
            @RightClick.performed -= instance.OnRightClick;
            @RightClick.canceled -= instance.OnRightClick;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @SpeedUp.started -= instance.OnSpeedUp;
            @SpeedUp.performed -= instance.OnSpeedUp;
            @SpeedUp.canceled -= instance.OnSpeedUp;
            @DropItem.started -= instance.OnDropItem;
            @DropItem.performed -= instance.OnDropItem;
            @DropItem.canceled -= instance.OnDropItem;
            @PauseGame.started -= instance.OnPauseGame;
            @PauseGame.performed -= instance.OnPauseGame;
            @PauseGame.canceled -= instance.OnPauseGame;
            @SwitchItemSlot.started -= instance.OnSwitchItemSlot;
            @SwitchItemSlot.performed -= instance.OnSwitchItemSlot;
            @SwitchItemSlot.canceled -= instance.OnSwitchItemSlot;
            @MouseDragSec.started -= instance.OnMouseDragSec;
            @MouseDragSec.performed -= instance.OnMouseDragSec;
            @MouseDragSec.canceled -= instance.OnMouseDragSec;
            @MouseDragTri.started -= instance.OnMouseDragTri;
            @MouseDragTri.performed -= instance.OnMouseDragTri;
            @MouseDragTri.canceled -= instance.OnMouseDragTri;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMouseDrag(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSpeedUp(InputAction.CallbackContext context);
        void OnDropItem(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
        void OnSwitchItemSlot(InputAction.CallbackContext context);
        void OnMouseDragSec(InputAction.CallbackContext context);
        void OnMouseDragTri(InputAction.CallbackContext context);
    }
}
