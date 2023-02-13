using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string _gameId = "5160865";
    [SerializeField] bool _testMode = true;

    [SerializeField] RewardedAdsButton rewardedAdsButton;

    void Awake()
    {
        InitializeAds();
    }

    public void InitializeAds()
    {
        Advertisement.Initialize(_gameId, _testMode, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
        rewardedAdsButton.LoadAd();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }
}