using dislite.src.API;
using Microsoft.Web.WebView2.WinForms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dislite.src.UTILS
{
    internal class Parser
    {
        public async static Task ParseContext(string x, WebView2 wv2)
        {
            if (x == null) { MessageBox.Show("Message received was null"); };

            if (x.Contains("[DISLITEPROXY_MSG]"))
            {
                var msg = x.Replace("[DISLITEPROXY_MSG]", "");
                await Discord.SendMessage(msg, UserData.currentChannel);
                //await MessageLoader.TryLoadMessage(wv2, null);
            }

            if (x.Contains("[DISLITEPROXY_CIDUPDATE]"))
            {
                var id = x.Replace("[DISLITEPROXY_CIDUPDATE]", "");
                await wv2.ExecuteScriptAsync($"setChannelId('{id}');");
                if (!UserData.hasClickedChannel)
                    await wv2.ExecuteScriptAsync("listen();");
                
                UserData.hasClickedChannel = true;
                UserData.currentChannel = id;
                await wv2.ExecuteScriptAsync("clearMessages();");
                await MessageLoader.TryLoadMessages(wv2, id);
            }

            if (x.Contains("[DISLITEPROXY_SERVER]"))
            {
                var id = x.Replace("[DISLITEPROXY_SERVER]", "");
                await wv2.ExecuteScriptAsync("clearChannels();");
                foreach (var item in await Discord.ListChannels(id))
                {
                    // send right back to javascript, our beloved.
                    await wv2.ExecuteScriptAsync($"createChannel('{item.Name}', '{item.Id}', '{item.Type}');");
                }
                await wv2.ExecuteScriptAsync("clearMessages();");
            }
        }
    }
}
