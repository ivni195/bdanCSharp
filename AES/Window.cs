using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AES
{
    public partial class Window : Form
    {
        private State state;
        private byte[] CurrentKey;
        private byte[] CurrentCipher;
        
        
        private static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        
        private static byte[] StringToByteArray(string hex) {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        private void ChangeTextBoxes()
        {
            // Message.Text = state.Message;
            Key.Text = ByteArrayToString(CurrentKey);
            Cipher.Text = ByteArrayToString(CurrentCipher);
        }
        public Window()
        {
            InitializeComponent();
            state = new State();
            
            Message.Text = state.Message;
            Key.Text = ByteArrayToString(state.Key);
            
            state.CipherText = state.Encypt(state.Message, state.Key, state.IV);
            File.WriteAllBytes(@"C:\Users\kuba1\Desktop\crypt\crypt\AES\encrypted.txt", state.CipherText);
            
            Cipher.Text = ByteArrayToString(state.CipherText);

            CurrentCipher = state.CipherText;
            CurrentKey = state.Key;
        }

        private void Decrypt_Click_1(object sender, EventArgs e)
        {
            Message.Text = state.Decrypt(CurrentCipher, CurrentKey, state.IV);
        }

        private void Valid_CheckedChanged(object sender, EventArgs e)
        {
            if (Valid.Checked)
            {
                CurrentCipher = state.CipherText;
                CurrentKey = state.Key;
                ChangeTextBoxes();
            }
        }

        private void ErrorFile_CheckedChanged(object sender, EventArgs e)
        {
            if (ErrorFile.Checked)
            {
                CurrentCipher = state.InvalidCipher;
                CurrentKey = state.Key;
                ChangeTextBoxes();
            }
        }

        private void ErrorKey_CheckedChanged(object sender, EventArgs e)
        {
            if (ErrorKey.Checked)
            {
                CurrentCipher = state.CipherText;
                CurrentKey = state.InvalidKey;
                ChangeTextBoxes();
            }
        }
    }
}