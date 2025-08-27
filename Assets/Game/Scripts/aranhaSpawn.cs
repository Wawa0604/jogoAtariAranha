using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aranhaSpawn : MonoBehaviour
{


    // Criar uma corotina para instanciar 12 prefabs, a cada 0.5 segundos
    // segundo de modo que cada um deles faça um lerp para um
    // GameObject aleatorio de um array de gameobjects


    public GameObject prefab;                    // Prefab a ser instanciado
    public Transform[] targetPoints;             // Alvos possíveis
    private float spawnInterval = 1f;           // Intervalo entre instâncias
    private int numberOfPrefabs = 10;             // Quantidade total de instâncias
    // private float moveDuration = 2f;              // Tempo de Lerp até o alvo

    // public float riseDistance = 10f;
    // public float riseDuration = 10f;

    void Start()
    {
        StartCoroutine(SpawnPrefabsCoroutine());
    }

    public IEnumerator SpawnPrefabsCoroutine()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            GameObject instance = Instantiate(prefab, transform.position, Quaternion.identity);

            // Escolhe um alvo aleatório do array
            // Transform randomTarget = targetPoints[Random.Range(0, targetPoints.Length)];

            // Inicia a corrotina para mover esse objeto até o alvo
           // StartCoroutine(MoveToTarget(instance.transform, randomTarget.position, moveDuration));

            yield return new WaitForSeconds(spawnInterval);
        }
    }










    /*

   IEnumerator MoveToTarget(Transform objTransform, Vector3 targetPos, float duration)
   {
       Vector3 startPos = objTransform.position;
       float elapsed = 0f;

       while (elapsed < duration)
       {
           float t = elapsed / duration;
           objTransform.position = Vector3.Lerp(startPos, targetPos, t);
           elapsed += Time.deltaTime;
           yield return null;
       }

       objTransform.position = targetPos;

       // Subida após chegar ao alvo
       yield return StartCoroutine(RiseUp(objTransform));
   }

   IEnumerator RiseUp(Transform objTransform)
   {
       Vector3 startPos = objTransform.position;
       Vector3 endPos = startPos + Vector3.up * riseDistance;

       float elapsed = 0f;
       float speed = riseDistance / riseDuration; // velocidade constante

       while (elapsed < riseDuration)
       {
           float step = speed * Time.deltaTime;
           objTransform.position += Vector3.up * step;
           elapsed += Time.deltaTime;
           yield return null;
       }

       // Corrige a posição final com precisão
       objTransform.position = endPos;
   }

   */
}
