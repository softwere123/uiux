using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LopinUI : MonoBehaviour
{
    // �α��� �����ִ� ��� ���� ���� ��Ÿ ���
    // Start is called before the first frame update
    public List<int> haha = new List<int>();

    // ���ð� ����Ʈ�� ��ã�ƿ��� ����� ���̴� ������ ���� �����ϴ� ������ �׾ƿø��°��̰� �߰����� ���ü�����
    public Stack<GameObject> hoho = new Stack<GameObject>();
    public Queue<GameObject> hihi = new Queue<GameObject>();
    public void OnClick_Login()
    {
        Login();
       
        Debug.Log("�α��μ���");
    }
    private void ReturnPage() { 
        
    }
    //ui�� �ε�ȭ���� ������ ���Ե��� �������Ӿʱ� ���� �ִ°� ������ ���� ���� ������Ÿ�Ը� �ϼ��ߴ� ���� �ؾ��Ұ��� ���� �ٵ�°�
    //
    public void OnClick_GoToGegist()
    {
        gameObject.SetActive(false);
        GameObject RegistUI = new GameObject();
        RegistUI.SetActive(true);

        uiui.openPage(RegistUI);

    }

    //���� �Ȼ������ 
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
