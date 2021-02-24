using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controler;
    public Animator animator;
    public float horizontalmove = 0f;
    public float runspeed = 40f;
    bool jump = false;
    bool crouch = false;
    private bool temp = false;

    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalmove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Fire3"))
        {
            temp = true;
            StartCoroutine(Parkor());
        }
        if (Input.GetButtonDown("Fire2"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            crouch = false;
        }
    }
    void FixedUpdate()
    {
        controler.Move(horizontalmove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    IEnumerator Parkor()
    {
        yield return new WaitForSeconds(0.2f);
        temp = false;
    }
}
