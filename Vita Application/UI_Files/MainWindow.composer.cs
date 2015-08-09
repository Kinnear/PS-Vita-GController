// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace HighScoreApp
{
    partial class MainWindow
    {
        Panel Panel_1;
        Label label1;
        Button connectToServerButton;
        EditableText textboxIPAddress;
        Label isConnected;
        Label connectedResults;
        Label Label_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Panel_1 = new Panel();
            Panel_1.Name = "Panel_1";
            label1 = new Label();
            label1.Name = "label1";
            connectToServerButton = new Button();
            connectToServerButton.Name = "connectToServerButton";
            textboxIPAddress = new EditableText();
            textboxIPAddress.Name = "textboxIPAddress";
            isConnected = new Label();
            isConnected.Name = "isConnected";
            connectedResults = new Label();
            connectedResults.Name = "connectedResults";
            Label_1 = new Label();
            Label_1.Name = "Label_1";

            // MainWindow
            this.RootWidget.AddChildLast(Panel_1);
            this.RootWidget.AddChildLast(Label_1);

            // Panel_1
            Panel_1.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            Panel_1.Clip = true;
            Panel_1.AddChildLast(label1);
            Panel_1.AddChildLast(connectToServerButton);
            Panel_1.AddChildLast(textboxIPAddress);
            Panel_1.AddChildLast(isConnected);
            Panel_1.AddChildLast(connectedResults);

            // label1
            label1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            label1.LineBreak = LineBreak.Character;

            // connectToServerButton
            connectToServerButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            connectToServerButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // textboxIPAddress
            textboxIPAddress.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            textboxIPAddress.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            textboxIPAddress.LineBreak = LineBreak.Character;

            // isConnected
            isConnected.TextColor = new UIColor(255f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            isConnected.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            isConnected.LineBreak = LineBreak.Character;

            // connectedResults
            connectedResults.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            connectedResults.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            connectedResults.LineBreak = LineBreak.Character;

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    Panel_1.SetPosition(129, 81);
                    Panel_1.SetSize(100, 100);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    label1.SetPosition(-70, 0);
                    label1.SetSize(214, 36);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    connectToServerButton.SetPosition(587, 61);
                    connectToServerButton.SetSize(214, 56);
                    connectToServerButton.Anchors = Anchors.None;
                    connectToServerButton.Visible = true;

                    textboxIPAddress.SetPosition(-24, 68);
                    textboxIPAddress.SetSize(360, 56);
                    textboxIPAddress.Anchors = Anchors.None;
                    textboxIPAddress.Visible = true;

                    isConnected.SetPosition(505, 79);
                    isConnected.SetSize(214, 36);
                    isConnected.Anchors = Anchors.None;
                    isConnected.Visible = true;

                    connectedResults.SetPosition(74, 172);
                    connectedResults.SetSize(214, 36);
                    connectedResults.Anchors = Anchors.None;
                    connectedResults.Visible = true;

                    Label_1.SetPosition(404, 79);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Panel_1.SetPosition(0, 0);
                    Panel_1.SetSize(960, 544);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    label1.SetPosition(12, 13);
                    label1.SetSize(214, 36);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    connectToServerButton.SetPosition(699, 68);
                    connectToServerButton.SetSize(225, 56);
                    connectToServerButton.Anchors = Anchors.None;
                    connectToServerButton.Visible = true;

                    textboxIPAddress.SetPosition(30, 68);
                    textboxIPAddress.SetSize(332, 56);
                    textboxIPAddress.Anchors = Anchors.None;
                    textboxIPAddress.Visible = true;

                    isConnected.SetPosition(555, 79);
                    isConnected.SetSize(77, 36);
                    isConnected.Anchors = Anchors.None;
                    isConnected.Visible = true;

                    connectedResults.SetPosition(404, 115);
                    connectedResults.SetSize(228, 36);
                    connectedResults.Anchors = Anchors.None;
                    connectedResults.Visible = true;

                    Label_1.SetPosition(404, 79);
                    Label_1.SetSize(145, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            label1.Text = "Server IP Address:";

            connectToServerButton.Text = "Connect To Server";

            textboxIPAddress.Text = "Server Address...";

            isConnected.Text = "No";

            Label_1.Text = "Connected :";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

    }
}
