using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationHands : MonoBehaviour
{
    [SerializeField] private InputActionReference gripReference;
    [SerializeField] private InputActionReference triggerRefence;
    [SerializeField] private Animator handAnimation;

    private void Update() 
    {
        float gripValue = gripReference.action.ReadValue<float>();
        handAnimation.SetFloat("Grip", gripValue);
        float triggerValue = triggerRefence.action.ReadValue<float>();
        handAnimation.SetFloat("Trigger", triggerValue);
    }

}
