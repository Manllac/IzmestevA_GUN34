//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/TankControls.inputactions
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

namespace Tanks
{
    public partial class @TankControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TankControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""TankControls"",
    ""maps"": [
        {
            ""name"": ""Tank"",
            ""id"": ""2242f359-3f51-4944-82bb-437758ef76fb"",
            ""actions"": [
                {
                    ""name"": ""Handbreak"",
                    ""type"": ""Button"",
                    ""id"": ""c2f09c07-46f2-424b-a2cd-18dff2597b75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""65de8c30-4a96-4c7a-a358-11cc343c788c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7e973d97-6411-4184-9af4-3943b30c9166"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""7cd2c478-8b69-46ee-abcc-5fd0dfe6296d"",
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
                    ""id"": ""869ce753-7bb6-4601-bb01-f89ec9e42051"",
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
                    ""id"": ""e68b92cd-aeae-4d59-8c37-0bef1924decf"",
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
                    ""id"": ""970fa3e2-6486-418b-a8aa-a4410fdf5d49"",
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
                    ""id"": ""51d944f3-2dcc-4f87-a670-201837d9c10b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Turret"",
            ""id"": ""8158042f-8046-493b-b7c2-3fcf199339b0"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""c46013ab-9856-4435-bed3-85852bd89bb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Focus"",
                    ""type"": ""Value"",
                    ""id"": ""249f83df-66c8-4f62-b228-06bae2f7f2ff"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""313dee54-1a66-4d1e-a173-5c4a12cdee10"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c590b24-70cb-4e11-8afb-f9a43ee6cc1d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Focus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Tank
            m_Tank = asset.FindActionMap("Tank", throwIfNotFound: true);
            m_Tank_Handbreak = m_Tank.FindAction("Handbreak", throwIfNotFound: true);
            m_Tank_Movement = m_Tank.FindAction("Movement", throwIfNotFound: true);
            // Turret
            m_Turret = asset.FindActionMap("Turret", throwIfNotFound: true);
            m_Turret_Fire = m_Turret.FindAction("Fire", throwIfNotFound: true);
            m_Turret_Focus = m_Turret.FindAction("Focus", throwIfNotFound: true);
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

        // Tank
        private readonly InputActionMap m_Tank;
        private List<ITankActions> m_TankActionsCallbackInterfaces = new List<ITankActions>();
        private readonly InputAction m_Tank_Handbreak;
        private readonly InputAction m_Tank_Movement;
        public struct TankActions
        {
            private @TankControls m_Wrapper;
            public TankActions(@TankControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Handbreak => m_Wrapper.m_Tank_Handbreak;
            public InputAction @Movement => m_Wrapper.m_Tank_Movement;
            public InputActionMap Get() { return m_Wrapper.m_Tank; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
            public void AddCallbacks(ITankActions instance)
            {
                if (instance == null || m_Wrapper.m_TankActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TankActionsCallbackInterfaces.Add(instance);
                @Handbreak.started += instance.OnHandbreak;
                @Handbreak.performed += instance.OnHandbreak;
                @Handbreak.canceled += instance.OnHandbreak;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }

            private void UnregisterCallbacks(ITankActions instance)
            {
                @Handbreak.started -= instance.OnHandbreak;
                @Handbreak.performed -= instance.OnHandbreak;
                @Handbreak.canceled -= instance.OnHandbreak;
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
            }

            public void RemoveCallbacks(ITankActions instance)
            {
                if (m_Wrapper.m_TankActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITankActions instance)
            {
                foreach (var item in m_Wrapper.m_TankActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TankActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TankActions @Tank => new TankActions(this);

        // Turret
        private readonly InputActionMap m_Turret;
        private List<ITurretActions> m_TurretActionsCallbackInterfaces = new List<ITurretActions>();
        private readonly InputAction m_Turret_Fire;
        private readonly InputAction m_Turret_Focus;
        public struct TurretActions
        {
            private @TankControls m_Wrapper;
            public TurretActions(@TankControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Fire => m_Wrapper.m_Turret_Fire;
            public InputAction @Focus => m_Wrapper.m_Turret_Focus;
            public InputActionMap Get() { return m_Wrapper.m_Turret; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TurretActions set) { return set.Get(); }
            public void AddCallbacks(ITurretActions instance)
            {
                if (instance == null || m_Wrapper.m_TurretActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TurretActionsCallbackInterfaces.Add(instance);
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Focus.started += instance.OnFocus;
                @Focus.performed += instance.OnFocus;
                @Focus.canceled += instance.OnFocus;
            }

            private void UnregisterCallbacks(ITurretActions instance)
            {
                @Fire.started -= instance.OnFire;
                @Fire.performed -= instance.OnFire;
                @Fire.canceled -= instance.OnFire;
                @Focus.started -= instance.OnFocus;
                @Focus.performed -= instance.OnFocus;
                @Focus.canceled -= instance.OnFocus;
            }

            public void RemoveCallbacks(ITurretActions instance)
            {
                if (m_Wrapper.m_TurretActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITurretActions instance)
            {
                foreach (var item in m_Wrapper.m_TurretActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TurretActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TurretActions @Turret => new TurretActions(this);
        public interface ITankActions
        {
            void OnHandbreak(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
        }
        public interface ITurretActions
        {
            void OnFire(InputAction.CallbackContext context);
            void OnFocus(InputAction.CallbackContext context);
        }
    }
}
