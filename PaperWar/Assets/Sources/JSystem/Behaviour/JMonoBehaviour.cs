using UnityEngine;

public class JMonoBehaviour : MonoBehaviour
{

    protected bool doTickUpdate = false;
    
    
    public virtual void OnConstructed()
    {
    }

    public virtual void Initialize()
    {
    }

    public virtual void DeInitialize()
    {
    }

    public virtual void Begin()
    {
    }

    public virtual void Tick(float deltaTime)
    {
    }
    
    private void Awake()
    {
        OnConstructed();
    }

    private void Start()
    {
        
    }
    
    private void Update()
    {
        if (doTickUpdate) return;
        
        Tick(Time.deltaTime);
    }

    private void OnEnable()
    {
        Initialize();
    }

    private void OnDisable()
    {
        DeInitialize();
    }

    private void OnDestroy()
    {
    }
}
