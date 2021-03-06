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
        public EfxSoundComponent efxSound { get { return (EfxSoundComponent)GetComponent(InputComponentIds.EfxSound); } }

        public bool hasEfxSound { get { return HasComponent(InputComponentIds.EfxSound); } }

        public Entity AddEfxSound(Res.audios newClip) {
            var component = CreateComponent<EfxSoundComponent>(InputComponentIds.EfxSound);
            component.clip = newClip;
            return AddComponent(InputComponentIds.EfxSound, component);
        }

        public Entity ReplaceEfxSound(Res.audios newClip) {
            var component = CreateComponent<EfxSoundComponent>(InputComponentIds.EfxSound);
            component.clip = newClip;
            ReplaceComponent(InputComponentIds.EfxSound, component);
            return this;
        }

        public Entity RemoveEfxSound() {
            return RemoveComponent(InputComponentIds.EfxSound);
        }
    }
}

    public partial class InputMatcher {
        static IMatcher _matcherEfxSound;

        public static IMatcher EfxSound {
            get {
                if (_matcherEfxSound == null) {
                    var matcher = (Matcher)Matcher.AllOf(InputComponentIds.EfxSound);
                    matcher.componentNames = InputComponentIds.componentNames;
                    _matcherEfxSound = matcher;
                }

                return _matcherEfxSound;
            }
        }
    }
