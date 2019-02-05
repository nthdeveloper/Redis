using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Redis;

namespace PubSubSample
{
    public partial class FrmPubSubSample : Form
    {
        const string UnsubscribeMessage = "#EXIT#";

        IRedisClient redisClient;
        IRedisSubscription redisSubscription;
        bool unsubscribeSimple;
        bool unsubscribeByPattern;

        public FrmPubSubSample()
        {
            InitializeComponent();            
        }

        private void publishMessage(string channel, string message)
        {
            using (var publisherClient = new RedisClient(txtRedisHost.Text, (int)numRedisPort.Value))
            {
                publisherClient.PublishMessage(channel, message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (redisClient == null)
            {
                redisClient = new RedisClient(txtRedisHost.Text, (int)numRedisPort.Value);

                redisSubscription = redisClient.CreateSubscription();

                redisSubscription.OnMessage = (channel, message) =>
                {
                    if (message == UnsubscribeMessage)
                    {
                        if (unsubscribeSimple)
                        {                            
                            redisSubscription.UnSubscribeFromChannels(txtUnsubscribeChannelName.Text);
                            unsubscribeSimple = false;
                        }
                        else if (unsubscribeByPattern)
                        {
                            redisSubscription.UnSubscribeFromChannelsMatching(txtUnsubscribeChannelPattern.Text);
                            unsubscribeByPattern = false;
                        }
                    }
                    else
                    {
                        this.BeginInvoke(new Action(()=> txtMessages.AppendText(channel + ":" + message + "\r\n")));
                    }
                };
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (redisClient != null)
            {
                redisClient.Dispose();

                redisClient = null;
                redisSubscription = null;
            }
        }

        private void btnSimpleSubscribe_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
                {
                    redisSubscription.SubscribeToChannels(txtSimpleChannelName.Text);                    
                });
        }

        private void btnSubscribeByPattern_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
                {
                    redisSubscription.SubscribeToChannelsMatching(txtChannelPattern.Text);                    
                });
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            publishMessage(txtPublishChannelName.Text, txtMessage.Text);
        }

        private void btnSimpleUnsubscribe_Click(object sender, EventArgs e)
        {
            unsubscribeSimple = true;

            publishMessage(txtPublishChannelName.Text, UnsubscribeMessage);            
        }

        private void btnUnsubscribeByPattern_Click(object sender, EventArgs e)
        {
            unsubscribeByPattern = true;

            publishMessage(txtUnsubscribeChannelPattern.Text, UnsubscribeMessage);
        }
    }
}