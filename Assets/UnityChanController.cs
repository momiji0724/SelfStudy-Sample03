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
        StartCoroutine(GetGameIterator());
    }
    private bool _isGameOver = false;
    IEnumerator GetGameIterator() 
    {
        yield return new WaitForSeconds(30);
        _isGameOver = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (_isGameOver) { return; }
        var v = Input.GetAxis("Vertical");
        transform.Translate(0, 0, v * 0.05f);
        _animator.SetFloat("Speed", v);

        var h = Input.GetAxis("Horizontal");
        transform.Rotate(0, h*2, 0);
        _animator.SetFloat("Direction", h);


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
    private int _itemPoint = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name != "Stage") 
        {
            _itemPoint += 10;
            Destroy(collision.gameObject);
        }
        
    }

    private void OnGUI()
    {
        GUIStyle labelStyle = new GUIStyle();
        labelStyle.fontSize = 40; // 文字の大きさ
        labelStyle.normal.textColor = Color.white; // 文字の色

        GUI.Label(new Rect(20, 20, 300, 50), "Point: " + _itemPoint, labelStyle);

        if (_isGameOver)
        {
            GUIStyle centerStyle = new GUIStyle(labelStyle); // labelStyleをコピー
            centerStyle.alignment = TextAnchor.MiddleCenter; // 中央揃えにする
            centerStyle.fontSize = 80; // ゲームオーバーは少し大きく
            centerStyle.normal.textColor = Color.red; // 赤色にする

            float w = 400;
            float h = 100;
            float x = (Screen.width - w) / 2;
            float y = (Screen.height - h) / 2;

            GUI.Label(new Rect(x, y, w, h), "GameOver!", centerStyle);
        }
    }
}

