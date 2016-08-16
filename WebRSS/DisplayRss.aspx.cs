using rssLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class DisplayRss : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.PopulateRssFeed();
    }

    private void PopulateRssFeed()
    {
        ReaderRss reader = new ReaderRss();
        gridRSS.DataSource = reader.PopulateRssFeed() ;
        gridRSS.DataBind();
    }
  
}