<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userregistration.aspx.cs" Inherits="LankanBay.userregistration" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/adminmaster.css" rel="stylesheet" type="text/css" />
    <link href="styles/sitemaster.css" rel="stylesheet" type="text/css" />
    <link href="styles/jQuery.fancybox.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 650px;
            height: 400px;
        }
        .style2
        {
            width: 10px;
        }
        .style3
        {
        }
        .style4
        {
            width: 22px;
        }
        .style5
        {
            width: 208px;
        }
        .style6
        {
            width: 20px;
        }
        .style7
        {
        }
        .style8
        {
            width: 8px;
        }
        .style9
        {
            font-weight: bold;
            font-style: italic;
            color: #003366;
        }
        .style10
        {
        }
        

    </style>

    <script>

        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow)
                oWindow = window.radWindow;
            else if (window.frameElement.radWindow)
                oWindow = window.frameElement.radWindow;
            return oWindow;
        }

        function Close() {
            var oWindow = GetRadWindow();
            oWindow.argument = null;
            oWindow.close();
            return false;
        }
    </script>

</head>
<body style="background-color:#F2F2F2">


    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="8">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/userresgistration.png" 
                        Width="450px" />
                        <hr class="itemSeparator" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                 </td>
                <td class="style10">
                    User Type</td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <telerik:RadComboBox ID="cmbUserType" Runat="server" AutoPostBack="True" 
                        onselectedindexchanged="cmbUserType_SelectedIndexChanged" Width="204px">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="Customer" Value="C" />
                            <telerik:RadComboBoxItem runat="server" Text="Seller" Value="S" />
                            <telerik:RadComboBoxItem runat="server" Text="Administratoin" Value="A" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
                <td class="style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="cmbUserType" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td colspan="3">
                    Address Details (Can change later)</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtFname" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td class="style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtFname" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td class="style7">
                    Category</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadComboBox ID="cmbAddressCategory" Runat="server" AutoPostBack="True" 
                        onselectedindexchanged="cmbUserType_SelectedIndexChanged" Width="204px">
                    </telerik:RadComboBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="cmbAddressCategory" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="lblLastNameColon" runat="server" Text=":"></asp:Label>
                </td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtLname" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style7">
                    Add L 01</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAddressLine01" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtAddressLine01" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    Gender</td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <asp:RadioButton ID="radMale" runat="server" GroupName="Gender" Text="Male" 
                        Checked="True" />
&nbsp;
                    <asp:RadioButton ID="radFemale" runat="server" GroupName="Gender" 
                        Text="Female" />
&nbsp;
                    <asp:RadioButton ID="radOther" runat="server" GroupName="Gender" Text="Other" />
                </td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style7">
                    Add L 02</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAddressLine02" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    Primary Email</td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtPrimaryEmail" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td class="style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtPrimaryEmail" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td class="style7">
                    City</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAddressCity" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtAddressCity" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    Primary Contact No</td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtPrimaryContactNo" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td class="style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtPrimaryContactNo" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td class="style7">
                    State</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAddressState" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtAddressState" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    Fax</td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtFax" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style7">
                    Zip</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadNumericTextBox ID="txtAddressZipCode" Runat="server" Width="200px">
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtAddressZipCode" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    <asp:CheckBox ID="chkIsActive" runat="server" Text="Active" Checked="True" />
                </td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td>
                    <asp:CheckBox ID="IsDefaltShippingAddess" runat="server" 
                        Text="Default Shipping / Mailing Addess" Checked="True" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10" colspan="7">
                <hr class="separator" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    Username</td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtUsername" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td class="style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="txtUsername" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td class="style7" colspan="3">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtConfirmPassword" ControlToValidate="txtPassword" 
                        ErrorMessage="Password and Confirm Password Not Match." Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:CompareValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    Password</td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtPassword" Runat="server" TextMode="Password" 
                        Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td class="style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        ControlToValidate="txtPassword" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td class="style7">
                    Confirm Password</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtConfirmPassword" Runat="server" TextMode="Password" 
                        Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                        ControlToValidate="txtConfirmPassword" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    Sequrity Question</td>
                <td class="style4">
                    :</td>
                <td class="style5">
                    <telerik:RadComboBox ID="cmbSequrityQuestion" Runat="server" Width="204px">
                    </telerik:RadComboBox>
                </td>
                <td class="style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                        ControlToValidate="cmbSequrityQuestion" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td class="style7">
                    Answer</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAnswer" Runat="server" Width="200px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                        ControlToValidate="txtAnswer" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style9" colspan="7">
                    An email 
                    will send to you. Please Check your mail and verify the account after 
                    registration. </td>
                <td class="style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3" colspan="7" >
                    <asp:Button ID="btnRegister" runat="server" Height="30px" Text="Register" 
                        Width="264px" CssClass="button" Font-Bold="True" 
                        onclick="btnRegister_Click" ValidationGroup="i" />
                        &nbsp;  &nbsp;  &nbsp; 
                    <asp:Button ID="btnClear" runat="server" Height="30px" Text="Clear" 
                        Width="150px" CssClass="button" onclick="btnClear_Click" />
                        &nbsp;  &nbsp;  &nbsp; 
                         <asp:Button ID="btnClose" runat="server" Height="30px" Text="Close" 
                        Width="120px" CssClass="button" onclick="btnClose_Click" />
                </td>
                <td class="style3" >
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style10">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                    </telerik:RadScriptManager>
                </td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <telerik:RadWindow ID="RadWindow1" runat="server">
    </telerik:RadWindow>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
    </form>
</body>
</html>
