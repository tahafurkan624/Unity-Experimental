using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Utility;
using Random = UnityEngine.Random;

namespace Test
{
    public class ObjectSpawner : MonoBehaviour
    {
        [SerializeField] private List<Transform> objects = new List<Transform>();

        [SerializeField] private int spawnAmount;
        
        private IEnumerator Start()
        {
            for (int i = 0; i < spawnAmount; i++)
            {
                var pos = (Vector3.up * 8 + (Vector3.right * Random.Range(-5,5)) + (Vector3.forward * Random.Range(-5,5)));
                var obj = Instantiate(objects[Random.Range(0, objects.Count)], pos, Helper.RandomRotation(), transform);
                var renderObject = obj.AddComponent<RenderObject>();
                renderObject.Init();

                yield return new WaitForSeconds(.32f);
            }
        }

        [System.Serializable]
        public class RenderObject : MonoBehaviour
        {
            public Renderer Renderer;

            public void Init()
            {
                Renderer = transform.GetComponent<Renderer>();
            }
        }
    }
}