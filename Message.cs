//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

    public class Message : MonoBehaviour
    {
        string message;
        bool targetMessage;
        public Message(string message, bool targetMessage)
        {
            this.message = message;
            this.targetMessage = targetMessage;
        }

        public string getMessage()
        {
            return message;
        }

        public bool getTargetMessage()
        {
            return targetMessage;
        }
    }


