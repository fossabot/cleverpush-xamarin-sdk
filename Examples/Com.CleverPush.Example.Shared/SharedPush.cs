using System;
using System.Collections.Generic;
using System.Diagnostics;

using Com.CleverPush;
using Com.CleverPush.Abstractions;

namespace Com.CleverPush.Example.Shared
{
   public static class SharedPush
   {
      public static void Initialize()
      {
         CleverPush.Current.StartInit("7R8nkAxtrY5wy5TsS")
			.HandleNotificationOpened((result) =>
            {
               Debug.WriteLine("CleverPush HandleNotificationOpened: {0}", result.notification.title);
            })
           .HandleNotificationReceived((result) =>
           {
              Debug.WriteLine("CleverPush HandleNotificationReceived: {0}", result.notification.title);
           })
		   .HandleSubscribed((subscriptionId) =>
		   {
			   Debug.WriteLine("CleverPush HandleSubscribed: {0}", subscriptionId);
		   })
           .EndInit();
      }
	
      public static void Subscribe()
      {
         CleverPush.Current.Subscribe();
		}

		public static void Unsubscribe()
		{
			CleverPush.Current.Unsubscribe();
		}
	}
}
