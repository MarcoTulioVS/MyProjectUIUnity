using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VampireButton : MonoBehaviour
{
    public Animator anim;

    public void VampireAnimation()
    {
        anim.SetTrigger("action");
    }
}
