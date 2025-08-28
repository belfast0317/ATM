using UnityEngine;

[System.Serializable]
public class UserData
{
    public string UserName;
    public int Balance;
    public int Cash;       

    public UserData(string userName, int balance, int cash)
    {
        UserName = userName;
        Balance = balance;
        Cash = cash;
    }
}

