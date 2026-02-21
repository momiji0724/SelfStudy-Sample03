using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sample02 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text = null;
    public void OnClick() 
    {
        text.text = "It was clicked";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
