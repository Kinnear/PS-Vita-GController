namespace ServerSide
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serverIPAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsTextbox = new System.Windows.Forms.RichTextBox();
            this.mouseXlbl = new System.Windows.Forms.Label();
            this.mouseYlbl = new System.Windows.Forms.Label();
            this.cursorPositionX = new System.Windows.Forms.Label();
            this.cursorPositionY = new System.Windows.Forms.Label();
            this.keyBindWindowBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.triangleBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.crossBtn = new System.Windows.Forms.Button();
            this.dpadUpBtn = new System.Windows.Forms.Button();
            this.dpadLeftBtn = new System.Windows.Forms.Button();
            this.dpadRightBtn = new System.Windows.Forms.Button();
            this.dpadDownBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.rightShoulderbtn = new System.Windows.Forms.Button();
            this.leftShoulderBtn = new System.Windows.Forms.Button();
            this.leftAnalogUpBtn = new System.Windows.Forms.Button();
            this.leftAnalogDownBtn = new System.Windows.Forms.Button();
            this.leftAnalogLeftBtn = new System.Windows.Forms.Button();
            this.leftAnalogRightBtn = new System.Windows.Forms.Button();
            this.rightAnalogRightBtn = new System.Windows.Forms.Button();
            this.rightAnalogLeftBtn = new System.Windows.Forms.Button();
            this.rightAnalogDownBtn = new System.Windows.Forms.Button();
            this.rightAnalogUpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serverIPAddress
            // 
            this.serverIPAddress.AutoSize = true;
            this.serverIPAddress.Location = new System.Drawing.Point(183, 57);
            this.serverIPAddress.Name = "serverIPAddress";
            this.serverIPAddress.Size = new System.Drawing.Size(123, 20);
            this.serverIPAddress.TabIndex = 0;
            this.serverIPAddress.Text = "IP Address here";
            this.serverIPAddress.Click += new System.EventHandler(this.serverIPAddress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP Address:";
            // 
            // resultsTextbox
            // 
            this.resultsTextbox.Location = new System.Drawing.Point(30, 90);
            this.resultsTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.resultsTextbox.Name = "resultsTextbox";
            this.resultsTextbox.Size = new System.Drawing.Size(836, 65);
            this.resultsTextbox.TabIndex = 3;
            this.resultsTextbox.Text = "";
            // 
            // mouseXlbl
            // 
            this.mouseXlbl.AutoSize = true;
            this.mouseXlbl.Location = new System.Drawing.Point(964, 126);
            this.mouseXlbl.Name = "mouseXlbl";
            this.mouseXlbl.Size = new System.Drawing.Size(80, 20);
            this.mouseXlbl.TabIndex = 4;
            this.mouseXlbl.Text = "Mouse X :";
            // 
            // mouseYlbl
            // 
            this.mouseYlbl.AutoSize = true;
            this.mouseYlbl.Location = new System.Drawing.Point(964, 163);
            this.mouseYlbl.Name = "mouseYlbl";
            this.mouseYlbl.Size = new System.Drawing.Size(80, 20);
            this.mouseYlbl.TabIndex = 5;
            this.mouseYlbl.Text = "Mouse Y :";
            // 
            // cursorPositionX
            // 
            this.cursorPositionX.AutoSize = true;
            this.cursorPositionX.Location = new System.Drawing.Point(964, 248);
            this.cursorPositionX.Name = "cursorPositionX";
            this.cursorPositionX.Size = new System.Drawing.Size(139, 20);
            this.cursorPositionX.TabIndex = 6;
            this.cursorPositionX.Text = "Cursor Position X :";
            // 
            // cursorPositionY
            // 
            this.cursorPositionY.AutoSize = true;
            this.cursorPositionY.Location = new System.Drawing.Point(964, 294);
            this.cursorPositionY.Name = "cursorPositionY";
            this.cursorPositionY.Size = new System.Drawing.Size(139, 20);
            this.cursorPositionY.TabIndex = 7;
            this.cursorPositionY.Text = "Cursor Position Y :";
            // 
            // keyBindWindowBtn
            // 
            this.keyBindWindowBtn.Location = new System.Drawing.Point(898, 425);
            this.keyBindWindowBtn.Name = "keyBindWindowBtn";
            this.keyBindWindowBtn.Size = new System.Drawing.Size(228, 51);
            this.keyBindWindowBtn.TabIndex = 8;
            this.keyBindWindowBtn.Text = "Assign Keybinds";
            this.keyBindWindowBtn.UseVisualStyleBackColor = true;
            this.keyBindWindowBtn.Click += new System.EventHandler(this.keyBindWindowBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // triangleBtn
            // 
            this.triangleBtn.Location = new System.Drawing.Point(756, 272);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(30, 30);
            this.triangleBtn.TabIndex = 10;
            this.triangleBtn.UseVisualStyleBackColor = true;
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.Location = new System.Drawing.Point(721, 306);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(30, 30);
            this.squareBtn.TabIndex = 11;
            this.squareBtn.UseVisualStyleBackColor = true;
            // 
            // circleBtn
            // 
            this.circleBtn.Location = new System.Drawing.Point(792, 306);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(30, 30);
            this.circleBtn.TabIndex = 12;
            this.circleBtn.UseVisualStyleBackColor = true;
            // 
            // crossBtn
            // 
            this.crossBtn.Location = new System.Drawing.Point(756, 338);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(30, 30);
            this.crossBtn.TabIndex = 13;
            this.crossBtn.UseVisualStyleBackColor = true;
            // 
            // dpadUpBtn
            // 
            this.dpadUpBtn.Location = new System.Drawing.Point(110, 273);
            this.dpadUpBtn.Name = "dpadUpBtn";
            this.dpadUpBtn.Size = new System.Drawing.Size(30, 30);
            this.dpadUpBtn.TabIndex = 14;
            this.dpadUpBtn.UseVisualStyleBackColor = true;
            // 
            // dpadLeftBtn
            // 
            this.dpadLeftBtn.Location = new System.Drawing.Point(82, 308);
            this.dpadLeftBtn.Name = "dpadLeftBtn";
            this.dpadLeftBtn.Size = new System.Drawing.Size(30, 30);
            this.dpadLeftBtn.TabIndex = 15;
            this.dpadLeftBtn.UseVisualStyleBackColor = true;
            // 
            // dpadRightBtn
            // 
            this.dpadRightBtn.Location = new System.Drawing.Point(137, 308);
            this.dpadRightBtn.Name = "dpadRightBtn";
            this.dpadRightBtn.Size = new System.Drawing.Size(30, 30);
            this.dpadRightBtn.TabIndex = 16;
            this.dpadRightBtn.UseVisualStyleBackColor = true;
            // 
            // dpadDownBtn
            // 
            this.dpadDownBtn.Location = new System.Drawing.Point(110, 338);
            this.dpadDownBtn.Name = "dpadDownBtn";
            this.dpadDownBtn.Size = new System.Drawing.Size(30, 30);
            this.dpadDownBtn.TabIndex = 17;
            this.dpadDownBtn.UseVisualStyleBackColor = true;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(721, 468);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(30, 30);
            this.selectBtn.TabIndex = 18;
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(768, 468);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(30, 30);
            this.startBtn.TabIndex = 19;
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // rightShoulderbtn
            // 
            this.rightShoulderbtn.Location = new System.Drawing.Point(730, 201);
            this.rightShoulderbtn.Name = "rightShoulderbtn";
            this.rightShoulderbtn.Size = new System.Drawing.Size(30, 30);
            this.rightShoulderbtn.TabIndex = 20;
            this.rightShoulderbtn.UseVisualStyleBackColor = true;
            // 
            // leftShoulderBtn
            // 
            this.leftShoulderBtn.Location = new System.Drawing.Point(137, 201);
            this.leftShoulderBtn.Name = "leftShoulderBtn";
            this.leftShoulderBtn.Size = new System.Drawing.Size(30, 30);
            this.leftShoulderBtn.TabIndex = 21;
            this.leftShoulderBtn.UseVisualStyleBackColor = true;
            // 
            // leftAnalogUpBtn
            // 
            this.leftAnalogUpBtn.Location = new System.Drawing.Point(134, 382);
            this.leftAnalogUpBtn.Name = "leftAnalogUpBtn";
            this.leftAnalogUpBtn.Size = new System.Drawing.Size(30, 30);
            this.leftAnalogUpBtn.TabIndex = 22;
            this.leftAnalogUpBtn.UseVisualStyleBackColor = true;
            // 
            // leftAnalogDownBtn
            // 
            this.leftAnalogDownBtn.Location = new System.Drawing.Point(134, 430);
            this.leftAnalogDownBtn.Name = "leftAnalogDownBtn";
            this.leftAnalogDownBtn.Size = new System.Drawing.Size(30, 30);
            this.leftAnalogDownBtn.TabIndex = 23;
            this.leftAnalogDownBtn.UseVisualStyleBackColor = true;
            // 
            // leftAnalogLeftBtn
            // 
            this.leftAnalogLeftBtn.Location = new System.Drawing.Point(104, 404);
            this.leftAnalogLeftBtn.Name = "leftAnalogLeftBtn";
            this.leftAnalogLeftBtn.Size = new System.Drawing.Size(30, 30);
            this.leftAnalogLeftBtn.TabIndex = 24;
            this.leftAnalogLeftBtn.UseVisualStyleBackColor = true;
            // 
            // leftAnalogRightBtn
            // 
            this.leftAnalogRightBtn.Location = new System.Drawing.Point(164, 404);
            this.leftAnalogRightBtn.Name = "leftAnalogRightBtn";
            this.leftAnalogRightBtn.Size = new System.Drawing.Size(30, 30);
            this.leftAnalogRightBtn.TabIndex = 25;
            this.leftAnalogRightBtn.UseVisualStyleBackColor = true;
            // 
            // rightAnalogRightBtn
            // 
            this.rightAnalogRightBtn.Location = new System.Drawing.Point(768, 404);
            this.rightAnalogRightBtn.Name = "rightAnalogRightBtn";
            this.rightAnalogRightBtn.Size = new System.Drawing.Size(30, 30);
            this.rightAnalogRightBtn.TabIndex = 29;
            this.rightAnalogRightBtn.UseVisualStyleBackColor = true;
            // 
            // rightAnalogLeftBtn
            // 
            this.rightAnalogLeftBtn.Location = new System.Drawing.Point(708, 404);
            this.rightAnalogLeftBtn.Name = "rightAnalogLeftBtn";
            this.rightAnalogLeftBtn.Size = new System.Drawing.Size(30, 30);
            this.rightAnalogLeftBtn.TabIndex = 28;
            this.rightAnalogLeftBtn.UseVisualStyleBackColor = true;
            // 
            // rightAnalogDownBtn
            // 
            this.rightAnalogDownBtn.Location = new System.Drawing.Point(738, 430);
            this.rightAnalogDownBtn.Name = "rightAnalogDownBtn";
            this.rightAnalogDownBtn.Size = new System.Drawing.Size(30, 30);
            this.rightAnalogDownBtn.TabIndex = 27;
            this.rightAnalogDownBtn.UseVisualStyleBackColor = true;
            // 
            // rightAnalogUpBtn
            // 
            this.rightAnalogUpBtn.Location = new System.Drawing.Point(738, 382);
            this.rightAnalogUpBtn.Name = "rightAnalogUpBtn";
            this.rightAnalogUpBtn.Size = new System.Drawing.Size(30, 30);
            this.rightAnalogUpBtn.TabIndex = 26;
            this.rightAnalogUpBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 608);
            this.Controls.Add(this.rightAnalogRightBtn);
            this.Controls.Add(this.rightAnalogLeftBtn);
            this.Controls.Add(this.rightAnalogDownBtn);
            this.Controls.Add(this.rightAnalogUpBtn);
            this.Controls.Add(this.leftAnalogRightBtn);
            this.Controls.Add(this.leftAnalogLeftBtn);
            this.Controls.Add(this.leftAnalogDownBtn);
            this.Controls.Add(this.leftAnalogUpBtn);
            this.Controls.Add(this.leftShoulderBtn);
            this.Controls.Add(this.rightShoulderbtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.dpadDownBtn);
            this.Controls.Add(this.dpadRightBtn);
            this.Controls.Add(this.dpadLeftBtn);
            this.Controls.Add(this.dpadUpBtn);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.squareBtn);
            this.Controls.Add(this.triangleBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.keyBindWindowBtn);
            this.Controls.Add(this.cursorPositionY);
            this.Controls.Add(this.cursorPositionX);
            this.Controls.Add(this.mouseYlbl);
            this.Controls.Add(this.mouseXlbl);
            this.Controls.Add(this.resultsTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverIPAddress);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resultsTextbox;
        private System.Windows.Forms.Label mouseXlbl;
        private System.Windows.Forms.Label mouseYlbl;
        private System.Windows.Forms.Label cursorPositionX;
        private System.Windows.Forms.Label cursorPositionY;
        private System.Windows.Forms.Button keyBindWindowBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button triangleBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button crossBtn;
        private System.Windows.Forms.Button dpadUpBtn;
        private System.Windows.Forms.Button dpadLeftBtn;
        private System.Windows.Forms.Button dpadRightBtn;
        private System.Windows.Forms.Button dpadDownBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button rightShoulderbtn;
        private System.Windows.Forms.Button leftShoulderBtn;
        private System.Windows.Forms.Button leftAnalogUpBtn;
        private System.Windows.Forms.Button leftAnalogDownBtn;
        private System.Windows.Forms.Button leftAnalogLeftBtn;
        private System.Windows.Forms.Button leftAnalogRightBtn;
        private System.Windows.Forms.Button rightAnalogRightBtn;
        private System.Windows.Forms.Button rightAnalogLeftBtn;
        private System.Windows.Forms.Button rightAnalogDownBtn;
        private System.Windows.Forms.Button rightAnalogUpBtn;
    }
}

