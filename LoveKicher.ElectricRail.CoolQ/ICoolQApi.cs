

namespace LoveKicher.ElectricRail.CoolQ
{
    public interface ICoolQApi
    {
        int AddLog(int 优先级, string 类型, string 内容);
        int DeleteMsg(long MsgId);
        string GetAppDirectory();
        string GetCookies();
        int GetCsrfToken();
        string GetGroupList();
        string GetGroupMemberInfo(long 群号, long QQID);
        string GetGroupMemberInfoV2(long 群号, long QQID, bool 不使用缓存);
        string GetGroupMemberList(long 群号);
        string GetLoginNick();
        long GetLoginQQ();
        string GetRecord(string file, string outformat);
        string GetStrangerInfo(long QQID, bool 不使用缓存);
        int SendDiscussMsg(long 讨论组号, string msg);
        int SendGroupMsg(long 群号, string msg);
        int SendLike(long QQID);
        int SendLikeV2(long QQID, int times);
        int SendPrivateMsg(long QQID, string msg);
        int SetDiscussLeave(long 讨论组号);
        int SetFatal(string 错误信息);
        int SetFriendAddRequest(string 请求反馈标识, int 反馈类型, string 备注);
        int SetGroupAddRequest(string 请求反馈标识, int 请求类型, int 反馈类型);
        int SetGroupAddRequestV2(string 请求反馈标识, int 请求类型, int 反馈类型, string 理由);
        int SetGroupAdmin(long 群号, long QQID, bool 成为管理员);
        int SetGroupAnonymous(long 群号, bool 开启匿名);
        int SetGroupAnonymousBan(long 群号, string 匿名, long 禁言时间);
        int SetGroupBan(long 群号, long QQID, long 禁言时间);
        int SetGroupCard(long 群号, long QQID, string 新名片_昵称);
        int SetGroupKick(long 群号, long QQID, bool 拒绝再加群);
        int SetGroupLeave(long 群号, bool 是否解散);
        int SetGroupSpecialTitle(long 群号, long QQID, string 头衔, long 过期时间);
        int SetGroupWholeBan(long 群号, bool 开启禁言);
    }
}