namespace WindowsFormsApplication1
{
    partial class BuildDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildDialog));
            this.btn_BuildConfirm = new System.Windows.Forms.Button();
            this.btn_TradeLeft = new System.Windows.Forms.Button();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.btn_BuildCancel = new System.Windows.Forms.Button();
            this.btn_TradeRight = new System.Windows.Forms.Button();
            this.card = new WindowsFormsApplication1.Card();
            this.lbl_BuildResources = new System.Windows.Forms.Label();
            this.lst_LeftResources = new System.Windows.Forms.ListBox();
            this.lst_RightResources = new System.Windows.Forms.ListBox();
            this.lbl_Resources = new System.Windows.Forms.Label();
            this.lbl_AvailableResources = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.card)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BuildConfirm
            // 
            this.btn_BuildConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_BuildConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_BuildConfirm.Location = new System.Drawing.Point(159, 295);
            this.btn_BuildConfirm.Name = "btn_BuildConfirm";
            this.btn_BuildConfirm.Size = new System.Drawing.Size(75, 23);
            this.btn_BuildConfirm.TabIndex = 1;
            this.btn_BuildConfirm.Text = "Build";
            this.btn_BuildConfirm.UseVisualStyleBackColor = true;
            // 
            // btn_TradeLeft
            // 
            this.btn_TradeLeft.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.double_arrow_right;
            this.btn_TradeLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TradeLeft.Location = new System.Drawing.Point(120, 131);
            this.btn_TradeLeft.Name = "btn_TradeLeft";
            this.btn_TradeLeft.Size = new System.Drawing.Size(58, 58);
            this.btn_TradeLeft.TabIndex = 2;
            this.btn_TradeLeft.UseVisualStyleBackColor = true;
            this.btn_TradeLeft.Click += new System.EventHandler(this.btn_TradeLeft_Click);
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Instructions.Location = new System.Drawing.Point(118, 197);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(228, 82);
            this.lbl_Instructions.TabIndex = 4;
            this.lbl_Instructions.Text = "label1";
            // 
            // btn_BuildCancel
            // 
            this.btn_BuildCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_BuildCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_BuildCancel.Location = new System.Drawing.Point(240, 295);
            this.btn_BuildCancel.Name = "btn_BuildCancel";
            this.btn_BuildCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_BuildCancel.TabIndex = 7;
            this.btn_BuildCancel.Text = "Cancel";
            this.btn_BuildCancel.UseVisualStyleBackColor = true;
            this.btn_BuildCancel.Click += new System.EventHandler(this.btn_BuildCancel_Click);
            // 
            // btn_TradeRight
            // 
            this.btn_TradeRight.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.double_arrow_left;
            this.btn_TradeRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TradeRight.Location = new System.Drawing.Point(290, 131);
            this.btn_TradeRight.Name = "btn_TradeRight";
            this.btn_TradeRight.Size = new System.Drawing.Size(58, 58);
            this.btn_TradeRight.TabIndex = 3;
            this.btn_TradeRight.UseVisualStyleBackColor = true;
            this.btn_TradeRight.Click += new System.EventHandler(this.btn_TradeRight_Click);
            // 
            // card
            // 
            this.card.Action = WindowsFormsApplication1.Action.None;
            this.card.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.card.FaceUp = false;
            this.card.Image = ((System.Drawing.Image)(resources.GetObject("card.Image")));
            this.card.Location = new System.Drawing.Point(458, 73);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(107, 160);
            this.card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card.TabIndex = 0;
            this.card.TabStop = false;
            // 
            // lbl_BuildResources
            // 
            this.lbl_BuildResources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_BuildResources.Location = new System.Drawing.Point(184, 9);
            this.lbl_BuildResources.Name = "lbl_BuildResources";
            this.lbl_BuildResources.Size = new System.Drawing.Size(100, 180);
            this.lbl_BuildResources.TabIndex = 10;
            this.lbl_BuildResources.Text = "label4";
            // 
            // lst_LeftResources
            // 
            this.lst_LeftResources.FormattingEnabled = true;
            this.lst_LeftResources.Location = new System.Drawing.Point(12, 27);
            this.lst_LeftResources.Name = "lst_LeftResources";
            this.lst_LeftResources.Size = new System.Drawing.Size(99, 251);
            this.lst_LeftResources.TabIndex = 11;
            // 
            // lst_RightResources
            // 
            this.lst_RightResources.FormattingEnabled = true;
            this.lst_RightResources.Location = new System.Drawing.Point(353, 27);
            this.lst_RightResources.Name = "lst_RightResources";
            this.lst_RightResources.Size = new System.Drawing.Size(99, 251);
            this.lst_RightResources.TabIndex = 12;
            // 
            // lbl_Resources
            // 
            this.lbl_Resources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Resources.Location = new System.Drawing.Point(184, 9);
            this.lbl_Resources.Name = "lbl_Resources";
            this.lbl_Resources.Size = new System.Drawing.Size(100, 180);
            this.lbl_Resources.TabIndex = 10;
            this.lbl_Resources.Text = "label4";
            // 
            // lbl_AvailableResources
            // 
            this.lbl_AvailableResources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AvailableResources.Location = new System.Drawing.Point(184, 9);
            this.lbl_AvailableResources.Name = "lbl_AvailableResources";
            this.lbl_AvailableResources.Size = new System.Drawing.Size(100, 180);
            this.lbl_AvailableResources.TabIndex = 10;
            this.lbl_AvailableResources.Text = "label4";
            // 
            // BuildDialog
            // 
            this.AcceptButton = this.btn_BuildConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btn_BuildCancel;
            this.ClientSize = new System.Drawing.Size(576, 330);
            this.ControlBox = false;
            this.Controls.Add(this.lst_RightResources);
            this.Controls.Add(this.lst_LeftResources);
            this.Controls.Add(this.lbl_BuildResources);
            this.Controls.Add(this.btn_BuildCancel);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.btn_TradeRight);
            this.Controls.Add(this.btn_TradeLeft);
            this.Controls.Add(this.btn_BuildConfirm);
            this.Controls.Add(this.card);
            this.Name = "BuildDialog";
            this.Text = "Confirm Build";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BuildDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.card)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Card card;
        private System.Windows.Forms.Button btn_BuildConfirm;
        private System.Windows.Forms.Button btn_TradeLeft;
        private System.Windows.Forms.Button btn_TradeRight;
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.Button btn_BuildCancel;
        private System.Windows.Forms.Label lbl_BuildResources;
        private System.Windows.Forms.ListBox lst_LeftResources;
        private System.Windows.Forms.ListBox lst_RightResources;
        private System.Windows.Forms.Label lbl_Resources;
        private System.Windows.Forms.Label lbl_AvailableResources;
    }
}