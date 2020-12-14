
namespace drowing_lines_and_other_things
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.changeModeButton = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.change_brush_butt = new System.Windows.Forms.Button();
            this.resizebutt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            this.SuspendLayout();
            // 
            // changeModeButton
            // 
            this.changeModeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changeModeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.changeModeButton, "changeModeButton");
            this.changeModeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeModeButton.Name = "changeModeButton";
            this.changeModeButton.UseVisualStyleBackColor = false;
            this.changeModeButton.Click += new System.EventHandler(this.click_ChangeModeButton);
            // 
            // paper
            // 
            resources.ApplyResources(this.paper, "paper");
            this.paper.Name = "paper";
            this.paper.TabStop = false;
            this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paper_MouseDown);
            this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paper_MauseUp);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.load.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.load, "load");
            this.load.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.load.Name = "load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.Load_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.save, "save");
            this.save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // change_brush_butt
            // 
            this.change_brush_butt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.change_brush_butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.change_brush_butt, "change_brush_butt");
            this.change_brush_butt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.change_brush_butt.Name = "change_brush_butt";
            this.change_brush_butt.UseVisualStyleBackColor = false;
            this.change_brush_butt.Click += new System.EventHandler(this.change_brush_butt_Click);
            // 
            // resizebutt
            // 
            this.resizebutt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizebutt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.resizebutt, "resizebutt");
            this.resizebutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resizebutt.Name = "resizebutt";
            this.resizebutt.UseVisualStyleBackColor = false;
            this.resizebutt.Click += new System.EventHandler(this.resizebutt_Click);
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.resizebutt);
            this.Controls.Add(this.change_brush_butt);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Controls.Add(this.changeModeButton);
            this.Controls.Add(this.paper);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeModeButton;
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button change_brush_butt;
        private System.Windows.Forms.Button resizebutt;
    }
}

