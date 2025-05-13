using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    CharacterController charac;
    Animator anim;

    [System.Serializable]
    public class AnimationStrings
    {
        public string forward = "forward";
        public string strafe = "strafe";
        public string sprint = "sprint";
        public string aim = "aim";
        public string pull = "pullString";
        public string fire = "fire";
    }
    [SerializeField]
    public AnimationStrings animationStrings;
    // Start is called before the first frame update
    void Start()
    {
        charac = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AnimateCharacter(float forward, float strafe)
    {
        anim.SetFloat(animationStrings.forward, forward);
        anim.SetFloat(animationStrings.strafe, strafe);
    }
    public void SprintCharacter(bool isSprinting)
    {
        anim.SetBool(animationStrings.sprint, isSprinting);
    }

    public void CharacterAim(bool aiming)
    {
        anim.SetBool(animationStrings.aim, aiming);
    }
    public void CharacterPullString(bool pull)
    {
        anim.SetBool(animationStrings.pull, pull);
    }
    public void CharacterFireArrow()
    {
        anim.SetTrigger(animationStrings.fire);
    }

}
