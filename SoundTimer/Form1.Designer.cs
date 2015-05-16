namespace SoundTimer
{
    partial class SoundTimer
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
            this.components = new System.ComponentModel.Container();
            this.lb_play = new System.Windows.Forms.Label();
            this.lb_stop = new System.Windows.Forms.Label();
            this.tb_play = new System.Windows.Forms.TextBox();
            this.tb_stop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_staus = new System.Windows.Forms.Label();
            this.lb_leftTime = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_play
            // 
            this.lb_play.AutoSize = true;
            this.lb_play.Location = new System.Drawing.Point(24, 38);
            this.lb_play.Name = "lb_play";
            this.lb_play.Size = new System.Drawing.Size(53, 12);
            this.lb_play.TabIndex = 0;
            this.lb_play.Text = "播放时间";
            // 
            // lb_stop
            // 
            this.lb_stop.AutoSize = true;
            this.lb_stop.Location = new System.Drawing.Point(24, 65);
            this.lb_stop.Name = "lb_stop";
            this.lb_stop.Size = new System.Drawing.Size(53, 12);
            this.lb_stop.TabIndex = 1;
            this.lb_stop.Text = "暂停时间";
            // 
            // tb_play
            // 
            this.tb_play.Location = new System.Drawing.Point(83, 35);
            this.tb_play.Name = "tb_play";
            this.tb_play.Size = new System.Drawing.Size(139, 21);
            this.tb_play.TabIndex = 2;
            this.tb_play.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_stop
            // 
            this.tb_stop.Location = new System.Drawing.Point(83, 62);
            this.tb_stop.Name = "tb_stop";
            this.tb_stop.Size = new System.Drawing.Size(139, 21);
            this.tb_stop.TabIndex = 3;
            this.tb_stop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分钟";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "分钟";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(83, 106);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_staus
            // 
            this.lb_staus.AutoSize = true;
            this.lb_staus.Location = new System.Drawing.Point(24, 111);
            this.lb_staus.Name = "lb_staus";
            this.lb_staus.Size = new System.Drawing.Size(0, 12);
            this.lb_staus.TabIndex = 7;
            // 
            // lb_leftTime
            // 
            this.lb_leftTime.AutoSize = true;
            this.lb_leftTime.Location = new System.Drawing.Point(81, 140);
            this.lb_leftTime.Name = "lb_leftTime";
            this.lb_leftTime.Size = new System.Drawing.Size(0, 12);
            this.lb_leftTime.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(164, 106);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(94, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(104, 16);
            this.title.TabIndex = 10;
            this.title.Text = "声音定时控制";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SoundTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lb_leftTime);
            this.Controls.Add(this.lb_staus);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_stop);
            this.Controls.Add(this.tb_play);
            this.Controls.Add(this.lb_stop);
            this.Controls.Add(this.lb_play);
            this.Name = "SoundTimer";
            this.Text = "SoundTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_play;
        private System.Windows.Forms.Label lb_stop;
        private System.Windows.Forms.TextBox tb_play;
        private System.Windows.Forms.TextBox tb_stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_staus;
        private System.Windows.Forms.Label lb_leftTime;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Timer timer;
    }
}

