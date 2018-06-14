using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CoreTweet;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace trendrakuten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private OAuth.OAuthSession Session;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Session = OAuth.Authorize("[API Key]",
                 "[API Secret]");
            System.Diagnostics.Process.Start(this.Session.AuthorizeUri.ToString());
        }

        private Tokens tokens;

        private void button2_Click(object sender, EventArgs e)
        {
            tokens = OAuth.GetTokens(Session, textBox1.Text);
            var home = tokens.Trends.Place(1117817);
            JArray ahome = JArray.Parse(home.Json);

            int tcount = ahome[0]["trends"].Count();
            string[] trend = new string[tcount];

            for (int i = 0; i < tcount; i++)
            {
                trend[i] = (string)ahome[0]["trends"][i]["name"];
            }

            foreach (var value in trend)
            {
                listBox1.Items.Add(value);
            }
        }

        private JObject jobj;
        private void listboxselect(object sender, EventArgs e)
        {
            string item;
            item = listBox1.SelectedItem.ToString();
            if (item.Substring(0, 1) == "#")
            {
                item = item.Substring(1, item.Length - 1);
            }

            string baseUrl = "https://app.rakuten.co.jp/services/api/IchibaItem/Search/20170706?" +
                             "applicationId=[アプリID]&";
            //パラメーターと検索キーワード
            string parameter = "keyword";
            string value = item;

            string url = $"{baseUrl}{parameter}={value}&imageFlag=1&";
            string json = new HttpClient().GetStringAsync(url).Result;

            jobj = JObject.Parse(json);

            if (jobj["Items"].Count() == 0)
            {
                MessageBox.Show("商品が見つかりませんでした。", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            link1.Text = (string)jobj["Items"][0]["Item"]["itemName"];
            
            if ((int)jobj["Items"][0]["Item"]["postageFlag"] == 0)
            {
                souryo1.Text = "送料込";
            }
            else if ((int)jobj["Items"][0]["Item"]["postageFlag"] == 1)
            {
                souryo1.Text = "送料別";
            }
            kakaku1.Text = (int)jobj["Items"][0]["Item"]["itemPrice"] + "円";


            var imageurl = from p in jobj["Items"][0]["Item"]["mediumImageUrls"]
                            select (string)p["imageUrl"];
            List<string> urllist = new List<string>();
            foreach (string u in imageurl)
            {
                urllist.Add(u);
            }
            itempic1A.ImageLocation = urllist[0];
            if (imageurl.Count() == 3)
            {
                itempic1B.ImageLocation = urllist[1];
                itempic1C.ImageLocation = urllist[2];
            }
            else if (imageurl.Count() == 2)
            {
                itempic1B.ImageLocation = urllist[1];
            }

            biko1.Text = (string)jobj["Items"][0]["Item"]["itemCaption"];
            

        }
        private void link1click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link1.LinkVisited = true;
            System.Diagnostics.Process.Start((string)jobj["Items"][0]["Item"]["itemUrl"]);
        }
    }
}
