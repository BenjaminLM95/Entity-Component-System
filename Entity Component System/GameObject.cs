using Microsoft.Xna.Framework;
using System.Collections.Generic;


 public class GameObject
    {

    public Vector2 GameObjectPosition;

    public List<Component> objectComponents = new List<Component>();    


    public void AddComponent(Component newComponent) 
    {
        objectComponents.Add(newComponent); 
    }

    public T GetComponent<T>() where T : Component
    {
        foreach (Component component in objectComponents)
        {
            if (component is T tComponent)
            {
                return tComponent;
            }
        }
        return null;
    }

    public void RemoveComponent(Component ComponentToDelete) 
    {
        objectComponents.Remove(ComponentToDelete); 
    }
    }