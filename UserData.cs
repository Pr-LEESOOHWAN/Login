using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData
{
    public static string EnteredID {get; private set;}

    public static void SetEnteredID(string enteredID){
        EnteredID = enteredID;
    }
}
