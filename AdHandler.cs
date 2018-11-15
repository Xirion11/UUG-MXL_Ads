using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdHandler : MonoBehaviour {

	bool m_isShowingAd = false;
	string m_placementId = "rewardedVideo";

	public void GUI_ShowRewardedAd()
	{
		if(!m_isShowingAd)
		{
			if(Advertisement.IsReady(m_placementId))
			{
				ShowOptions options = new ShowOptions {resultCallback = HandleShowResult};
				Advertisement.Show(m_placementId, options);
				m_isShowingAd = true;
			}
		}
	}

	private void HandleShowResult(ShowResult result)
	{
		switch(result)
		{
			case ShowResult.Finished:
			break;

			case ShowResult.Skipped:
			break;

			case ShowResult.Failed:
			break;
		}

		m_isShowingAd = false;
	}
		
}
