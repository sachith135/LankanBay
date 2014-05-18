<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageBoxTemplete.aspx.cs" Inherits="LankanBay.admin.MessageBoxTemplete" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow)
                oWindow = window.radWindow;
            else if (window.frameElement && window.frameElement.radWindow)
                oWindow = window.frameElement.radWindow;                           
            return oWindow;

            
        }
        function CloseModal() {
            // GetRadWindow().close();
            setTimeout(function () {
                GetRadWindow().close();
            }, 0);
        }

        

</script>

    <style type="text/css">
        .style1
        {
            width: 500px;
            height: 120px;
        }
        .header
        {
            background: rgb(109,179,242); /* Old browsers */
background: -moz-linear-gradient(top,  rgba(109,179,242,1) 0%, rgba(84,163,238,1) 50%, rgba(54,144,240,1) 51%, rgba(30,105,222,1) 100%); /* FF3.6+ */
background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(109,179,242,1)), color-stop(50%,rgba(84,163,238,1)), color-stop(51%,rgba(54,144,240,1)), color-stop(100%,rgba(30,105,222,1))); /* Chrome,Safari4+ */
background: -webkit-linear-gradient(top,  rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* Chrome10+,Safari5.1+ */
background: -o-linear-gradient(top,  rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* Opera 11.10+ */
background: -ms-linear-gradient(top,  rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* IE10+ */
background: linear-gradient(to bottom,  rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#6db3f2', endColorstr='#1e69de',GradientType=0 ); /* IE6-9 */
font-family: "Trebuchet MS";

        }
        .style3
        {
            background: rgb(109,179,242);
/* Old browsers */background: -moz-linear-gradient(top, rgba(109,179,242,1) 0%, rgba(84,163,238,1) 50%, rgba(54,144,240,1) 51%, rgba(30,105,222,1) 100%); /* FF3.6+ */;
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(109,179,242,1)), color-stop(50%,rgba(84,163,238,1)), color-stop(51%,rgba(54,144,240,1)), color-stop(100%,rgba(30,105,222,1))); /* Chrome,Safari4+ */;
            background: -webkit-linear-gradient(top, rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* Chrome10+,Safari5.1+ */;
            background: -o-linear-gradient(top, rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* Opera 11.10+ */;
            background: -ms-linear-gradient(top, rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* IE10+ */;
            background: rgb(109,179,242); /* W3C */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#6db3f2', endColorstr='#1e69de',GradientType=0 ); /* IE6-9 */;
            font-family: "Trebuchet MS";
            font-size: small;
            padding:5px;
            color:White;
        }
        .style4
        {
            font-size: small;
            font-family: "Trebuchet MS";
        }
        .style6
        {
            font-family: "Trebuchet MS";
            font-size: x-small;
        }
        td
        {
            vertical-align:top;
        }
        .style8
        {
            width: 4px;
        }
        </style>
</head>
<body style="background-color:#f2f2f2">


    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="2" class="style1">
            <tr>
                <td class="style3" colspan="3">
                    <strong>Messege From LankanBay.Com</strong></td>
            </tr>
            <tr>
                <td  rowspan="3" class="style8">
                    <asp:Image ID="Image1" runat="server"  
                        Width="60px" />
                </td>
                <td class="style4" rowspan="2" style="vertical-align:middle">
                    <asp:Label ID="lblMessage" runat="server" 
                        style="font-weight: 700; font-style: italic" 
                        Text="Operation successfully done !"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right" colspan="2">
                    <asp:Button ID="btnOk" runat="server" Text="OK" Width="80px" 
                        onclick="btnOk_Click" />
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
