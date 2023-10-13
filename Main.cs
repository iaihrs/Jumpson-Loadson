using Loadson;
using LoadsonAPI;
using System.Reflection;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

namespace Jumpson
{
    internal class Main : Mod
    {
        public override void Update(float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Type jump = typeof(PlayerMovement);
                FieldInfo jumpForce = jump.GetField("jumpForce", BindingFlags.NonPublic | BindingFlags.Instance);
                jumpForce.SetValue(PlayerMovement.Instance, 1500);
            }
        }
    }
}
