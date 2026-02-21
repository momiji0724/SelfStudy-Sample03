using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sample01 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = $"{Time.time}";
    }
}
