using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UserInfo")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI balanceText;
    public TextMeshProUGUI cashText;

    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        var user = DataManager.Instance.user;
                
        nameText.text = user.UserName;

        balanceText.text = string.Format("Balance  {0:N0}", user.Balance);

        cashText.text = string.Format("{0:N0}", user.Cash);
                
    }

}
