<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplayRss.aspx.cs" Inherits="DisplayRss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- Optional theme -->
 <%--   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" />--%>

    <link href="Css/web.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
  <%--  <script src="js/bootstrap.min.js"></script>--%>
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <h1>MSDN CHANNEL 9 RSS</h1>
            </div>
            <asp:GridView ID="gridRSS" runat="server" AutoGenerateColumns="false" ShowHeader="false" Width="100%" GridLines="None">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div class="panel panel-primary" >
                                <div class="panel-heading">
                                        <h3><%#Eval("Title") %></h3>
                                </div>
                                <div class="row panel-body">
                                    <div class="col-md-12">
                                        <%#Eval("Description") %>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-9">
                                        <%#Eval("PublishDate") %>
                                        <%#Eval("Author") %>
                                    </div>
                                    <div class="col-md-3">
                                        <a href='<%#Eval("Link") %>' target="_blank" class="text-right">Read More...</a>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
