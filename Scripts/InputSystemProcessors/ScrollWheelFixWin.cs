
using UnityEngine;
using UnityEngine.InputSystem;

#if UNITY_EDITOR
[UnityEditor.InitializeOnLoad]
#endif
public class ScrollWheelFixWin : InputProcessor<float>
{
    public override float Process(float value, InputControl control)
    {
#if UNITY_STANDALONE_WIN
        value /= 120f;
#endif
        return value;
    }

    #if UNITY_EDITOR
    static ScrollWheelFixWin()
    {
        Initialize();
    }
    #endif

    [RuntimeInitializeOnLoadMethod]
    static void Initialize()
    {
        InputSystem.RegisterProcessor<ScrollWheelFixWin>();
    }
}
