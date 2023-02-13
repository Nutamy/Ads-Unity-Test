using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAd : MonoBehaviour
{

    [SerializeField] BannerPosition _bannerPosition = BannerPosition.BOTTOM_CENTER;

    [SerializeField] string _adUnitId = "5160865";

    void Start()
    {
        Advertisement.Banner.SetPosition(_bannerPosition);

        LoadBanner();
    }

    public void LoadBanner()
    {
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };

        Advertisement.Banner.Load(_adUnitId, options);
    }

    void OnBannerLoaded()
    {
        Debug.Log("Banner loaded");
        ShowBannerAd();
    }

    void OnBannerError(string message)
    {
        Debug.Log($"Banner Error: {message}");
    }

    void ShowBannerAd()
    {
        BannerOptions options = new BannerOptions
        {
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden,
            showCallback = OnBannerShown
        };

        Advertisement.Banner.Show(_adUnitId, options);
    }

    void HideBannerAd()
    {
        Advertisement.Banner.Hide();
    }

    void OnBannerClicked() { }
    void OnBannerShown() { }
    void OnBannerHidden() { }

    void OnDestroy() { }
}