using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class GameObject
    {

    public Vector2 GameObjectPosition;

    public List<Component> objectComponents = new List<Component>();
    //public List<T> objectComponents = new List<T>();


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