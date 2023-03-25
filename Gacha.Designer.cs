namespace Gacha
{
    partial class Gacha
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
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card10 = new System.Windows.Forms.PictureBox();
            this.card9 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            this.SuspendLayout();
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(51, 50);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(100, 130);
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card1_Click);
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(222, 50);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(100, 130);
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card2_Click);
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(389, 50);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(100, 130);
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card3_Click);
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(556, 50);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(100, 130);
            this.card4.TabIndex = 3;
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.card4_Click);
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(721, 50);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(100, 130);
            this.card5.TabIndex = 4;
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.card5_Click);
            // 
            // card10
            // 
            this.card10.Location = new System.Drawing.Point(721, 245);
            this.card10.Name = "card10";
            this.card10.Size = new System.Drawing.Size(100, 130);
            this.card10.TabIndex = 9;
            this.card10.TabStop = false;
            this.card10.Click += new System.EventHandler(this.card10_Click);
            // 
            // card9
            // 
            this.card9.Location = new System.Drawing.Point(556, 245);
            this.card9.Name = "card9";
            this.card9.Size = new System.Drawing.Size(100, 130);
            this.card9.TabIndex = 8;
            this.card9.TabStop = false;
            this.card9.Click += new System.EventHandler(this.card9_Click);
            // 
            // card8
            // 
            this.card8.Location = new System.Drawing.Point(389, 245);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(100, 130);
            this.card8.TabIndex = 7;
            this.card8.TabStop = false;
            this.card8.Click += new System.EventHandler(this.card8_Click);
            // 
            // card7
            // 
            this.card7.Location = new System.Drawing.Point(222, 245);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(100, 130);
            this.card7.TabIndex = 6;
            this.card7.TabStop = false;
            this.card7.Click += new System.EventHandler(this.card7_Click);
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(51, 245);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(100, 130);
            this.card6.TabIndex = 5;
            this.card6.TabStop = false;
            this.card6.Click += new System.EventHandler(this.card6_Click);
            // 
            // btn_All
            // 
            this.btn_All.BackColor = System.Drawing.Color.White;
            this.btn_All.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_All.Location = new System.Drawing.Point(317, 395);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(103, 30);
            this.btn_All.TabIndex = 10;
            this.btn_All.Text = "일괄뽑기";
            this.btn_All.UseVisualStyleBackColor = false;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Reset.Location = new System.Drawing.Point(454, 395);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(103, 30);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "초기화";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Gacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 437);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.card10);
            this.Controls.Add(this.card9);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Name = "Gacha";
            this.Text = "장근_카드뽑기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gacha_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card10;
        private System.Windows.Forms.PictureBox card9;
        private System.Windows.Forms.PictureBox card8;
        private System.Windows.Forms.PictureBox card7;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_Reset;
    }
}

