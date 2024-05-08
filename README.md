# Binding.Intercom

![Nuget](https://img.shields.io/nuget/v/nventive.Binding.Intercom)

## Summary

The following binding are for the **Intercom SDK**.

## Android

Documentation for using the library inside an Android project can be found [here](https://developers.intercom.com/docs/welcome).

The source for the SDK can be found [here](https://github.com/intercom/intercom-android). 

The bindings were generated for the version **12.2.0**.

### Note

The library supports GCM push notifications but only the Firebase push notifications binding has been generated. The GCM binding should be generated if needed.

We generated the FCM bindings but never got the chance to test it as this is only needed if you app does not include custom *FirebaseInstanceIdService* and *FirebaseMessagingService* services.

### How to use

Add a reference to the following packages:

- Uno.Binding.Intercom.Android
- Uno.Binding.Intercom.Android.Fcm -> Optional: this is needed if you don't have a custom Firebase services. (See note above)

#### Permissions
We include the [INTERNET](https://developer.android.com/reference/android/Manifest.permission.html#INTERNET) permission by default as we need it to make network requests:

```
<uses-permission android:name="android.permission.INTERNET"/>
```

Optional permissions:

```
<uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE"/>
<uses-permission android:name="android.permission.MANAGE_DOCUMENTS"/>
```
[READ_EXTERNAL_STORAGE](https://developer.android.com/reference/android/Manifest.permission.html#READ_EXTERNAL_STORAGE) and [MANAGE_DOCUMENTS](https://developer.android.com/reference/android/Manifest.permission.html#MANAGE_DOCUMENTS) are used for attachments.

The necessary GCM permissions ([WAKE_LOCK](https://developer.android.com/reference/android/Manifest.permission.html#WAKE_LOCK) and [RECEIVE](https://developers.google.com/cloud-messaging/gcm#manifest)) are also included by default in the main package.

```
<uses-permission android:name="android.permission.WAKE_LOCK" />
<uses-permission android:name="com.google.android.c2dm.permission.RECEIVE" />
```

You can also include [VIBRATE](https://developer.android.com/reference/android/Manifest.permission.html#VIBRATE) to enable vibration in push notifications:

```
<uses-permission android:name="android.permission.VIBRATE"/>
```

## iOS

Documentation for using the library inside an iOS project can be found [here](https://developers.intercom.com/docs/welcome).

The source for the SDK can be found [here](https://github.com/intercom/intercom-ios). 

By default inside Intercom.framework folder, we use ios-arm64_armv7 to be able to deploy on physical device. If you need to deploy on Simulator, you will need to replace the content with ios-arm64_i386_x86_64-simulator.

The bindings were generated for the version **16.6.6**.

### How to use

Add a reference to the following packages:

- Uno.Binding.Intercom.iOS

### Update Info.plist

When installing Intercom, you'll need to make sure that you have a `NSPhotoLibraryUsageDescription` and `NSCameraUsageDescription` entries in your `Info.plist`.

This is [required by Apple](https://developer.apple.com/library/content/qa/qa1937/_index.html) for all apps that access the photo library and camera. It is necessary when installing Intercom due to the image upload functionality. Users will be prompted for the photo library and camera permissions only when they tap the image upload button.

## Breaking Changes

Please consult [BREAKING_CHANGES.md](BREAKING_CHANGES.md) for more information about migration.