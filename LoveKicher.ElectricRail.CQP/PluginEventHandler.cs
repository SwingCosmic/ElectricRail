using Newbe.Mahua;
using Newbe.Mahua.MahuaEvents;
using System;

namespace LoveKicher.ElectricRail.CQP
{
    /// <summary>
    /// 插件事件处理导出器
    /// </summary>
    public sealed  class PluginEventHandler
        : IInitializationMahuaEvent,
        IPluginEnabledMahuaEvent,
        IPluginDisabledMahuaEvent,
        IPrivateMessageReceivedMahuaEvent,
        IGroupMessageReceivedMahuaEvent,
        IDiscussMessageReceivedMahuaEvent,
        IFriendAddedMahuaEvent,
        IFriendAddingRequestMahuaEvent,
        IGroupAdminChangedMahuaEvent,
        IGroupAdminEnabledMahuaEvent,
        IGroupAdminDisabledMahuaEvent,
        IGroupJoiningRequestReceivedMahuaEvent

    {
        private readonly IMahuaApi _mahuaApi;

        public PluginEventHandler(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void Disable(PluginDisabledContext context)
        {
            throw new NotImplementedException();
        }

        public void Enabled(PluginEnabledContext context)
        {
            throw new NotImplementedException();
        }

        public void Initialized(InitializedContext context)
        {
            // todo 填充处理逻辑
            throw new NotImplementedException();
            
            // 不要忘记在MahuaModule中注册
        }

        public void ProcessAddingFriendRequest(FriendAddingRequestContext context)
        {
            throw new NotImplementedException();
        }

        public void ProcessDiscussGroupMessageReceived(DiscussMessageReceivedMahuaEventContext context)
        {
            throw new NotImplementedException();
        }

        public void ProcessFriendsAdded(FriendAddedMahuaEventContext context)
        {
            throw new NotImplementedException();
        }

        public void ProcessGroupAdminChange(GroupAdminChangedContext context)
        {
            throw new NotImplementedException();
        }

        public void ProcessGroupAdminDisabled(GroupAdminDisabledContext context)
        {
            throw new NotImplementedException();
        }

        public void ProcessGroupAdminEnabled(GroupAdminEnabledContext context)
        {
            throw new NotImplementedException();
        }

        public void ProcessGroupMessage(GroupMessageReceivedContext context)
        {
            throw new NotImplementedException();
        }

        public void ProcessJoinGroupRequest(GroupJoiningRequestReceivedContext receivedContext)
        {
            throw new NotImplementedException();
        }

        public void ProcessPrivateMessage(PrivateMessageReceivedContext context)
        {
            throw new NotImplementedException();
        }
    }
}
