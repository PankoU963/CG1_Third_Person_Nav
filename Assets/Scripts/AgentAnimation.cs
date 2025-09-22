using UnityEngine;

public class AgentAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string movementSpeed = "MovementSpeed";

    public void SetSpeed(float speed)
    {
        animator.SetFloat(movementSpeed, speed);
    }
}
