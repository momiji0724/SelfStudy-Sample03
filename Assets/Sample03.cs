using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sample03 : MonoBehaviour
{
    [SerializeField]
    private Slider slider = null;

    [SerializeField]
    private TextMeshProUGUI text = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = slider.value.ToString("00.00");
    }
}
