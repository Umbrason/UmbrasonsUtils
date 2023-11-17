using System;
using UnityEngine;

public class RotationVector2Spring : ISpring<Vector2>
{
    public Vector2 Position { get => new(rx.Position, ry.Position); set => (rx.Position, ry.Position) = (value.x, value.y); }
    public Vector2 Velocity { get => new(rx.Velocity, ry.Velocity); set => (rx.Velocity, ry.Velocity) = (value.x, value.y); }
    public Vector2 RestingPos { get => new(rx.RestingPos, ry.RestingPos); set => (rx.RestingPos, ry.RestingPos) = (value.x, value.y); }
    private readonly RotationSpring rx;
    private readonly RotationSpring ry;
    private readonly Spring.Config config;

    public RotationVector2Spring(float angularFrequency, float dampingRatio) : this(new(angularFrequency, dampingRatio)) { }
    public RotationVector2Spring(Spring.Config config)
    {
        this.config = config;
        rx = new(config);
        ry = new(config);
    }

    public float AngularFrequency { get => config.AngularFrequency; set { config.AngularFrequency = value; } }
    public float DampingRatio { get => config.DampingRatio; set { config.DampingRatio = value; } }

    public event Action<Vector2> OnSpringUpdated;

    public void Step(float deltaTime)
    {
        rx.Step(deltaTime);
        ry.Step(deltaTime);
        OnSpringUpdated?.Invoke(Position);
    }
}
