using Android.App;
using Android.Content;
using System;
using Com.CleverPush.Abstractions;
using System.Collections.Generic;

namespace Com.CleverPush
{
   public class CleverPushImplementation : CleverPushShared, ICleverPush
   {
		public void Init(string channelId)
		{
			Android.CleverPush.GetInstance(Application.Context).Init(channelId, null, null, null, true);
		}

		public override void InitPlatform()
		{
			Init(builder.mChannelId);
		}

		public override void Subscribe()
		{
			Android.CleverPush.GetInstance(Application.Context).Subscribe();
		}

		public override void Unsubscribe()
		{
			Android.CleverPush.GetInstance(Application.Context).Unsubscribe();
		}

		public override void ShowTopicsDialog()
		{
			Android.CleverPush.GetInstance(Application.Context).ShowTopicsDialog();
		}

		public void ShowTopicsDialog(Context context)
		{
			Android.CleverPush.GetInstance(Application.Context).ShowTopicsDialog(context);
		}
	}
}
