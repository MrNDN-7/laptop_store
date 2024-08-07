using CNPM10_Laptop.BLLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM10_Laptop.AdminForm
{
    public partial class HoTroKH_Admin : Form
    {
        BLChat blChat = new BLChat();
        public string chatOfMaKH;
        public HoTroKH_Admin()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            List<string> chatText = blChat.GetChatbyID(chatOfMaKH);

            // Hiển thị giá trị trong TextBox
            if (chatText.Count > 0)
            {
                txtDisplayChat.Text = string.Join(Environment.NewLine, chatText);
            }
            else
            {
                txtDisplayChat.Text = "No chat found.";
            }

        }
        void LoadcmbMaKH()
        {
            this.cmbKH.Items.Clear();
            foreach (string maKH in blChat.GetMaKHChat())
            {
                this.cmbKH.Items.Add(maKH);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string role = "Admin";
            if (txtMaKH.Text != "")
            {
                chatOfMaKH = txtMaKH.Text;
                cmbKH.Text = txtMaKH.Text;
            }
            blChat.SendChat(chatOfMaKH, txtChat.Text.Trim(), role);
            LoadcmbMaKH();
            LoadData();
            txtChat.Text = "Text here...";
            txtChat.ForeColor = Color.Silver;
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            chatOfMaKH = this.cmbKH.SelectedItem as string;
            LoadData();
            cmbKH.Text = cmbKH.SelectedItem.ToString();
        }

        private void txtChat_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtChat.Text = "";
            this.txtChat.ForeColor = Color.Black;
        }

        private void btnDeleteChat_Click(object sender, EventArgs e)
        {
            blChat.DeleteChat(this.cmbKH.SelectedItem as string);
            cmbKH.Text = "";
            LoadcmbMaKH();
            LoadData();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKH.Text != null)
            {
                txtMaKH.Text = txtMaKH.Text.ToUpper(); // Chuyển đổi dữ liệu nhập thành chữ hoa
                txtMaKH.SelectionStart = txtMaKH.Text.Length; // Đặt con trỏ văn bản ở cuối TextBox
            }
        }

        private void HoTroKH_Admin_Load(object sender, EventArgs e)
        {
            LoadcmbMaKH();
        }
    }
}
