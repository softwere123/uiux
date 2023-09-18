using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LopinUI : MonoBehaviour
{
    // 로그인 시켜주는 기능 서버 인증 오타 등등
    // Start is called before the first frame update
    public List<int> haha = new List<int>();

    // 스택과 리스트의 ㅂ찾아오는 방식의 차이는 스택이 좀더 저렴하다 위에서 쌓아올리는것이고 중간에서 빼올수없다
    public Stack<GameObject> hoho = new Stack<GameObject>();
    public Queue<GameObject> hihi = new Queue<GameObject>();
    public void OnClick_Login()
    {
        Login();
       
        Debug.Log("로그인성공");
    }
    private void ReturnPage() { 
        
    }
    //ui의 로딩화면은 게임의 몰입도롤 놓ㅊ지ㅣ않기 위해 넣는것 컨셉을 나는 지금 프로토타입만 완성했다 지금 해야할것은 전부 다듬는것
    //
    public void OnClick_GoToGegist()
    {
        gameObject.SetActive(false);
        GameObject RegistUI = new GameObject();
        RegistUI.SetActive(true);

        uiui.openPage(RegistUI);

    }

    //정보 안사라지게 
    private void Login()
    { 
       
    }
 


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
