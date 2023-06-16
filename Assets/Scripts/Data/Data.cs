using System.Collections;
using System.Collections.Generic;
using TooLoo;
using UnityEngine;

namespace ssj12062023
{
    public class Data : ScriptableObject
    {
        [SerializeField, ReadOnly] protected string uid = string.Empty;
        public string UID => uid;

        public void GenerateUID()
        {
            string uniqueId = System.Guid.NewGuid().ToString();
            if (uid.Equals(uniqueId)) return;

            uid = uniqueId;
        }
    }
}
