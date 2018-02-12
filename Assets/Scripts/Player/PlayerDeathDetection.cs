using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathDetection : StateMachineBehaviour
{
    PlayerHealth playerHealth;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("Die", false);
        animator.SetBool("Revival", true);

        playerHealth = animator.GetComponent<PlayerHealth>();
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("Revival", false);

        if (playerHealth.lifeCount > 0) playerHealth.Revive();
    }
}
