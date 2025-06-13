using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class JMBMovementManager : JMonoBehaviour
{

    /**
     * 최고 이동 속력. 현재 이동 속도가 가질 수 있는 최고값.
     */
    [SerializeField]
    protected float maximumMovementSpeed;

    /**
     * 이동 가속력. 이동을 시작했을 때 이동 속력을 연속적으로 상승시키는 크기이다.
     * 단위는 m/s.
     */
    [SerializeField]
    protected float movementAcceleration;
    
    /**
     * 현재 이동 속력. 현재 플레이어가 가진 속력.
     * 틱에서 강체 속력이 이동 방향과 현재 이동 속력이 곱연산된 값으로 초기화 된다.
     * 값의 범위는 0 보다 크거나 같고 maximumMovementSpeed 보다 작거나 같다.
     */
    protected float currentMovementSpeed;
    
    protected Vector3 divertingMovementVelocity;
    
    protected Vector3 currentMovementVelocity;

    private Rigidbody rigidbodyComponent;
    
    
    public override void OnConstructed()
    {
        base.OnConstructed();
        
        rigidbodyComponent = GetComponent<Rigidbody>();
        
        doTickUpdate = true;

        currentMovementSpeed = 0;
    }

    public override void Tick(float deltaTime)
    {
        base.Tick(deltaTime);
        
        divertingMovementVelocity = divertingMovementVelocity.normalized * maximumMovementSpeed;

        currentMovementVelocity += (divertingMovementVelocity - currentMovementVelocity).normalized * movementAcceleration * deltaTime;

        rigidbodyComponent.linearVelocity = currentMovementVelocity;
        
        divertingMovementVelocity = Vector3.zero;
    }

    public void InputMovementDirection(Vector3 movementDirection)
    {
        divertingMovementVelocity += movementDirection;
    }
    
}
