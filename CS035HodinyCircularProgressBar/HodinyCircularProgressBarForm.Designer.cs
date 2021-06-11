
namespace CSOWNHodinyCircularProgressBar
{
    partial class HodinyCircularProgressBarForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HodinyCircularProgressBarForm));
            this.hodinyCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.minutyCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.sekundyCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.dnyCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.mesicCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.rokCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.denCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hodinyCircularProgressBar
            // 
            this.hodinyCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.hodinyCircularProgressBar.AnimationSpeed = 500;
            this.hodinyCircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.hodinyCircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.hodinyCircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hodinyCircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hodinyCircularProgressBar.InnerMargin = 2;
            this.hodinyCircularProgressBar.InnerWidth = -1;
            this.hodinyCircularProgressBar.Location = new System.Drawing.Point(108, 12);
            this.hodinyCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.hodinyCircularProgressBar.Maximum = 24;
            this.hodinyCircularProgressBar.Name = "hodinyCircularProgressBar";
            this.hodinyCircularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.hodinyCircularProgressBar.OuterMargin = -25;
            this.hodinyCircularProgressBar.OuterWidth = 26;
            this.hodinyCircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hodinyCircularProgressBar.ProgressWidth = 25;
            this.hodinyCircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.hodinyCircularProgressBar.Size = new System.Drawing.Size(200, 200);
            this.hodinyCircularProgressBar.StartAngle = 270;
            this.hodinyCircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.hodinyCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.hodinyCircularProgressBar.SubscriptText = "";
            this.hodinyCircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.hodinyCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.hodinyCircularProgressBar.SuperscriptText = " ";
            this.hodinyCircularProgressBar.TabIndex = 0;
            this.hodinyCircularProgressBar.Text = "{0} {1}";
            this.hodinyCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.hodinyCircularProgressBar.Value = 23;
            // 
            // minutyCircularProgressBar
            // 
            this.minutyCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.minutyCircularProgressBar.AnimationSpeed = 500;
            this.minutyCircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.minutyCircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.minutyCircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minutyCircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minutyCircularProgressBar.InnerMargin = 2;
            this.minutyCircularProgressBar.InnerWidth = -1;
            this.minutyCircularProgressBar.Location = new System.Drawing.Point(350, 12);
            this.minutyCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.minutyCircularProgressBar.Maximum = 60;
            this.minutyCircularProgressBar.Name = "minutyCircularProgressBar";
            this.minutyCircularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.minutyCircularProgressBar.OuterMargin = -25;
            this.minutyCircularProgressBar.OuterWidth = 26;
            this.minutyCircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minutyCircularProgressBar.ProgressWidth = 25;
            this.minutyCircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.minutyCircularProgressBar.Size = new System.Drawing.Size(200, 200);
            this.minutyCircularProgressBar.StartAngle = 270;
            this.minutyCircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.minutyCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.minutyCircularProgressBar.SubscriptText = "";
            this.minutyCircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.minutyCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.minutyCircularProgressBar.SuperscriptText = " ";
            this.minutyCircularProgressBar.TabIndex = 1;
            this.minutyCircularProgressBar.Text = "{0} {1}";
            this.minutyCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.minutyCircularProgressBar.Value = 59;
            // 
            // sekundyCircularProgressBar
            // 
            this.sekundyCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.sekundyCircularProgressBar.AnimationSpeed = 500;
            this.sekundyCircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.sekundyCircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.sekundyCircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sekundyCircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sekundyCircularProgressBar.InnerMargin = 2;
            this.sekundyCircularProgressBar.InnerWidth = -1;
            this.sekundyCircularProgressBar.Location = new System.Drawing.Point(595, 12);
            this.sekundyCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.sekundyCircularProgressBar.Maximum = 60;
            this.sekundyCircularProgressBar.Name = "sekundyCircularProgressBar";
            this.sekundyCircularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.sekundyCircularProgressBar.OuterMargin = -25;
            this.sekundyCircularProgressBar.OuterWidth = 26;
            this.sekundyCircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sekundyCircularProgressBar.ProgressWidth = 25;
            this.sekundyCircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.sekundyCircularProgressBar.Size = new System.Drawing.Size(200, 200);
            this.sekundyCircularProgressBar.StartAngle = 270;
            this.sekundyCircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.sekundyCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.sekundyCircularProgressBar.SubscriptText = "";
            this.sekundyCircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.sekundyCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.sekundyCircularProgressBar.SuperscriptText = " ";
            this.sekundyCircularProgressBar.TabIndex = 2;
            this.sekundyCircularProgressBar.Text = "{0} {1}";
            this.sekundyCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.sekundyCircularProgressBar.Value = 59;
            // 
            // dnyCircularProgressBar
            // 
            this.dnyCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.dnyCircularProgressBar.AnimationSpeed = 500;
            this.dnyCircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.dnyCircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.dnyCircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dnyCircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dnyCircularProgressBar.InnerMargin = 2;
            this.dnyCircularProgressBar.InnerWidth = -1;
            this.dnyCircularProgressBar.Location = new System.Drawing.Point(12, 237);
            this.dnyCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.dnyCircularProgressBar.Maximum = 7;
            this.dnyCircularProgressBar.Name = "dnyCircularProgressBar";
            this.dnyCircularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.dnyCircularProgressBar.OuterMargin = -25;
            this.dnyCircularProgressBar.OuterWidth = 26;
            this.dnyCircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dnyCircularProgressBar.ProgressWidth = 25;
            this.dnyCircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.dnyCircularProgressBar.Size = new System.Drawing.Size(200, 200);
            this.dnyCircularProgressBar.StartAngle = 270;
            this.dnyCircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dnyCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.dnyCircularProgressBar.SubscriptText = "";
            this.dnyCircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dnyCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.dnyCircularProgressBar.SuperscriptText = " ";
            this.dnyCircularProgressBar.TabIndex = 3;
            this.dnyCircularProgressBar.Text = "{0}";
            this.dnyCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.dnyCircularProgressBar.Value = 7;
            // 
            // mesicCircularProgressBar
            // 
            this.mesicCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.mesicCircularProgressBar.AnimationSpeed = 500;
            this.mesicCircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.mesicCircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.mesicCircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mesicCircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mesicCircularProgressBar.InnerMargin = 2;
            this.mesicCircularProgressBar.InnerWidth = -1;
            this.mesicCircularProgressBar.Location = new System.Drawing.Point(472, 237);
            this.mesicCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.mesicCircularProgressBar.Maximum = 12;
            this.mesicCircularProgressBar.Name = "mesicCircularProgressBar";
            this.mesicCircularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.mesicCircularProgressBar.OuterMargin = -25;
            this.mesicCircularProgressBar.OuterWidth = 26;
            this.mesicCircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mesicCircularProgressBar.ProgressWidth = 25;
            this.mesicCircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.mesicCircularProgressBar.Size = new System.Drawing.Size(200, 200);
            this.mesicCircularProgressBar.StartAngle = 270;
            this.mesicCircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.mesicCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.mesicCircularProgressBar.SubscriptText = "";
            this.mesicCircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.mesicCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.mesicCircularProgressBar.SuperscriptText = " ";
            this.mesicCircularProgressBar.TabIndex = 4;
            this.mesicCircularProgressBar.Text = "{0}";
            this.mesicCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.mesicCircularProgressBar.Value = 1;
            // 
            // rokCircularProgressBar
            // 
            this.rokCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.rokCircularProgressBar.AnimationSpeed = 500;
            this.rokCircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.rokCircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.rokCircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rokCircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rokCircularProgressBar.InnerMargin = 2;
            this.rokCircularProgressBar.InnerWidth = -1;
            this.rokCircularProgressBar.Location = new System.Drawing.Point(678, 237);
            this.rokCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.rokCircularProgressBar.Maximum = 2030;
            this.rokCircularProgressBar.Minimum = 2020;
            this.rokCircularProgressBar.Name = "rokCircularProgressBar";
            this.rokCircularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.rokCircularProgressBar.OuterMargin = -25;
            this.rokCircularProgressBar.OuterWidth = 26;
            this.rokCircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rokCircularProgressBar.ProgressWidth = 25;
            this.rokCircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.rokCircularProgressBar.Size = new System.Drawing.Size(200, 200);
            this.rokCircularProgressBar.StartAngle = 270;
            this.rokCircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rokCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.rokCircularProgressBar.SubscriptText = "";
            this.rokCircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rokCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.rokCircularProgressBar.SuperscriptText = " ";
            this.rokCircularProgressBar.TabIndex = 4;
            this.rokCircularProgressBar.Text = "{0}";
            this.rokCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.rokCircularProgressBar.Value = 2020;
            // 
            // denCircularProgressBar
            // 
            this.denCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.denCircularProgressBar.AnimationSpeed = 500;
            this.denCircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.denCircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.denCircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.denCircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.denCircularProgressBar.InnerMargin = 2;
            this.denCircularProgressBar.InnerWidth = -1;
            this.denCircularProgressBar.Location = new System.Drawing.Point(266, 237);
            this.denCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.denCircularProgressBar.Maximum = 31;
            this.denCircularProgressBar.Name = "denCircularProgressBar";
            this.denCircularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.denCircularProgressBar.OuterMargin = -25;
            this.denCircularProgressBar.OuterWidth = 26;
            this.denCircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.denCircularProgressBar.ProgressWidth = 25;
            this.denCircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.denCircularProgressBar.Size = new System.Drawing.Size(200, 200);
            this.denCircularProgressBar.StartAngle = 270;
            this.denCircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.denCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.denCircularProgressBar.SubscriptText = "";
            this.denCircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.denCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.denCircularProgressBar.SuperscriptText = " ";
            this.denCircularProgressBar.TabIndex = 5;
            this.denCircularProgressBar.Text = "{0}.";
            this.denCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.denCircularProgressBar.Value = 31;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // HodinyCircularProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 461);
            this.Controls.Add(this.denCircularProgressBar);
            this.Controls.Add(this.rokCircularProgressBar);
            this.Controls.Add(this.mesicCircularProgressBar);
            this.Controls.Add(this.dnyCircularProgressBar);
            this.Controls.Add(this.sekundyCircularProgressBar);
            this.Controls.Add(this.minutyCircularProgressBar);
            this.Controls.Add(this.hodinyCircularProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HodinyCircularProgressBarForm";
            this.Text = "CS035CircularProgressBarHodiny - Hofman Karel";
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar hodinyCircularProgressBar;
        private CircularProgressBar.CircularProgressBar minutyCircularProgressBar;
        private CircularProgressBar.CircularProgressBar sekundyCircularProgressBar;
        private CircularProgressBar.CircularProgressBar dnyCircularProgressBar;
        private CircularProgressBar.CircularProgressBar mesicCircularProgressBar;
        private CircularProgressBar.CircularProgressBar rokCircularProgressBar;
        private CircularProgressBar.CircularProgressBar denCircularProgressBar;
        private System.Windows.Forms.Timer timer;
    }
}

