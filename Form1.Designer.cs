namespace WindowsFormsApp_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.button_ResetPosition = new System.Windows.Forms.Button();
            this.checkBox_DisplayWindow = new System.Windows.Forms.CheckBox();
            this.trackBar_Move = new System.Windows.Forms.TrackBar();
            this.trackBar_Width = new System.Windows.Forms.TrackBar();
            this.trackBar_Height = new System.Windows.Forms.TrackBar();
            this.trackBar_R = new System.Windows.Forms.TrackBar();
            this.trackBar_G = new System.Windows.Forms.TrackBar();
            this.trackBar_B = new System.Windows.Forms.TrackBar();
            this.label_MoveValue = new System.Windows.Forms.Label();
            this.label_Move = new System.Windows.Forms.Label();
            this.label_Width = new System.Windows.Forms.Label();
            this.label_WidthValue = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.label_HeightValue = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.label_RValue = new System.Windows.Forms.Label();
            this.label_G = new System.Windows.Forms.Label();
            this.label_GValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_BValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Up
            // 
            this.button_Up.Location = new System.Drawing.Point(56, 14);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(33, 30);
            this.button_Up.TabIndex = 0;
            this.button_Up.Text = "↑";
            this.button_Up.UseVisualStyleBackColor = true;
            // 
            // button_Left
            // 
            this.button_Left.Location = new System.Drawing.Point(12, 57);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(33, 30);
            this.button_Left.TabIndex = 1;
            this.button_Left.Text = "←";
            this.button_Left.UseVisualStyleBackColor = true;
            // 
            // button_Down
            // 
            this.button_Down.Location = new System.Drawing.Point(56, 98);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(33, 30);
            this.button_Down.TabIndex = 2;
            this.button_Down.Text = "↓";
            this.button_Down.UseVisualStyleBackColor = true;
            // 
            // button_Right
            // 
            this.button_Right.Location = new System.Drawing.Point(99, 57);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(33, 30);
            this.button_Right.TabIndex = 3;
            this.button_Right.Text = "→";
            this.button_Right.UseVisualStyleBackColor = true;
            // 
            // button_ResetPosition
            // 
            this.button_ResetPosition.Location = new System.Drawing.Point(57, 57);
            this.button_ResetPosition.Name = "button_ResetPosition";
            this.button_ResetPosition.Size = new System.Drawing.Size(33, 30);
            this.button_ResetPosition.TabIndex = 4;
            this.button_ResetPosition.Text = "・";
            this.button_ResetPosition.UseVisualStyleBackColor = true;
            // 
            // checkBox_DisplayWindow
            // 
            this.checkBox_DisplayWindow.AutoSize = true;
            this.checkBox_DisplayWindow.Location = new System.Drawing.Point(184, 28);
            this.checkBox_DisplayWindow.Name = "checkBox_DisplayWindow";
            this.checkBox_DisplayWindow.Size = new System.Drawing.Size(105, 16);
            this.checkBox_DisplayWindow.TabIndex = 5;
            this.checkBox_DisplayWindow.Text = "子ウインドウ表示";
            this.checkBox_DisplayWindow.UseVisualStyleBackColor = true;
            // 
            // trackBar_Move
            // 
            this.trackBar_Move.Location = new System.Drawing.Point(257, 57);
            this.trackBar_Move.Maximum = 100;
            this.trackBar_Move.Name = "trackBar_Move";
            this.trackBar_Move.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Move.TabIndex = 6;
            this.trackBar_Move.Scroll += new System.EventHandler(this.trackBar_Move_Scroll);
            // 
            // trackBar_Width
            // 
            this.trackBar_Width.Location = new System.Drawing.Point(257, 108);
            this.trackBar_Width.Maximum = 1920;
            this.trackBar_Width.Name = "trackBar_Width";
            this.trackBar_Width.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Width.TabIndex = 7;
            // 
            // trackBar_Height
            // 
            this.trackBar_Height.Location = new System.Drawing.Point(257, 159);
            this.trackBar_Height.Maximum = 1080;
            this.trackBar_Height.Name = "trackBar_Height";
            this.trackBar_Height.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Height.TabIndex = 8;
            // 
            // trackBar_R
            // 
            this.trackBar_R.Location = new System.Drawing.Point(257, 225);
            this.trackBar_R.Maximum = 256;
            this.trackBar_R.Name = "trackBar_R";
            this.trackBar_R.Size = new System.Drawing.Size(104, 45);
            this.trackBar_R.TabIndex = 9;
            // 
            // trackBar_G
            // 
            this.trackBar_G.Location = new System.Drawing.Point(257, 276);
            this.trackBar_G.Maximum = 256;
            this.trackBar_G.Name = "trackBar_G";
            this.trackBar_G.Size = new System.Drawing.Size(104, 45);
            this.trackBar_G.TabIndex = 10;
            // 
            // trackBar_B
            // 
            this.trackBar_B.Location = new System.Drawing.Point(257, 327);
            this.trackBar_B.Maximum = 256;
            this.trackBar_B.Name = "trackBar_B";
            this.trackBar_B.Size = new System.Drawing.Size(104, 45);
            this.trackBar_B.TabIndex = 11;
            // 
            // label_MoveValue
            // 
            this.label_MoveValue.AutoSize = true;
            this.label_MoveValue.Location = new System.Drawing.Point(217, 66);
            this.label_MoveValue.Name = "label_MoveValue";
            this.label_MoveValue.Size = new System.Drawing.Size(11, 12);
            this.label_MoveValue.TabIndex = 12;
            this.label_MoveValue.Text = "0";
            // 
            // label_Move
            // 
            this.label_Move.AutoSize = true;
            this.label_Move.Location = new System.Drawing.Point(164, 66);
            this.label_Move.Name = "label_Move";
            this.label_Move.Size = new System.Drawing.Size(47, 12);
            this.label_Move.TabIndex = 13;
            this.label_Move.Text = "移動量：";
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Location = new System.Drawing.Point(164, 116);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(23, 12);
            this.label_Width.TabIndex = 15;
            this.label_Width.Text = "幅：";
            // 
            // label_WidthValue
            // 
            this.label_WidthValue.AutoSize = true;
            this.label_WidthValue.Location = new System.Drawing.Point(217, 116);
            this.label_WidthValue.Name = "label_WidthValue";
            this.label_WidthValue.Size = new System.Drawing.Size(11, 12);
            this.label_WidthValue.TabIndex = 14;
            this.label_WidthValue.Text = "0";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Location = new System.Drawing.Point(164, 167);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(31, 12);
            this.label_Height.TabIndex = 17;
            this.label_Height.Text = "高さ：";
            // 
            // label_HeightValue
            // 
            this.label_HeightValue.AutoSize = true;
            this.label_HeightValue.Location = new System.Drawing.Point(217, 167);
            this.label_HeightValue.Name = "label_HeightValue";
            this.label_HeightValue.Size = new System.Drawing.Size(11, 12);
            this.label_HeightValue.TabIndex = 16;
            this.label_HeightValue.Text = "0";
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(164, 234);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(39, 12);
            this.label_R.TabIndex = 19;
            this.label_R.Text = "色(R)：";
            // 
            // label_RValue
            // 
            this.label_RValue.AutoSize = true;
            this.label_RValue.Location = new System.Drawing.Point(217, 234);
            this.label_RValue.Name = "label_RValue";
            this.label_RValue.Size = new System.Drawing.Size(11, 12);
            this.label_RValue.TabIndex = 18;
            this.label_RValue.Text = "0";
            // 
            // label_G
            // 
            this.label_G.AutoSize = true;
            this.label_G.Location = new System.Drawing.Point(164, 287);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(39, 12);
            this.label_G.TabIndex = 21;
            this.label_G.Text = "色(G)：";
            // 
            // label_GValue
            // 
            this.label_GValue.AutoSize = true;
            this.label_GValue.Location = new System.Drawing.Point(217, 287);
            this.label_GValue.Name = "label_GValue";
            this.label_GValue.Size = new System.Drawing.Size(11, 12);
            this.label_GValue.TabIndex = 20;
            this.label_GValue.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "色(B)：";
            // 
            // label_BValue
            // 
            this.label_BValue.AutoSize = true;
            this.label_BValue.Location = new System.Drawing.Point(217, 336);
            this.label_BValue.Name = "label_BValue";
            this.label_BValue.Size = new System.Drawing.Size(11, 12);
            this.label_BValue.TabIndex = 22;
            this.label_BValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 380);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_BValue);
            this.Controls.Add(this.label_G);
            this.Controls.Add(this.label_GValue);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.label_RValue);
            this.Controls.Add(this.label_Height);
            this.Controls.Add(this.label_HeightValue);
            this.Controls.Add(this.label_Width);
            this.Controls.Add(this.label_WidthValue);
            this.Controls.Add(this.label_Move);
            this.Controls.Add(this.label_MoveValue);
            this.Controls.Add(this.trackBar_B);
            this.Controls.Add(this.trackBar_G);
            this.Controls.Add(this.trackBar_R);
            this.Controls.Add(this.trackBar_Height);
            this.Controls.Add(this.trackBar_Width);
            this.Controls.Add(this.trackBar_Move);
            this.Controls.Add(this.checkBox_DisplayWindow);
            this.Controls.Add(this.button_ResetPosition);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_Down);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Up);
            this.Name = "Form1";
            this.Text = "課題①";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button button_ResetPosition;
        private System.Windows.Forms.CheckBox checkBox_DisplayWindow;
        private System.Windows.Forms.TrackBar trackBar_Move;
        private System.Windows.Forms.TrackBar trackBar_Width;
        private System.Windows.Forms.TrackBar trackBar_Height;
        private System.Windows.Forms.TrackBar trackBar_R;
        private System.Windows.Forms.TrackBar trackBar_G;
        private System.Windows.Forms.TrackBar trackBar_B;
        private System.Windows.Forms.Label label_MoveValue;
        private System.Windows.Forms.Label label_Move;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.Label label_WidthValue;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.Label label_HeightValue;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label_RValue;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.Label label_GValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_BValue;
    }
}

