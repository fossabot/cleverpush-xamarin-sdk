using System;
using System.Diagnostics;
using Com.CleverPush.Abstractions;

namespace Com.CleverPush
{
   public class CleverPush
   {
      static readonly Lazy<ICleverPush> Implementation = new Lazy<ICleverPush>(CreateCleverPush);

      public static ICleverPush Current
      {
         get
         {
            if (Implementation.Value == null)
            {
               throw NotImplementedInReferenceAssembly();
            }
            return Implementation.Value;
         }
      }

      static ICleverPush CreateCleverPush()
      {
#if PORTABLE
         Debug.WriteLine("PORTABLE Reached");
         return null;
#else
         Debug.WriteLine("Other reached");
         return new CleverPushImplementation();
#endif
      }

      internal static Exception NotImplementedInReferenceAssembly()
      {
         return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
      }
   }
}
