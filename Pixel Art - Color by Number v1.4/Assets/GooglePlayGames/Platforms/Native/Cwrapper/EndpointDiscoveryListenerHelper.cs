/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

// <copyright file="EndpointDiscoveryListenerHelper.cs" company="Google Inc.">
// Copyright (C) 2014 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>

// Android only feature
#if (UNITY_ANDROID)

namespace GooglePlayGames.Native.Cwrapper {
    using System;
    using System.Runtime.InteropServices;

    internal static class EndpointDiscoveryListenerHelper {
        internal delegate void OnEndpointFoundCallback(
         /* from(int64_t) */ long arg0,
         /* from(EndpointDetails_t) */ IntPtr arg1,
         /* from(void *) */ IntPtr arg2);

        internal delegate void OnEndpointLostCallback(
         /* from(int64_t) */ long arg0,
         /* from(char const *) */ string arg1,
         /* from(void *) */ IntPtr arg2);

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern /* from(EndpointDiscoveryListenerHelper_t) */ IntPtr EndpointDiscoveryListenerHelper_Construct();

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointLostCallback(
            HandleRef self,
            /* from(EndpointDiscoveryListenerHelper_OnEndpointLostCallback_t) */ OnEndpointLostCallback callback,
            /* from(void *) */ IntPtr callback_arg);

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointFoundCallback(
            HandleRef self,
            /* from(EndpointDiscoveryListenerHelper_OnEndpointFoundCallback_t) */ OnEndpointFoundCallback callback,
            /* from(void *) */ IntPtr callback_arg);

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern void EndpointDiscoveryListenerHelper_Dispose(
            HandleRef self);
    }
}
#endif // (UNITY_ANDROID || UNITY_IPHONE)
