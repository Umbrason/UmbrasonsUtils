using System;
using UnityEngine;

public interface ISpring<T>
{
    T Position { get; set; }
    T Velocity { get; set; }
    T RestingPos { get; set; }
    event Action<T> OnSpringUpdated;
    void Step(float deltaTime);
}

[Serializable]
public class Spring
{
    [Serializable]
    public class Config
    {
        [field: SerializeField] public float AngularFrequency { get; set; } = 20f;
        [field: SerializeField] public float DampingRatio { get; set; } = .6f;

        public Config(float angularFrequency, float dampingRatio)
        {
            AngularFrequency = angularFrequency;
            DampingRatio = dampingRatio;
        }
    }
}