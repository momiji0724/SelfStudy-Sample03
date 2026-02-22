using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample04 : MonoBehaviour
{
    [SerializeField]
    private GameObject _content = null;

    [SerializeField]
    private GameObject _itemPrefab = null;
    // Start is called before the first frame update
    void Start()
    {
        for(var i =0; i<10; i++) 
        {
            var item = Instantiate<GameObject>(_itemPrefab);
            item.transform.SetParent(_content.transform, false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
