//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.PoolsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public static class Pools {

    static Pool[] _allPools;

    public static Pool[] allPools {
        get {
            if (_allPools == null) {
                _allPools = new [] { core, input, bullets };
            }

            return _allPools;
        }
    }

    static Pool _core;

    public static Pool core {
        get {
            if (_core == null) {
                _core = new Pool(CoreComponentIds.TotalComponents, 0, new PoolMetaData("Core Pool", CoreComponentIds.componentNames, CoreComponentIds.componentTypes));
                #if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)
                if (UnityEngine.Application.isPlaying) {
                    var poolObserver = new Entitas.Unity.VisualDebugging.PoolObserver(_core);
                    UnityEngine.Object.DontDestroyOnLoad(poolObserver.entitiesContainer);
                }
                #endif
            }

            return _core;
        }
    }

    static Pool _input;

    public static Pool input {
        get {
            if (_input == null) {
                _input = new Pool(InputComponentIds.TotalComponents, 0, new PoolMetaData("Input Pool", InputComponentIds.componentNames, InputComponentIds.componentTypes));
                #if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)
                if (UnityEngine.Application.isPlaying) {
                    var poolObserver = new Entitas.Unity.VisualDebugging.PoolObserver(_input);
                    UnityEngine.Object.DontDestroyOnLoad(poolObserver.entitiesContainer);
                }
                #endif
            }

            return _input;
        }
    }

    static Pool _bullets;

    public static Pool bullets {
        get {
            if (_bullets == null) {
                _bullets = new Pool(BulletsComponentIds.TotalComponents, 0, new PoolMetaData("Bullets Pool", BulletsComponentIds.componentNames, BulletsComponentIds.componentTypes));
                #if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)
                if (UnityEngine.Application.isPlaying) {
                    var poolObserver = new Entitas.Unity.VisualDebugging.PoolObserver(_bullets);
                    UnityEngine.Object.DontDestroyOnLoad(poolObserver.entitiesContainer);
                }
                #endif
            }

            return _bullets;
        }
    }
}