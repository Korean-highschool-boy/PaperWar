using UnityEngine;



public class JMonoBehaviour : MonoBehaviour
{

    protected bool doTickUpdate = false;
    
    
    public virtual void OnConstructed()
    {
        JLog("OnConstructed");
    }

    public virtual void OnDestructed()
    {
        JLog("OnDestructed");
    }

    public virtual void Initialize()
    {
        JLog("Initialize");
    }

    public virtual void DeInitialize()
    {
        JLog("DeInitialize");
    }

    public virtual void Begin()
    {
        JLog("Begin");
    }

    public virtual void Tick(float deltaTime)
    {
        JLog("Tick");
    }

    protected void JLog(string message)
    {
        Debug.Log(GetInstanceID() + " : " + message);
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
        OnDestructed();
    }
}
