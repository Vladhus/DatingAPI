using DatingAPI.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.SignalR
{
    [Authorize]
    public class PresenceHub : Hub
    {
        private readonly PrasenceTracker tracker;

        public PresenceHub(PrasenceTracker tracker)
        {
            this.tracker = tracker;
        }
        public override async Task OnConnectedAsync()
        {
            var isOnline = await tracker.UserConnected(Context.User.GetUserName(), Context.ConnectionId);
            if(isOnline)
            {
                await Clients.Others.SendAsync("UserIsOnline", Context.User.GetUserName());
            }
            

            var currentUsers = await tracker.GetOnlineUsers();
            await Clients.Caller.SendAsync("GetOnlineUsers", currentUsers);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var isOfflne = await tracker.UserDisconnected(Context.User.GetUserName(), Context.ConnectionId);
            if (isOfflne)
            {
                await Clients.Others.SendAsync("UserIsOffline", Context.User.GetUserName());
            }
            
            await base.OnDisconnectedAsync(exception);
        }
    }
}
