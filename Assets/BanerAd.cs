using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class BanerAd : MonoBehaviour
{
    public string gameId = "3495603";
    public string placementId = "Baner";
    public bool testMode = true;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(placementId);
        yield return new WaitForSeconds(15.0f);
        Advertisement.Banner.Hide();
    }
}