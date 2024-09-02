//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Resources/Input Actions/InputActionsDefault.inputactions
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

namespace InputCustom
{
    public partial class @InputActionsDefault: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActionsDefault()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionsDefault"",
    ""maps"": [
        {
            ""name"": ""Global"",
            ""id"": ""94a8b5de-bdd5-420e-aa6f-ea30a1d80fff"",
            ""actions"": [
                {
                    ""name"": ""ToggleGameState"",
                    ""type"": ""Button"",
                    ""id"": ""3eeed775-5465-459c-9b8d-48207a906806"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d278510c-1954-488c-83f6-43bc70692c59"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleGameState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InGame"",
            ""id"": ""ca76cf3d-c6b3-4c3f-9aee-7083f718fcee"",
            ""actions"": [
                {
                    ""name"": ""SetScaleSide"",
                    ""type"": ""Value"",
                    ""id"": ""0175dacf-cc8c-496e-bf32-1958a72bab22"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SetScaleDirection"",
                    ""type"": ""Value"",
                    ""id"": ""063ac403-86ab-425d-bbec-52c92bb5a89c"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""48f6b44d-d15d-4ded-8947-3a018d7155ab"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""29ba9703-30ce-4b03-afcf-a3874dbb357a"",
                    ""path"": ""<Mouse>/scroll/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1735b483-0dcf-4497-9ef0-16572403603a"",
                    ""path"": ""<Mouse>/scroll/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""df46ebfa-86e6-429f-9be0-a8e739e8ec88"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4536dbe5-c8b1-4be0-8e3e-26c394561ad8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5719d81a-4e47-4a79-99c1-1c4342d409da"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""41b92893-a000-410d-91b8-14bf0bba0755"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleSide"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c96a3af4-e39c-4fbe-bd09-4fb244c7aff9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleSide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5d6ec33d-28f0-40d7-b1fc-48935191181c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetScaleSide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Global
            m_Global = asset.FindActionMap("Global", throwIfNotFound: true);
            m_Global_ToggleGameState = m_Global.FindAction("ToggleGameState", throwIfNotFound: true);
            // InGame
            m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
            m_InGame_SetScaleSide = m_InGame.FindAction("SetScaleSide", throwIfNotFound: true);
            m_InGame_SetScaleDirection = m_InGame.FindAction("SetScaleDirection", throwIfNotFound: true);
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

        // Global
        private readonly InputActionMap m_Global;
        private List<IGlobalActions> m_GlobalActionsCallbackInterfaces = new List<IGlobalActions>();
        private readonly InputAction m_Global_ToggleGameState;
        public struct GlobalActions
        {
            private @InputActionsDefault m_Wrapper;
            public GlobalActions(@InputActionsDefault wrapper) { m_Wrapper = wrapper; }
            public InputAction @ToggleGameState => m_Wrapper.m_Global_ToggleGameState;
            public InputActionMap Get() { return m_Wrapper.m_Global; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GlobalActions set) { return set.Get(); }
            public void AddCallbacks(IGlobalActions instance)
            {
                if (instance == null || m_Wrapper.m_GlobalActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GlobalActionsCallbackInterfaces.Add(instance);
                @ToggleGameState.started += instance.OnToggleGameState;
                @ToggleGameState.performed += instance.OnToggleGameState;
                @ToggleGameState.canceled += instance.OnToggleGameState;
            }

            private void UnregisterCallbacks(IGlobalActions instance)
            {
                @ToggleGameState.started -= instance.OnToggleGameState;
                @ToggleGameState.performed -= instance.OnToggleGameState;
                @ToggleGameState.canceled -= instance.OnToggleGameState;
            }

            public void RemoveCallbacks(IGlobalActions instance)
            {
                if (m_Wrapper.m_GlobalActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGlobalActions instance)
            {
                foreach (var item in m_Wrapper.m_GlobalActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GlobalActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GlobalActions @Global => new GlobalActions(this);

        // InGame
        private readonly InputActionMap m_InGame;
        private List<IInGameActions> m_InGameActionsCallbackInterfaces = new List<IInGameActions>();
        private readonly InputAction m_InGame_SetScaleSide;
        private readonly InputAction m_InGame_SetScaleDirection;
        public struct InGameActions
        {
            private @InputActionsDefault m_Wrapper;
            public InGameActions(@InputActionsDefault wrapper) { m_Wrapper = wrapper; }
            public InputAction @SetScaleSide => m_Wrapper.m_InGame_SetScaleSide;
            public InputAction @SetScaleDirection => m_Wrapper.m_InGame_SetScaleDirection;
            public InputActionMap Get() { return m_Wrapper.m_InGame; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
            public void AddCallbacks(IInGameActions instance)
            {
                if (instance == null || m_Wrapper.m_InGameActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_InGameActionsCallbackInterfaces.Add(instance);
                @SetScaleSide.started += instance.OnSetScaleSide;
                @SetScaleSide.performed += instance.OnSetScaleSide;
                @SetScaleSide.canceled += instance.OnSetScaleSide;
                @SetScaleDirection.started += instance.OnSetScaleDirection;
                @SetScaleDirection.performed += instance.OnSetScaleDirection;
                @SetScaleDirection.canceled += instance.OnSetScaleDirection;
            }

            private void UnregisterCallbacks(IInGameActions instance)
            {
                @SetScaleSide.started -= instance.OnSetScaleSide;
                @SetScaleSide.performed -= instance.OnSetScaleSide;
                @SetScaleSide.canceled -= instance.OnSetScaleSide;
                @SetScaleDirection.started -= instance.OnSetScaleDirection;
                @SetScaleDirection.performed -= instance.OnSetScaleDirection;
                @SetScaleDirection.canceled -= instance.OnSetScaleDirection;
            }

            public void RemoveCallbacks(IInGameActions instance)
            {
                if (m_Wrapper.m_InGameActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IInGameActions instance)
            {
                foreach (var item in m_Wrapper.m_InGameActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_InGameActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public InGameActions @InGame => new InGameActions(this);
        public interface IGlobalActions
        {
            void OnToggleGameState(InputAction.CallbackContext context);
        }
        public interface IInGameActions
        {
            void OnSetScaleSide(InputAction.CallbackContext context);
            void OnSetScaleDirection(InputAction.CallbackContext context);
        }
    }
}
