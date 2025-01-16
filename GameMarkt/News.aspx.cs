using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml;

namespace GameMarkt
{
    public partial class News : Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            var news = await GetIGNNews();

            if (!string.IsNullOrEmpty(news))
            {
                newsContainer.InnerHtml = news;
            }
        }

        private async Task<string> GetIGNNews()
        {
            // IGN RSS Feed URL'si
            var url = "https://feeds.ign.com/ign/all";

            try
            {
                using (var client = new HttpClient())
                {
                    // User-Agent ve Accept başlıklarını ekle
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Accept", "application/rss+xml, application/xml;q=0.9, */*;q=0.8");

                    // RSS feed'ini indir
                    var response = await client.GetStringAsync(url);

                    // XML Parse işlemi
                    var xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(response);

                    var items = xmlDoc.GetElementsByTagName("item");
                    var htmlContent = new StringBuilder();

                    foreach (XmlNode item in items)
                    {
                        var title = item["title"]?.InnerText ?? "No Title";
                        var link = item["link"]?.InnerText ?? "#";
                        var pubDate = item["pubDate"]?.InnerText ?? "No Date";
                        var description = item["description"]?.InnerText ?? "No Description";
                        var contentEncoded = item["content:encoded"]?.InnerText ?? "No Content";
                        var mediaThumbnail = item["media:thumbnail"]?.InnerText ?? "No Image";

                        htmlContent.Append($@"
                            <div class='news-item' style='margin: auto; margin-bottom:40px; width:800px; padding: 30px; background-color: #fff; border: 1px solid #ddd; border-radius: 8px; box-shadow: 0 8px 12px rgba(0, 0, 0, 0.1); display: flex; flex-direction: column;'>
                                <h3 style='font-size: 18px; color: #333; font-weight: bold;'>
                                    <a href='{link}' target='_blank' style='text-decoration: none; color: #007bff;'>{title}</a>
                                </h3>
                                <p style='font-size: 14px; color: #555;'><strong>Published:</strong> {pubDate}</p>
                                <p style='font-size: 14px; color: #555;'><strong>Description:</strong> {description}</p>
                                <p style='font-size: 14px; color: #555;'><strong>Content:</strong> {contentEncoded.Substring(0, 150)}...</p>
                                <p style='font-size: 14px; color: #555;'>
                                    <strong>Image:</strong>
                                    <img src='{mediaThumbnail}' alt='Image' style='max-width: 100%; height: 200px; object-fit: cover; border-radius: 8px;'>
                                </p>
                                <a href='{link}' target='_blank' style='text-decoration: none; background-color: #007bff; color: white; padding: 10px 20px; border-radius: 5px; text-align: center; width: fit-content; margin-top: 15px;'>Devamını Oku</a>
                            </div>");
                    }

                    return htmlContent.ToString();
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
