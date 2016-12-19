//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {
    public partial class Entity {
        static readonly ControlableComponent controlableComponent = new ControlableComponent();

        public bool isControlable {
            get { return HasComponent(CoreComponentIds.Controlable); }
            set {
                if (value != isControlable) {
                    if (value) {
                        AddComponent(CoreComponentIds.Controlable, controlableComponent);
                    } else {
                        RemoveComponent(CoreComponentIds.Controlable);
                    }
                }
            }
        }

        public Entity IsControlable(bool value) {
            isControlable = value;
            return this;
        }
    }

    public partial class Pool {
        public Entity controlableEntity { get { return GetGroup(CoreMatcher.Controlable).GetSingleEntity(); } }

        public bool isControlable {
            get { return controlableEntity != null; }
            set {
                var entity = controlableEntity;
                if (value != (entity != null)) {
                    if (value) {
                        CreateEntity().isControlable = true;
                    } else {
                        DestroyEntity(entity);
                    }
                }
            }
        }
    }
}

    public partial class CoreMatcher {
        static IMatcher _matcherControlable;

        public static IMatcher Controlable {
            get {
                if (_matcherControlable == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Controlable);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherControlable = matcher;
                }

                return _matcherControlable;
            }
        }
    }
