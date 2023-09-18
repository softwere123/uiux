using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class /*static*/ UIutiliy : MonoBehaviour
{
    public Stack<GameObject> pageTrace = new Stack<GameObject>();

    public void OpenPage(GameObject_Input);
    {
        pageTrace.push(_Input);
    }
    public ReturnPage()
    {
      pageTrace.Pop();
    }


}
