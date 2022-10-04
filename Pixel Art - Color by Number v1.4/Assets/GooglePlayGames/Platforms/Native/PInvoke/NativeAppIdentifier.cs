/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

// <copyright file="NativeAppIdentifier.cs" company="Google Inc.">
// Copyright (C) 2014 Google Inc.
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

namespace GooglePlayGames.Native.PInvoke
{
    using GooglePlayGames.Native.Cwrapper;
    using System;
    using System.Runtime.InteropServices;

    using C = GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes;
    using Types = GooglePlayGames.Native.Cwrapper.Types;

    internal class NativeAppIdentifier : BaseReferenceHolder
    {

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern IntPtr NearbyUtils_ConstructAppIdentifier(string appId);

        internal NativeAppIdentifier(IntPtr pointer)
            : base(pointer)
        {
        }

        internal string Id()
        {
            return PInvokeUtilities.OutParamsToString(
                (out_arg, out_size) => C.AppIdentifier_GetIdentifier(SelfPtr(), out_arg, out_size));
        }

        protected override void CallDispose(HandleRef selfPointer)
        {
            C.AppIdentifier_Dispose(selfPointer);
        }

        internal static NativeAppIdentifier FromString(string appId)
        {
            return new NativeAppIdentifier(NearbyUtils_ConstructAppIdentifier(appId));
        }
    }
}
#endif // #if (UNITY_ANDROID)
