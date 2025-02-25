

 public abstract class Component
    {   


    public GameObject gameObject { get; private set; }

    public string ComponentName; 

    public void Initialize(GameObject _gameObject) 
    {
        gameObject = _gameObject;
    }

    public string getComponentName() 
    {
        return ComponentName; 
    }
      

    }

