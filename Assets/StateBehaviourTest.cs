using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class StateBehaviourTest : StateMachineBehaviour
{
    [SerializeField]
    private GameObject thisThingyHere;
    private GameObject spawnedThingy;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        Debug.Log(animator.gameObject.name + " " + animatorStateInfo.shortNameHash + " entered");
        spawnedThingy = Instantiate(thisThingyHere);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        Debug.Log(animator.gameObject.name + " " + animatorStateInfo.shortNameHash + " exited");
        Destroy(spawnedThingy);
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Active: " + animator.gameObject.name);
    }
}
