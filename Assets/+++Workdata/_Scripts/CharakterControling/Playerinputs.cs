//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/+++Workdata/_Scripts/CharakterControling/Playerinputs.inputactions
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

public partial class @Playerinputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Playerinputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Playerinputs"",
    ""maps"": [
        {
            ""name"": ""CharacterController"",
            ""id"": ""d4ca3c1a-9e62-4a15-9194-bf5a4889273b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a85c933d-15e9-4b2d-a85c-a572a43d3da6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""802ba020-51b8-4948-8709-508a53d9ad58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""76eb88b4-6fa9-4c9c-af65-3bebaeb39475"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sneak"",
                    ""type"": ""Value"",
                    ""id"": ""96e98ab7-9f7f-4eed-8c3d-fba4f5eeabc7"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pausemenu"",
                    ""type"": ""Button"",
                    ""id"": ""dd630ff0-a348-4ee6-a999-1e59cdd4e5b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e8ad9f64-1580-4ebe-831f-74a4ab676573"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e97801e-f8f8-4705-a9dd-23dba19072d2"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""216246e6-740b-4cf3-8f93-f83e81e07f70"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Sneak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f0761be3-5b98-4d40-bf6d-f7ff6be39c62"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f92f2920-ad33-46b6-84d3-8f66c8ea930c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""29d1a8c3-9392-4790-a8ea-8d4113eecd90"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e174c0a1-712e-4f1e-ad08-6ae4616336bd"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pausemenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""interactions"",
            ""id"": ""465c57ef-90cb-4533-b127-fbd0f239ce01"",
            ""actions"": [
                {
                    ""name"": ""pausegame"",
                    ""type"": ""Button"",
                    ""id"": ""35396fc0-99b4-42aa-86ce-d633eed983dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3ef0386d-c12d-4b8a-b8de-f4829e66d10e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""pausegame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // CharacterController
        m_CharacterController = asset.FindActionMap("CharacterController", throwIfNotFound: true);
        m_CharacterController_Move = m_CharacterController.FindAction("Move", throwIfNotFound: true);
        m_CharacterController_Jump = m_CharacterController.FindAction("Jump", throwIfNotFound: true);
        m_CharacterController_Sprint = m_CharacterController.FindAction("Sprint", throwIfNotFound: true);
        m_CharacterController_Sneak = m_CharacterController.FindAction("Sneak", throwIfNotFound: true);
        m_CharacterController_Pausemenu = m_CharacterController.FindAction("Pausemenu", throwIfNotFound: true);
        // interactions
        m_interactions = asset.FindActionMap("interactions", throwIfNotFound: true);
        m_interactions_pausegame = m_interactions.FindAction("pausegame", throwIfNotFound: true);
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

    // CharacterController
    private readonly InputActionMap m_CharacterController;
    private List<ICharacterControllerActions> m_CharacterControllerActionsCallbackInterfaces = new List<ICharacterControllerActions>();
    private readonly InputAction m_CharacterController_Move;
    private readonly InputAction m_CharacterController_Jump;
    private readonly InputAction m_CharacterController_Sprint;
    private readonly InputAction m_CharacterController_Sneak;
    private readonly InputAction m_CharacterController_Pausemenu;
    public struct CharacterControllerActions
    {
        private @Playerinputs m_Wrapper;
        public CharacterControllerActions(@Playerinputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_CharacterController_Move;
        public InputAction @Jump => m_Wrapper.m_CharacterController_Jump;
        public InputAction @Sprint => m_Wrapper.m_CharacterController_Sprint;
        public InputAction @Sneak => m_Wrapper.m_CharacterController_Sneak;
        public InputAction @Pausemenu => m_Wrapper.m_CharacterController_Pausemenu;
        public InputActionMap Get() { return m_Wrapper.m_CharacterController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControllerActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterControllerActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterControllerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterControllerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Sneak.started += instance.OnSneak;
            @Sneak.performed += instance.OnSneak;
            @Sneak.canceled += instance.OnSneak;
            @Pausemenu.started += instance.OnPausemenu;
            @Pausemenu.performed += instance.OnPausemenu;
            @Pausemenu.canceled += instance.OnPausemenu;
        }

        private void UnregisterCallbacks(ICharacterControllerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Sneak.started -= instance.OnSneak;
            @Sneak.performed -= instance.OnSneak;
            @Sneak.canceled -= instance.OnSneak;
            @Pausemenu.started -= instance.OnPausemenu;
            @Pausemenu.performed -= instance.OnPausemenu;
            @Pausemenu.canceled -= instance.OnPausemenu;
        }

        public void RemoveCallbacks(ICharacterControllerActions instance)
        {
            if (m_Wrapper.m_CharacterControllerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterControllerActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterControllerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterControllerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterControllerActions @CharacterController => new CharacterControllerActions(this);

    // interactions
    private readonly InputActionMap m_interactions;
    private List<IInteractionsActions> m_InteractionsActionsCallbackInterfaces = new List<IInteractionsActions>();
    private readonly InputAction m_interactions_pausegame;
    public struct InteractionsActions
    {
        private @Playerinputs m_Wrapper;
        public InteractionsActions(@Playerinputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @pausegame => m_Wrapper.m_interactions_pausegame;
        public InputActionMap Get() { return m_Wrapper.m_interactions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionsActions set) { return set.Get(); }
        public void AddCallbacks(IInteractionsActions instance)
        {
            if (instance == null || m_Wrapper.m_InteractionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InteractionsActionsCallbackInterfaces.Add(instance);
            @pausegame.started += instance.OnPausegame;
            @pausegame.performed += instance.OnPausegame;
            @pausegame.canceled += instance.OnPausegame;
        }

        private void UnregisterCallbacks(IInteractionsActions instance)
        {
            @pausegame.started -= instance.OnPausegame;
            @pausegame.performed -= instance.OnPausegame;
            @pausegame.canceled -= instance.OnPausegame;
        }

        public void RemoveCallbacks(IInteractionsActions instance)
        {
            if (m_Wrapper.m_InteractionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInteractionsActions instance)
        {
            foreach (var item in m_Wrapper.m_InteractionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InteractionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InteractionsActions @interactions => new InteractionsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface ICharacterControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSneak(InputAction.CallbackContext context);
        void OnPausemenu(InputAction.CallbackContext context);
    }
    public interface IInteractionsActions
    {
        void OnPausegame(InputAction.CallbackContext context);
    }
}
