using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotkeys;

namespace Note_Taker
{
    public partial class NoteTaker_Form : Form
    {

        private Hotkeys.GlobalHotkey ghk;


        public NoteTaker_Form()
        {
            InitializeComponent();
            ghk = new Hotkeys.GlobalHotkey(Constants.WIN , Keys.NumPad0, this);
            this.ShowInTaskbar = false;
        }

        private void HandleHotkey()
        {
            this.Visible = true;
            this.input_textbox.Focus();
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void NoteTaker_Form_Load(object sender, EventArgs e)
        {
             System.Diagnostics.Debug.WriteLine("Trying to register hotkey");
	            if (ghk.Register())
                    System.Diagnostics.Debug.WriteLine("Hotkey registered.");
	            else
                    System.Diagnostics.Debug.WriteLine("Hotkey failed to register");   
        }

        private void NoteTaker_Form_FormClosing(object sender, EventArgs e)
        {
            if (!ghk.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
        }

        private void input_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 ) // check if enter key hit
            {
                //Record input to file
                LogNote(input_textbox.Text);
                input_textbox.Text = "";
                e.Handled = true;

                //Hide form
                this.Visible = false;
            }
        }

        private void NoteTaker_Form_Hide(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                notifyIcon.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void LogNote(string notetext)
        {

            notetext = FormatNote(notetext);

            string filename = @"D:\Users\Richard\Documents\OutputFile.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
                file.WriteLine(notetext);
            }
        }

        private string FormatNote(string notetext)
        {
            string formatted_time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string formatted_notetext = String.Format("{0}\t{1}", formatted_time, notetext);
            return formatted_notetext;
        }
    }
}
