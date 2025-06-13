using UnityEngine;



[RequireComponent(typeof(JMBMovementManager))]
public class JMBControllerManager : JMonoBehaviour
{
    
    private JMBMovementManager movementComponent;


    public override void OnConstructed()
    {
        base.OnConstructed();

        doTickUpdate = true;
        
        movementComponent = GetComponent<JMBMovementManager>();
    }

    public override void Tick(float deltaTime)
    {
        base.Tick(deltaTime);
        
        // 테스트용 임시 구현. 레거시 입력 시스템을 사용함.

        if (Input.GetKey(KeyCode.A))
        {
            movementComponent.InputMovementDirection(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementComponent.InputMovementDirection(new Vector3(1, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            movementComponent.InputMovementDirection(new Vector3(0, 0, 1));
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementComponent.InputMovementDirection(new Vector3(0, 0, -1));
        }
    }
}
