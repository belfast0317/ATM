using UnityEngine;
using UnityEngine.UI;

public class DepositManager : MonoBehaviour
{        
    public GameObject directInputPanel; 
    public ATMUIManager atmUIManager; 
                
    public void DepositCustom()
    {
        directInputPanel.SetActive(true);              
    }
       
    public void Back()
    {       
        if (atmUIManager != null)
        {
            atmUIManager.OnBackClick();
        }
        else
        {
            Debug.LogError("ATM UIManager ��ũ��Ʈ�� ������� �ʾҽ��ϴ�.");
        }
    }
}
