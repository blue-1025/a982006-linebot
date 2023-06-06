using Line.Messaging;
using Line.Messaging.Webhooks;

namespace A982006_linebot;

public class LineBotApp : WebhookApplication
{
    private readonly LineMessagingClient _messagingClient;
    public LineBotApp(LineMessagingClient lineMessagingClient)
    {
        _messagingClient = lineMessagingClient;
    }

    protected async Task OnMessageAsync(MessageEvent ev)
    {
        var result = null as List<ISendMessage>;

        switch (ev.Message)
        {
            //文字訊息
            case TextEventMessage textMessage:
            {
                //頻道Id
                var channelId = ev.Source.Id;
                //使用者Id
                var userId = ev.Source.UserId;
                    
                TextEventMessage
                    
                //回傳 hellow
                result = new List<ISendMessage>
                {
                    new TextMessage("你好啊")
                };
            }
                break;
        }

        if (result != null)
            await _messagingClient.ReplyMessageAsync(ev.ReplyToken, result);
    }

    public async Task RunAsync(IEnumerable<WebhookEvent> events)
    {
        throw new NotImplementedException();
    }
}

public class WebhookApplication
{
}