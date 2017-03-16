﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NMITransactionMismatch.ascx.cs" Inherits="RockWeb.Plugins.cc_newspring.Blocks.NMITransactions.NMITransactionMismatch" %>

<asp:UpdatePanel ID="upNMITransactions" runat="server">
    <ContentTemplate>

        <asp:Panel ID="pnlContent" runat="server">
            <asp:HiddenField ID="hfTransactionViewMode" runat="server" />

            <asp:ValidationSummary ID="valSummaryTop" runat="server" HeaderText="Please Correct the Following" CssClass="alert alert-danger" />

            <div class="panel panel-block">
                <div class="panel-heading">
                    <h1 class="panel-title"><i class="fa fa-credit-card"></i> <asp:Literal ID="lTitle" runat="server"></asp:Literal></h1>
                </div>
                <div class="panel-body">

                    <div class="grid grid-panel">
                        <Rock:GridFilter ID="gfTransactions" runat="server">
                            <Rock:DateRangePicker ID="drpDates" runat="server" Label="NMI Transaction Date Range" />
                        </Rock:GridFilter>

                        <Rock:ModalAlert ID="mdGridWarning" runat="server" />

                        <Rock:Grid ID="gTransactions" runat="server" EmptyDataText="No Transactions Found" 
                            RowItemText="Transaction" AllowSorting="true" ExportSource="ColumnOutput" >
                            <Columns>
                                <Rock:RockBoundField DataField="TransactionDateTime" HeaderText="Date / Time" SortExpression="TransactionDateTime" />
                                <Rock:CurrencyField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                                <Rock:RockBoundField DataField="TransactionCode" HeaderText="Transaction Code" SortExpression="TransactionCode" ColumnPriority="DesktopSmall" />
                            </Columns>
                        </Rock:Grid>

                        <Rock:NotificationBox ID="nbResult" runat="server" Visible="false" CssClass="margin-b-none" Dismissable="true"></Rock:NotificationBox>

                    </div>

                </div>
            </div>

        </asp:Panel>

        <asp:HiddenField ID="hfActiveDialog" runat="server" />

    </ContentTemplate>
</asp:UpdatePanel>