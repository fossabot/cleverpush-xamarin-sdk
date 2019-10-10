using System;
using System.Collections.Generic;
using CleverPush.Abstractions;
using Org.Json;

namespace CleverPush
{
	public class EmailUpdateHandler : Java.Lang.Object, Android.CleverPush.IEmailUpdateHandler
	{
		readonly OnSetEmailSuccess _success;
		readonly OnSetEmailFailure _failure;

		public EmailUpdateHandler(OnSetEmailSuccess success, OnSetEmailFailure failure)
		{
			_success = success;
			_failure = failure;
		}

		public void OnSuccess()
		{
			_success?.Invoke();
		}

		public void OnFailure(Android.CleverPush.EmailUpdateError error)
		{
			if (_failure == null)
				return;

			var result = new Dictionary<string, object>() { { "message", error.Message } };
			_failure(result);
		}
	}
}
