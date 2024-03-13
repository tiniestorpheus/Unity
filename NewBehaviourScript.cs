using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changecolour : MonoBehaviour
{
    [SerializeField]
    private GameObject sphere;

    private Renderer sphereRenderer;

    private Color newSphereColor;

    private float randomChannelOne, randomChannelTwo, randomChannelThree;
    void Start()
    {
        sphereRenderer = sphere.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeSphereColor);
    }

    private void ChangeSphereColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newSphereColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        sphereRenderer.material.SetColor("_Color", newSphereColor);
    }

}
