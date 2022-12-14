/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

// <copyright file="CommonErrorStatus.cs" company="Google Inc.">
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

#if (UNITY_ANDROID || (UNITY_IPHONE && !NO_GPGS))

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class CommonErrorStatus
    {
        internal enum ResponseStatus
        {
            VALID = 1,
            VALID_BUT_STALE = 2,
            ERROR_LICENSE_CHECK_FAILED = -1,
            ERROR_INTERNAL = -2,
            ERROR_NOT_AUTHORIZED = -3,
            ERROR_VERSION_UPDATE_REQUIRED = -4,
            ERROR_TIMEOUT = -5,
        }

        internal enum FlushStatus
        {
            FLUSHED = 4,
            ERROR_INTERNAL = -2,
            ERROR_NOT_AUTHORIZED = -3,
            ERROR_VERSION_UPDATE_REQUIRED = -4,
            ERROR_TIMEOUT = -5,
        }

        internal enum AuthStatus
        {
            VALID = 1,
            ERROR_INTERNAL = -2,
            ERROR_NOT_AUTHORIZED = -3,
            ERROR_VERSION_UPDATE_REQUIRED = -4,
            ERROR_TIMEOUT = -5,
        }

        internal enum UIStatus
        {
            VALID = 1,
            ERROR_INTERNAL = -2,
            ERROR_NOT_AUTHORIZED = -3,
            ERROR_VERSION_UPDATE_REQUIRED = -4,
            ERROR_TIMEOUT = -5,
            ERROR_CANCELED = -6,
            ERROR_UI_BUSY = -12,
            ERROR_LEFT_ROOM = -18,
        }

        internal enum MultiplayerStatus
        {
            VALID = 1,
            VALID_BUT_STALE = 2,
            ERROR_INTERNAL = -2,
            ERROR_NOT_AUTHORIZED = -3,
            ERROR_VERSION_UPDATE_REQUIRED = -4,
            ERROR_TIMEOUT = -5,
            ERROR_MATCH_ALREADY_REMATCHED = -7,
            ERROR_INACTIVE_MATCH = -8,
            ERROR_INVALID_RESULTS = -9,
            ERROR_INVALID_MATCH = -10,
            ERROR_MATCH_OUT_OF_DATE = -11,
            ERROR_REAL_TIME_ROOM_NOT_JOINED = -17,
        }

        internal enum QuestAcceptStatus
        {
            VALID = 1,
            ERROR_INTERNAL = -2,
            ERROR_NOT_AUTHORIZED = -3,
            ERROR_TIMEOUT = -5,
            ERROR_QUEST_NO_LONGER_AVAILABLE = -13,
            ERROR_QUEST_NOT_STARTED = -14,
        }

        internal enum QuestClaimMilestoneStatus
        {
            VALID = 1,
            ERROR_INTERNAL = -2,
            ERROR_NOT_AUTHORIZED = -3,
            ERROR_TIMEOUT = -5,
            ERROR_MILESTONE_ALREADY_CLAIMED = -15,
            ERROR_MILESTONE_CLAIM_FAILED = -16,
        }

        internal enum SnapshotOpenStatus
        {
            VALID = 1,
            VALID_WITH_CONFLICT = 3,
            ERROR_INTERNAL = -2,
            ERROR_NOT_AUTHORIZED = -3,
            ERROR_TIMEOUT = -5,
        }
    }
}
#endif // (UNITY_ANDROID || UNITY_IPHONE)
