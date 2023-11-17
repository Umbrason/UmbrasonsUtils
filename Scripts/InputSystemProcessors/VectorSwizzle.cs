using UnityEngine;
using UnityEngine.InputSystem;

#if UNITY_EDITOR
[UnityEditor.InitializeOnLoad]
#endif
public class VectorSwizzleProcessor : InputProcessor<Vector2>
{
    public enum SwizzleType
    {
        XY,
        YX,
        XX,
        YY
    }

    public SwizzleType swizzleType = SwizzleType.XY;

    public override Vector2 Process(Vector2 value, InputControl control)
    {
        switch (swizzleType)
        {
            case SwizzleType.XY:
                return new Vector2(value.x, value.y);
            case SwizzleType.YX:
                return new Vector2(value.y, value.x);
            case SwizzleType.XX:
                return new Vector2(value.x, value.x);
            case SwizzleType.YY:
                return new Vector2(value.y, value.y);
            default:
                return value;
        }
    }

    #if UNITY_EDITOR
    static VectorSwizzleProcessor()
    {
        Initialize();
    }
    #endif

    [RuntimeInitializeOnLoadMethod]
    static void Initialize()
    {
        InputSystem.RegisterProcessor<VectorSwizzleProcessor>();
    }
}