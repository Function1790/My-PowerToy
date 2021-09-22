
namespace Pixels
{
    partial class Pixels
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pixels));
            this.World = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Ver = new System.Windows.Forms.Label();
            this.Select1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadP = new System.Windows.Forms.Panel();
            this.Select2 = new System.Windows.Forms.Button();
            this.Select3 = new System.Windows.Forms.Button();
            this.Select4 = new System.Windows.Forms.Button();
            this.Select5 = new System.Windows.Forms.Button();
            this.Select6 = new System.Windows.Forms.Button();
            this.SelectL = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.Select7 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // World
            // 
            this.World.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.World.Location = new System.Drawing.Point(13, 32);
            this.World.Margin = new System.Windows.Forms.Padding(4);
            this.World.Name = "World";
            this.World.Size = new System.Drawing.Size(700, 700);
            this.World.TabIndex = 0;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TopBar.Controls.Add(this.pictureBox1);
            this.TopBar.Controls.Add(this.CloseButton);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(4);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(934, 25);
            this.TopBar.TabIndex = 1;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pixels.Properties.Resources.Pixels;
            this.pictureBox1.InitialImage = global::Pixels.Properties.Resources.Pixels;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(909, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ver
            // 
            this.Ver.AutoSize = true;
            this.Ver.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ver.Location = new System.Drawing.Point(908, 780);
            this.Ver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(25, 15);
            this.Ver.TabIndex = 1;
            this.Ver.Text = "v0.4";
            // 
            // Select1
            // 
            this.Select1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Select1.FlatAppearance.BorderSize = 0;
            this.Select1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select1.ForeColor = System.Drawing.Color.White;
            this.Select1.Location = new System.Drawing.Point(13, 746);
            this.Select1.Margin = new System.Windows.Forms.Padding(4);
            this.Select1.Name = "Select1";
            this.Select1.Size = new System.Drawing.Size(96, 34);
            this.Select1.TabIndex = 2;
            this.Select1.Text = "Glass";
            this.Select1.UseVisualStyleBackColor = false;
            this.Select1.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadP
            // 
            this.loadP.Font = new System.Drawing.Font("Nova Flat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadP.ForeColor = System.Drawing.Color.White;
            this.loadP.Location = new System.Drawing.Point(-193, -225);
            this.loadP.Margin = new System.Windows.Forms.Padding(4);
            this.loadP.Name = "loadP";
            this.loadP.Size = new System.Drawing.Size(257, 150);
            this.loadP.TabIndex = 4;
            // 
            // Select2
            // 
            this.Select2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(200)))), ((int)(((byte)(149)))));
            this.Select2.FlatAppearance.BorderSize = 0;
            this.Select2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select2.ForeColor = System.Drawing.Color.White;
            this.Select2.Location = new System.Drawing.Point(117, 746);
            this.Select2.Margin = new System.Windows.Forms.Padding(4);
            this.Select2.Name = "Select2";
            this.Select2.Size = new System.Drawing.Size(96, 34);
            this.Select2.TabIndex = 5;
            this.Select2.Text = "Sand";
            this.Select2.UseVisualStyleBackColor = false;
            this.Select2.Click += new System.EventHandler(this.button3_Click);
            // 
            // Select3
            // 
            this.Select3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Select3.FlatAppearance.BorderSize = 0;
            this.Select3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select3.ForeColor = System.Drawing.Color.White;
            this.Select3.Location = new System.Drawing.Point(221, 746);
            this.Select3.Margin = new System.Windows.Forms.Padding(4);
            this.Select3.Name = "Select3";
            this.Select3.Size = new System.Drawing.Size(96, 34);
            this.Select3.TabIndex = 6;
            this.Select3.Text = "Air";
            this.Select3.UseVisualStyleBackColor = false;
            this.Select3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Select4
            // 
            this.Select4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Select4.FlatAppearance.BorderSize = 0;
            this.Select4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select4.ForeColor = System.Drawing.Color.White;
            this.Select4.Location = new System.Drawing.Point(325, 746);
            this.Select4.Margin = new System.Windows.Forms.Padding(4);
            this.Select4.Name = "Select4";
            this.Select4.Size = new System.Drawing.Size(96, 34);
            this.Select4.TabIndex = 7;
            this.Select4.Text = "Water";
            this.Select4.UseVisualStyleBackColor = false;
            this.Select4.Click += new System.EventHandler(this.button5_Click);
            // 
            // Select5
            // 
            this.Select5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.Select5.FlatAppearance.BorderSize = 0;
            this.Select5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select5.ForeColor = System.Drawing.Color.White;
            this.Select5.Location = new System.Drawing.Point(429, 746);
            this.Select5.Margin = new System.Windows.Forms.Padding(4);
            this.Select5.Name = "Select5";
            this.Select5.Size = new System.Drawing.Size(96, 34);
            this.Select5.TabIndex = 8;
            this.Select5.Text = "Oil";
            this.Select5.UseVisualStyleBackColor = false;
            this.Select5.Click += new System.EventHandler(this.button6_Click);
            // 
            // Select6
            // 
            this.Select6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.Select6.FlatAppearance.BorderSize = 0;
            this.Select6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select6.ForeColor = System.Drawing.Color.White;
            this.Select6.Location = new System.Drawing.Point(533, 746);
            this.Select6.Margin = new System.Windows.Forms.Padding(4);
            this.Select6.Name = "Select6";
            this.Select6.Size = new System.Drawing.Size(96, 34);
            this.Select6.TabIndex = 9;
            this.Select6.Text = "Fire";
            this.Select6.UseVisualStyleBackColor = false;
            this.Select6.Click += new System.EventHandler(this.button7_Click);
            this.Select6.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.button7_PreviewKeyDown);
            // 
            // SelectL
            // 
            this.SelectL.AutoSize = true;
            this.SelectL.Location = new System.Drawing.Point(720, 32);
            this.SelectL.Name = "SelectL";
            this.SelectL.Size = new System.Drawing.Size(104, 18);
            this.SelectL.TabIndex = 10;
            this.SelectL.Text = "Select : Sand";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(720, 60);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 18);
            this.InfoLabel.TabIndex = 11;
            // 
            // Select7
            // 
            this.Select7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Select7.FlatAppearance.BorderSize = 0;
            this.Select7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select7.ForeColor = System.Drawing.Color.Gray;
            this.Select7.Location = new System.Drawing.Point(637, 746);
            this.Select7.Margin = new System.Windows.Forms.Padding(4);
            this.Select7.Name = "Select7";
            this.Select7.Size = new System.Drawing.Size(96, 34);
            this.Select7.TabIndex = 12;
            this.Select7.Text = "Ice";
            this.Select7.UseVisualStyleBackColor = false;
            this.Select7.Click += new System.EventHandler(this.Select7_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Pixels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(934, 796);
            this.Controls.Add(this.Select7);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.SelectL);
            this.Controls.Add(this.Select6);
            this.Controls.Add(this.Select5);
            this.Controls.Add(this.Select4);
            this.Controls.Add(this.Select3);
            this.Controls.Add(this.Select1);
            this.Controls.Add(this.Select2);
            this.Controls.Add(this.loadP);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.World);
            this.Font = new System.Drawing.Font("Avenir", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pixels";
            this.Text = "Pixels";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel World;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Select1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel loadP;
        private System.Windows.Forms.Button Select2;
        private System.Windows.Forms.Label Ver;
        private System.Windows.Forms.Button Select3;
        private System.Windows.Forms.Button Select4;
        private System.Windows.Forms.Button Select5;
        private System.Windows.Forms.Button Select6;
        private System.Windows.Forms.Label SelectL;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Select7;
        private System.Windows.Forms.Timer timer2;
    }
}

