<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="CreditUnionSite.Apply" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>

     <div>
        <h1>Car Loan Application</h1>
        <fieldset>
            <legend>Personal Details</legend>

            <label for="FistName">First Name</label>
            <asp:TextBox runat="server" ID="FirstName"/>
            
            <label for="SecondName">Second Name</label>
            <asp:TextBox runat="server" ID="SecondName"/>
            
            <label for="EmailAddress">Email Address</label>
            <asp:TextBox runat="server" ID="EmailAddress"/>
        </fieldset>
        
        <fieldset>
            <legend>Financial Information</legend>
            
            <label for="AnnualIncome">Annual Income</label>
            <asp:TextBox runat="server" ID="AnnualIncome"/>
            
            <h3>Existing Credit Cards</h3>
            <div id="existingCards">
                <label for="CCLimit1">Card 1 Credit Limit</label>
                <asp:TextBox runat="server" ID="CCLimit1"/>
                
                <label for="CCLimit2">Card 2 Credit Limit</label>
                <asp:TextBox runat="server" ID="CCLimit2"/>

                <label for="CCLimit3">Card 3 Credit Limit</label>
                <asp:TextBox runat="server" ID="CCLimit3"/>

            </div>


        </fieldset>
        
        
          <fieldset>
            <legend>Other Information</legend>                
                <label for="AirlineRewardNumber">Drivers License Number</label>              
                <asp:TextBox runat="server" ID="AirlineRewardNumber"/>
           </fieldset>
        
        <asp:Button runat="server" ID="ApplyNow" Text="Apply Now!" OnClick="ApplyNow_OnClick"></asp:Button>

    </div>
</asp:Content>
