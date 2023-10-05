using System.Security.Cryptography.X509Certificates;

namespace ChatEncryptionTools
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("The public key is empty! ", "Chat Encryption Tools");
                return;
            }
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Successfully copied to the clipboard! ", "Chat Encryption Tools");
        }

        private void Form_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You must first select a length option to survive the key pair! ", "Chat Encryption Tools");
                return;
            }
            (byte[] publicKey, byte[] privateKey) = YekongLib.Crypto.Asymmetric.RSA.GenerateKeyPair(
                    int.Parse(comboBox1.Text)
                );
            textBox1.Text = YekongLib.Crypto.Base64.Encode(publicKey);
            textBox2.Text = YekongLib.Crypto.Base64.Encode(privateKey);
            MessageBox.Show("RSA key pair generation completed! ", "Chat Encryption Tools");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("The public key is empty! ", "Chat Encryption Tools");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("The unencrypted data is empty! ", "Chat Encryption Tools");
                return;
            }

            try
            {
                byte[] data = YekongLib.Crypto.Asymmetric.RSA.Encrypt(
                    YekongLib.Utils.StringUtils.StringToByteArray(textBox5.Text),
                    YekongLib.Crypto.Base64.Decode(textBox3.Text)
                );
                textBox4.Text = YekongLib.Crypto.Base64.Encode(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while performing the operation: \n\n" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("The private key is empty! ", "Chat Encryption Tools");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("The encrypted data is empty! ", "Chat Encryption Tools");
                return;
            }

            try
            {
                byte[] data = YekongLib.Crypto.Asymmetric.RSA.Decrypt(
                    YekongLib.Crypto.Base64.Decode(textBox4.Text),
                    YekongLib.Crypto.Base64.Decode(textBox2.Text)
                );
                textBox5.Text = YekongLib.Utils.StringUtils.ByteArrayToString(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while performing the operation: \n\n" + ex.Message);
            }
        }
    }
}