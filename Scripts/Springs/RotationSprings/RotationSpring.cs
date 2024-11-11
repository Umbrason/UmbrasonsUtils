using System;
using UnityEngine;

public class RotationSpring : ISpring<float>
{
    public RotationSpring(float angularFrequency, float dampingRatio) : this(new(angularFrequency, dampingRatio)) { }
    public RotationSpring(Spring.Config config)
    {
        this.config = config;
        spring = new(config);
    }
    public float AngularFrequency { get => config.AngularFrequency; set { config.AngularFrequency = value; } }
    public float DampingRatio { get => config.DampingRatio; set { config.DampingRatio = value; } }
    private readonly BaseSpring spring;
    private readonly Spring.Config config;

    public float Position
    {
        get => spring.Position;
        set
        {
            var delta = Mathf.DeltaAngle(spring.Position, value);
            spring.Position += delta;
        }
    }
    public float Velocity { get => spring.Velocity; set => spring.Velocity = value; }
    public float RestingPos
    {
        get => spring.RestingPos;
        set
        {
            var delta = Mathf.DeltaAngle(spring.RestingPos, value);
            spring.RestingPos += delta;
        }
    }


    public event Action<float> OnSpringUpdated;

    public void Step(float deltaTime)
    {
        spring.Position = Mod360(spring.Position);
        spring.RestingPos = ClosestAngleRepresentation(spring.RestingPos, spring.Position);
        spring.Step(deltaTime);
        OnSpringUpdated?.Invoke(spring.Position);
    }

    float ClosestAngleRepresentation(float angle, float other)
    {
        var deltaAngle = other - angle;
        if (deltaAngle < -180) return angle - 360f;
        if (deltaAngle > 180) return angle + 360f;
        return angle;
    }

    float Mod360(float angle)
    {
        while (angle < 0) angle += 360;
        return angle % 360;
    }
}