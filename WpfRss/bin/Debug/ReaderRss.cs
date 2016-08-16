using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;
using rssDTO;
using System.Xml;
using System.ServiceModel.Syndication;

namespace rssLibrary
{
    /// <summary>
    /// Reader Library
    /// </summary>
    public class ReaderRss
    {
        public List<Feeds> PopulateRssFeed()
        {

            string rssFeedUrl = ConfigurationManager.AppSettings["RssFeedUrl"];
            List<Feeds> feeds = new List<Feeds>();
            XmlReader reader;
            SyndicationFeed feed;

            try
            {
                 reader = XmlReader.Create(rssFeedUrl);
                 feed = SyndicationFeed.Load(reader);
            }
            catch (XmlException ex)
            {
                throw ex;
            }

            foreach (SyndicationItem synd in feed.Items)
            {

                Feeds myFeed = new Feeds();
                try
                {
                    myFeed.Title = synd.Title.Text;
                    if (synd.Links.FirstOrDefault() != null)
                    {
                        myFeed.Link = synd.Links.FirstOrDefault().Uri.ToString();
                    }else{
                        myFeed.Link="#";
                    }
                    myFeed.Description = synd.Summary.Text;
                    myFeed.PublishDate = synd.PublishDate.ToString("dd/MM/yyyy HH:ss");
                    if (synd.Authors.FirstOrDefault() != null)
                    {
                        myFeed.Author = synd.Authors.FirstOrDefault().ToString();
                    }
                    else
                    {
                        myFeed.Author = "";
                    }
                   
                }
                catch(Exception ex)
                {
                    myFeed.Title = string.Format("Error - {0}",ex.ToString());
                }
                feeds.Add(myFeed);
            }
            return feeds.OrderByDescending(s=>s.PublishDate).ToList();
        }
    }


}



