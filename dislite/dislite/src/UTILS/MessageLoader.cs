using dislite.src.API;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dislite.src.UTILS
{
    internal class MessageLoader
    {
        public async static Task TryLoadMessages(WebView2 wv2, string id)
        {
            if (id is null)
            {
                id = "1188171362641125389";
            }

            try
            {
                var messages = await Discord.FetchMessages(id, 70);

                var messagesJson = JsonConvert.SerializeObject(messages);
                var jsCode = $"displayMessages(`{messagesJson}`);";
                await wv2.ExecuteScriptAsync(jsCode);
            }
			catch (Exception e)
			{
                MessageBox.Show(e.Message);
			}
        }

        public async static Task TryLoadMessage(WebView2 wv2, string id)
        {
            if (id is null)
            {
                id = "1188171362641125389";
            }

            try
            {
                var messages = await Discord.FetchMessages(id, 1);

                var messagesJson = JsonConvert.SerializeObject(messages);
                var jsCode = $"displayMessages('{messagesJson}');";

                await wv2.ExecuteScriptAsync(jsCode);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
