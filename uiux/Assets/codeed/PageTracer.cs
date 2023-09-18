using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageTracer : MonoBehaviour
{
    public static Stack<GameObject> stackedPage = new Stack<GameObject>();
    // Start is called before the first frame update
    // 어려워도 끝까지 해봐라 될때 까지

    public static void OpenPage(GameObject _nextpage, GameObject _prePage, bool isOpenOnly = false, Action _action = null )
    {
        if (stackedPage.Count < 1)
            stackedPage.Push(_prePage);
        _action?.Push(_nextpage);

        _nextpage SetActive(true);
        if (!_isOpenOnly)
            _prePage.SetActive(false);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
