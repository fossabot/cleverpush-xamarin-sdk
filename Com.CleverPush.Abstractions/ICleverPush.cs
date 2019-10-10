using System;
using System.Collections.Generic;

namespace Com.CleverPush.Abstractions
{
   public interface ICleverPush
   {
      XamarinBuilder StartInit(string channelId);

      void Subscribe();
	  void Unsubscribe();
	}
}
