namespace AsteroidsW;
// ReSharper disable all MemberCanBePrivate.Global 
// ReSharper disable all MemberCanBeProtected.Global
public abstract class GameObject
{
    protected readonly List<GameObject> Children = new();
    
    public virtual void OnLoad()
    {
        foreach (var child in Children)
            child.OnLoad();
    }

    public virtual void OnUpdateFrame(double deltaTime)
    {
        foreach (var child in Children)
            child.OnUpdateFrame(deltaTime);
    }

    public virtual void OnRenderFrame(double deltaTime)
    {
        foreach (var child in Children)
            child.OnRenderFrame(deltaTime);
    }

    public virtual void OnUnload()
    {
        foreach (var child in Children)
            child.OnUnload();
    }

    public void AddChild(GameObject child) => Children.Add(child);
}