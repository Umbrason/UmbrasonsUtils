using System;
using UnityEngine;

public class RotationVector3Spring : ISpring<Vector3>
{
    public Vector3 Position { get => new(rx.Position, ry.Position, rz.Position); set => (rx.Position, ry.Position, rz.Position) = (value.x, value.y, value.z); }
    public Vector3 Velocity { get => new(rx.Velocity, ry.Velocity, rz.Velocity); set => (rx.Velocity, ry.Velocity, rz.Velocity) = (value.x, value.y, value.z); }
    public Vector3 RestingPos { get => new(rx.RestingPos, ry.RestingPos, rz.RestingPos); set => (rx.RestingPos, ry.RestingPos, rz.RestingPos) = (value.x, value.y, value.z); }
    private readonly RotationSpring rx;
    private readonly RotationSpring ry;
    private readonly RotationSpring rz;
    private readonly Spring.Config config;

    public RotationVector3Spring(float angularFrequency, float dampingRatio) : this(new(angularFrequency, dampingRatio)) { }
    public RotationVector3Spring(Spring.Config config)
    {
        this.config = config;
        rx = new(config);
        ry = new(config);
        rz = new(config);
    }

    public float AngularFrequency { get => config.AngularFrequency; set { config.AngularFrequency = value; } }
    public float DampingRatio { get => config.DampingRatio; set { config.DampingRatio = value; } }

    public event Action<Vector3> OnSpringUpdated;

    public void Step(float deltaTime)
    {
        rx.Step(deltaTime);
        ry.Step(deltaTime);
        rz.Step(deltaTime);
        OnSpringUpdated?.Invoke(Position);
    }
}
