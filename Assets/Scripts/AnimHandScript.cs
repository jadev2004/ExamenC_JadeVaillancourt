using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]

public class AnimHandScript : MonoBehaviour
{
    private float _gripValue;
    private float _triggerValue;

    [SerializeField] private InputActionReference gripInputActionReference;
    [SerializeField] private InputActionReference triggerInputActionReference;

    private Animator _handsAnimator;
  
    void Start()
    {

       _handsAnimator =  GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimateGrip();
    }

    private void AnimateGrip()
    {

        _gripValue = gripInputActionReference.action.ReadValue<float>();
        _handsAnimator.SetFloat("Grip", _gripValue);
    }

}
