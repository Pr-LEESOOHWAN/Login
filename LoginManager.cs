using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class LoginManager : MonoBehaviour
{
    public GameObject LoginView;
    public GameObject InfoView;
    public TMP_InputField inputField_ID;
    public TMP_InputField inputField_Pw;
    public Button Button_Login;
    private LoginHandler loginHandler;

    void Start(){

        loginHandler = gameObject.AddComponent<LoginHandler>();
        loginHandler.Initialize(this);
        
        
    }

    void Update()
    {
    
    }

   public void LoginButtonClick(){
    loginHandler.HandleLogin();
   }

   public void ValuleChanged(string text){
    Debug.Log(text+ "-글자 입력 중");
   }

   public void OnEnd(string text){
    Debug.Log(text + "를 입력함");
   }
}



