using System.Windows.Forms;
namespace Note_Taker
{
    partial class NoteTaker_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteTaker_Form));
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.AcceptsReturn = true;
            this.input_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.input_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_textbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_textbox.Location = new System.Drawing.Point(22, 12);
            this.input_textbox.MaximumSize = new System.Drawing.Size(500, 15);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(487, 15);
            this.input_textbox.TabIndex = 0;
            this.input_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_textbox_KeyPress);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "NoteTaker";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // NoteTaker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(532, 39);
            this.Controls.Add(this.input_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteTaker_Form";
            this.Opacity = 0.75D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteTaker_Form_FormClosing);
            this.Load += new System.EventHandler(this.NoteTaker_Form_Load);
            this.VisibleChanged += new System.EventHandler(this.NoteTaker_Form_Hide);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textbox;
        private NotifyIcon notifyIcon;
    }
}

