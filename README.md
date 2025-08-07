# CleverPush Xamarin SDK
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fcleverpush%2Fcleverpush-xamarin-sdk.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fcleverpush%2Fcleverpush-xamarin-sdk?ref=badge_shield)


## Release new version:

1. Build project in Release mode
2. Pack NuGet package:
  nuget pack

## Run example project

1. Switch from Debug to Release mode
2. Build iOS/Android Binding projects
3. Switch back to Debug Mode
4. Run Example projects


## Update iOS SDK

Update Binding:
```
cd CleverPush.iOS.Binding
sharpie pod bind -n Com.CleverPush.iOS

```
Convert XIB to NIB files:
```
find . -name "*.xib" -type f | awk '{sub(/.xib/,"");print}' | xargs -I % ibtool --compile %.nib %.xib
```

## License
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fcleverpush%2Fcleverpush-xamarin-sdk.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Fcleverpush%2Fcleverpush-xamarin-sdk?ref=badge_large)