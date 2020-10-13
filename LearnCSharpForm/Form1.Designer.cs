namespace LearnCSharpForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Welcome_Info = new System.Windows.Forms.Label();
            this.Anime_Controller = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Welcome_Info
            // 
            this.Welcome_Info.AutoSize = true;
            this.Welcome_Info.Font = new System.Drawing.Font("HGF3_CNKI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Welcome_Info.ForeColor = System.Drawing.Color.White;
            this.Welcome_Info.Location = new System.Drawing.Point(152, 191);
            this.Welcome_Info.Name = "Welcome_Info";
            this.Welcome_Info.Size = new System.Drawing.Size(146, 49);
            this.Welcome_Info.TabIndex = 0;
            this.Welcome_Info.Text = "Welcome";
            this.Welcome_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Anime_Controller
            // 
            this.Anime_Controller.Tick += new System.EventHandler(this.Anime_Controller_Tick);
            // 
            // ColorDepth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Welcome_Info);
            this.Name = "ColorDepth";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_Info;
        private System.Windows.Forms.Timer Anime_Controller;
    }
}

