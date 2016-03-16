namespace WindowsFormsApplication1
{
    partial class GameBoard
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.handArea = new System.Windows.Forms.FlowLayoutPanel();
            this.instructions = new System.Windows.Forms.Label();
            this.btn_discard = new System.Windows.Forms.Button();
            this.cardPlayButtons = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Wonder = new System.Windows.Forms.Button();
            this.btn_Build = new System.Windows.Forms.Button();
            this.playArea = new WindowsFormsApplication1.PlayArea();
            this.resourceInfo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.wonder1 = new WindowsFormsApplication1.Wonder();
            this.cardPlayButtons.SuspendLayout();
            this.playArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wonder1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(13, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(1041, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // handArea
            // 
            this.handArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.handArea.AutoScroll = true;
            this.handArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.handArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.handArea.Location = new System.Drawing.Point(291, 534);
            this.handArea.Name = "handArea";
            this.handArea.Size = new System.Drawing.Size(733, 170);
            this.handArea.TabIndex = 4;
            // 
            // instructions
            // 
            this.instructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(58, 534);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(145, 170);
            this.instructions.TabIndex = 5;
            this.instructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_discard
            // 
            this.btn_discard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_discard.Location = new System.Drawing.Point(1, 70);
            this.btn_discard.Name = "btn_discard";
            this.btn_discard.Size = new System.Drawing.Size(75, 23);
            this.btn_discard.TabIndex = 6;
            this.btn_discard.Text = "Discard";
            this.btn_discard.UseVisualStyleBackColor = true;
            // 
            // cardPlayButtons
            // 
            this.cardPlayButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cardPlayButtons.Controls.Add(this.btn_Cancel);
            this.cardPlayButtons.Controls.Add(this.btn_Wonder);
            this.cardPlayButtons.Controls.Add(this.btn_Build);
            this.cardPlayButtons.Controls.Add(this.btn_discard);
            this.cardPlayButtons.Location = new System.Drawing.Point(209, 534);
            this.cardPlayButtons.Name = "cardPlayButtons";
            this.cardPlayButtons.Size = new System.Drawing.Size(79, 155);
            this.cardPlayButtons.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(1, 117);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Wonder
            // 
            this.btn_Wonder.Location = new System.Drawing.Point(1, 40);
            this.btn_Wonder.Name = "btn_Wonder";
            this.btn_Wonder.Size = new System.Drawing.Size(75, 23);
            this.btn_Wonder.TabIndex = 8;
            this.btn_Wonder.Text = "Wonder";
            this.btn_Wonder.UseVisualStyleBackColor = true;
            // 
            // btn_Build
            // 
            this.btn_Build.Location = new System.Drawing.Point(1, 10);
            this.btn_Build.Name = "btn_Build";
            this.btn_Build.Size = new System.Drawing.Size(75, 23);
            this.btn_Build.TabIndex = 7;
            this.btn_Build.Text = "Build";
            this.btn_Build.UseVisualStyleBackColor = true;
            // 
            // playArea
            // 
            this.playArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playArea.AutoScroll = true;
            this.playArea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.playArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playArea.Controls.Add(this.resourceInfo);
            this.playArea.Controls.Add(this.panel5);
            this.playArea.Controls.Add(this.wonder1);
            this.playArea.Location = new System.Drawing.Point(62, 12);
            this.playArea.Name = "playArea";
            this.playArea.Size = new System.Drawing.Size(963, 516);
            this.playArea.TabIndex = 3;
            // 
            // resourceInfo
            // 
            this.resourceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resourceInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resourceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceInfo.Location = new System.Drawing.Point(18, 330);
            this.resourceInfo.Name = "resourceInfo";
            this.resourceInfo.Size = new System.Drawing.Size(145, 170);
            this.resourceInfo.TabIndex = 6;
            this.resourceInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.AutoScroll = true;
            this.panel5.Location = new System.Drawing.Point(970, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 189);
            this.panel5.TabIndex = 3;
            // 
            // wonder1
            // 
            this.wonder1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wonder1.BackColor = System.Drawing.SystemColors.Control;
            this.wonder1.Image = global::WindowsFormsApplication1.Properties.Resources.EphesosA;
            this.wonder1.Location = new System.Drawing.Point(335, 374);
            this.wonder1.Name = "wonder1";
            this.wonder1.Size = new System.Drawing.Size(290, 126);
            this.wonder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wonder1.Stage = 0;
            this.wonder1.TabIndex = 0;
            this.wonder1.TabStop = false;
            this.wonder1.WonderName = null;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 714);
            this.ControlBox = false;
            this.Controls.Add(this.cardPlayButtons);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.handArea);
            this.Controls.Add(this.playArea);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.cardPlayButtons.ResumeLayout(false);
            this.playArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wonder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private PlayArea playArea;
        private System.Windows.Forms.FlowLayoutPanel handArea;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Button btn_discard;
        private System.Windows.Forms.Panel cardPlayButtons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Wonder;
        private System.Windows.Forms.Button btn_Build;
        private Wonder wonder1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label resourceInfo;
    }
}