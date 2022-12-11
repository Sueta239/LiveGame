namespace Denis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Next = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HowMuchToBeBorn = new System.Windows.Forms.ListBox();
            this.HowMuchToContinueLive = new System.Windows.Forms.ListBox();
            this.TextOpen = new System.Windows.Forms.Button();
            this.TextSave = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.KSteps = new System.Windows.Forms.NumericUpDown();
            this.KthNext = new System.Windows.Forms.Button();
            this.TimerState = new System.Windows.Forms.Button();
            this.LabelZoom = new System.Windows.Forms.Label();
            this.MinusZoom = new System.Windows.Forms.Button();
            this.PlusZoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.field = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenPicture = new System.Windows.Forms.Button();
            this.SavePicture = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.KSteps)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(24, 0);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(94, 29);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.NextPhase);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Generate);
            // 
            // HowMuchToBeBorn
            // 
            this.HowMuchToBeBorn.FormattingEnabled = true;
            this.HowMuchToBeBorn.ItemHeight = 20;
            this.HowMuchToBeBorn.Location = new System.Drawing.Point(4, 217);
            this.HowMuchToBeBorn.Name = "HowMuchToBeBorn";
            this.HowMuchToBeBorn.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.HowMuchToBeBorn.Size = new System.Drawing.Size(150, 144);
            this.HowMuchToBeBorn.TabIndex = 16;
            this.HowMuchToBeBorn.SelectedIndexChanged += new System.EventHandler(this.NewRulesToBeBorn);
            // 
            // HowMuchToContinueLive
            // 
            this.HowMuchToContinueLive.FormattingEnabled = true;
            this.HowMuchToContinueLive.ItemHeight = 20;
            this.HowMuchToContinueLive.Location = new System.Drawing.Point(6, 6);
            this.HowMuchToContinueLive.Name = "HowMuchToContinueLive";
            this.HowMuchToContinueLive.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.HowMuchToContinueLive.Size = new System.Drawing.Size(150, 144);
            this.HowMuchToContinueLive.TabIndex = 15;
            this.HowMuchToContinueLive.SelectedIndexChanged += new System.EventHandler(this.NewRulesToLive);
            // 
            // TextOpen
            // 
            this.TextOpen.Location = new System.Drawing.Point(24, 291);
            this.TextOpen.Name = "TextOpen";
            this.TextOpen.Size = new System.Drawing.Size(94, 29);
            this.TextOpen.TabIndex = 14;
            this.TextOpen.Text = "open";
            this.TextOpen.UseVisualStyleBackColor = true;
            this.TextOpen.Click += new System.EventHandler(this.TextOpen_Click);
            // 
            // TextSave
            // 
            this.TextSave.Location = new System.Drawing.Point(24, 259);
            this.TextSave.Name = "TextSave";
            this.TextSave.Size = new System.Drawing.Size(94, 29);
            this.TextSave.TabIndex = 13;
            this.TextSave.Text = "save";
            this.TextSave.UseVisualStyleBackColor = true;
            this.TextSave.Click += new System.EventHandler(this.TextSave_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(6, 209);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(125, 44);
            this.Info.TabIndex = 12;
            this.Info.Text = "тут инфа по клеткам";
            // 
            // KSteps
            // 
            this.KSteps.Location = new System.Drawing.Point(24, 143);
            this.KSteps.Name = "KSteps";
            this.KSteps.Size = new System.Drawing.Size(94, 27);
            this.KSteps.TabIndex = 11;
            // 
            // KthNext
            // 
            this.KthNext.Location = new System.Drawing.Point(24, 176);
            this.KthNext.Name = "KthNext";
            this.KthNext.Size = new System.Drawing.Size(94, 27);
            this.KthNext.TabIndex = 9;
            this.KthNext.Text = "K_th next";
            this.KthNext.UseVisualStyleBackColor = true;
            this.KthNext.Click += new System.EventHandler(this.KthNext_Click);
            // 
            // TimerState
            // 
            this.TimerState.Location = new System.Drawing.Point(24, 108);
            this.TimerState.Name = "TimerState";
            this.TimerState.Size = new System.Drawing.Size(94, 29);
            this.TimerState.TabIndex = 8;
            this.TimerState.Text = "Timer start";
            this.TimerState.UseVisualStyleBackColor = true;
            this.TimerState.Click += new System.EventHandler(this.TimerState_Click);
            // 
            // LabelZoom
            // 
            this.LabelZoom.AutoSize = true;
            this.LabelZoom.Location = new System.Drawing.Point(50, 77);
            this.LabelZoom.Name = "LabelZoom";
            this.LabelZoom.Size = new System.Drawing.Size(47, 20);
            this.LabelZoom.TabIndex = 7;
            this.LabelZoom.Text = "zoom";
            // 
            // MinusZoom
            // 
            this.MinusZoom.Location = new System.Drawing.Point(6, 73);
            this.MinusZoom.Name = "MinusZoom";
            this.MinusZoom.Size = new System.Drawing.Size(32, 29);
            this.MinusZoom.TabIndex = 6;
            this.MinusZoom.Text = "-";
            this.MinusZoom.UseVisualStyleBackColor = true;
            this.MinusZoom.Click += new System.EventHandler(this.MinusZoom_Click);
            // 
            // PlusZoom
            // 
            this.PlusZoom.Location = new System.Drawing.Point(112, 73);
            this.PlusZoom.Name = "PlusZoom";
            this.PlusZoom.Size = new System.Drawing.Size(32, 29);
            this.PlusZoom.TabIndex = 5;
            this.PlusZoom.Text = "+";
            this.PlusZoom.UseVisualStyleBackColor = true;
            this.PlusZoom.Click += new System.EventHandler(this.PlusZoom_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.field);
            this.panel2.Location = new System.Drawing.Point(182, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 426);
            this.panel2.TabIndex = 4;
            // 
            // field
            // 
            this.field.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.field.Location = new System.Drawing.Point(0, 0);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(1504, 1504);
            this.field.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field.TabIndex = 0;
            this.field.TabStop = false;
            this.field.MouseClick += new System.Windows.Forms.MouseEventHandler(this.field_MouseClick);
            this.field.MouseMove += new System.Windows.Forms.MouseEventHandler(this.field_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(168, 423);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpenPicture);
            this.tabPage1.Controls.Add(this.SavePicture);
            this.tabPage1.Controls.Add(this.Next);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.TextOpen);
            this.tabPage1.Controls.Add(this.LabelZoom);
            this.tabPage1.Controls.Add(this.TextSave);
            this.tabPage1.Controls.Add(this.PlusZoom);
            this.tabPage1.Controls.Add(this.Info);
            this.tabPage1.Controls.Add(this.MinusZoom);
            this.tabPage1.Controls.Add(this.KthNext);
            this.tabPage1.Controls.Add(this.KSteps);
            this.tabPage1.Controls.Add(this.TimerState);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(160, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpenPicture
            // 
            this.OpenPicture.Location = new System.Drawing.Point(6, 355);
            this.OpenPicture.Name = "OpenPicture";
            this.OpenPicture.Size = new System.Drawing.Size(125, 29);
            this.OpenPicture.TabIndex = 16;
            this.OpenPicture.Text = "open picture";
            this.OpenPicture.UseVisualStyleBackColor = true;
            this.OpenPicture.Click += new System.EventHandler(this.OpenPicture_Click);
            // 
            // SavePicture
            // 
            this.SavePicture.Location = new System.Drawing.Point(6, 320);
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.Size = new System.Drawing.Size(125, 29);
            this.SavePicture.TabIndex = 15;
            this.SavePicture.Text = "save picture";
            this.SavePicture.UseVisualStyleBackColor = true;
            this.SavePicture.Click += new System.EventHandler(this.SavePicture_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.HowMuchToBeBorn);
            this.tabPage2.Controls.Add(this.HowMuchToContinueLive);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(160, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 443);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KSteps)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button Next;
        private Button button2;
        private Panel panel2;
        private Button MinusZoom;
        private Button PlusZoom;
        private Label LabelZoom;
        private Button KthNext;
        private Button TimerState;
        private PictureBox field;
        private NumericUpDown KSteps;
        private TextBox Info;
        private Button TextOpen;
        private Button TextSave;
        private ListBox HowMuchToBeBorn;
        private ListBox HowMuchToContinueLive;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button SavePicture;
        private Button OpenPicture;
    }
}