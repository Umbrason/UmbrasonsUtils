using UnityEngine;

public struct Cached<T>
{
    private GetOption getOption;
    public enum GetOption
    {
        OnlySelf, Parent, Children
    };

    private T cached_value;

    public Cached(GetOption getOption = GetOption.OnlySelf)
    {
        this.getOption = getOption;
        cached_value = default;
    }

    public T this[Component owner] { get => cached_value ??= get(owner); }

    private T get(Component owner)
    {
        switch (getOption)
        {
            case GetOption.OnlySelf: return owner.GetComponent<T>();
            case GetOption.Parent: return owner.GetComponentInParent<T>();
            case GetOption.Children: return owner.GetComponentInChildren<T>();
        }
        return default;
    }
}