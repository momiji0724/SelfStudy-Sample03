using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Jump", false);
    }

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical");
        transform.Translate(0, 0, v * -0.05f);
        _animator.SetFloat("Speed", v);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _animator.SetBool("Jump", true);
        }
        var state = _animator.GetCurrentAnimatorStateInfo(0);
        if (state.IsName("Jump")) 
        {
            _animator.SetBool("Jump",false);
        }
    }
}
