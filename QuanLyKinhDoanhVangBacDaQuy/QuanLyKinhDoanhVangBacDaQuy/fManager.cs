﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKinhDoanhVangBacDaQuy.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyKinhDoanhVangBacDaQuy
{
    public partial class fManager : Form
    {
        //Gọi các form mdi con
        fAdmin fAdmin;
        fAccountProfile fAccountProfile;
        FormSell fSell;
        FormBuy fBuy;
        FormService fService;
        FormListServiceReceipt fSearch;
        FormInventory fInventory;
        FormDashboard fDashboard;
        private string userName;
        //Khởi tạo Giao diện chính
        public fManager(string userName)
        {
            InitializeComponent();
            mdiProp();
            //Lưu tên tài khoản đăng nhập của người dùng
            this.userName = userName;
            //Hiển thị Form dashboard đầu tiên
            if (fDashboard == null)
            {
                fDashboard = new FormDashboard();
                fDashboard.FormClosed += fDashboard_FormClosed;
                fDashboard.MdiParent = this;
                fDashboard.Dock = DockStyle.Fill;
                fDashboard.Show();
            }
        }
        //Cài đặt nhỏ giao diện trang mdiParent
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        //Nút thoát chương trình
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Nút thu nhỏ chương trình
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Lấy giá trị chức vụ cho trang thông tin tài khoản
        private string LoadEmployeeInfo()
        {
            string query = "EXEC ThongTinCaNhan_TK_Ten @TaiKhoan ";

            var employeeData = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            return employeeData.Rows[0]["ChucVu"].ToString();
        }
        //Điều khiển thanh bên sidebar
        bool menuExpand = false;
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 220)
                {
                    MenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 70)
                {
                    MenuTransition.Stop();
                    menuExpand = false;
                }
            }

        }
        private void Settingbtn_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }
        //Đóng mở thanh bên
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 76)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 286)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
        //Nút mở rộng thanh bên
        private void Sidebarbtn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        //Nút đăng xuất
        private void Logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        //Nút Thông tin tài khoản
        private void Info_btn_Click(object sender, EventArgs e)
        {
            if (fAccountProfile == null)
            {
                fAccountProfile = new fAccountProfile(userName);
                fAccountProfile.FormClosed += fAccountProfile_FormClosed;
                fAccountProfile.MdiParent = this;
                fAccountProfile.Dock = DockStyle.Fill;
                fAccountProfile.Show();
            }
            else
            {
                fAccountProfile.Activate();
            }
        }
        private void fAccountProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            fAccountProfile = null;
        }
        //Nút Quản lý dữ liệu
        private void Admin_btn_Click(object sender, EventArgs e)
        {
            string checkAdmin = LoadEmployeeInfo();
            if (checkAdmin == "Quản lý")
            {
                if (fAdmin == null)
                {
                    fAdmin = new fAdmin();
                    fAdmin.FormClosed += fAdmin_FormClosed;
                    fAdmin.MdiParent = this;
                    fAdmin.Dock = DockStyle.Fill;
                    fAdmin.Show();
                }
                else
                {
                    fAdmin.Activate();
                }
            }
            else 
            {
                MessageBox.Show("Chỉ quản lý mới được truy cập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void fAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            fAdmin = null;
        }
        //Nút Phiếu bán hàng
        private void Sell_btn_Click(object sender, EventArgs e)
        {
            if (fSell == null)
            {
                fSell = new FormSell();
                fSell.FormClosed += fSell_FormClosed;
                fSell.MdiParent = this;
                fSell.Dock = DockStyle.Fill;
                fSell.Show();
            }
            else
            {
                fSell.Activate();
            }
        }
        private void fSell_FormClosed(object sender, FormClosedEventArgs e)
        {
            fSell = null;
        }
        //Nút Phiếu mua hàng
        private void Buy_btn_Click(object sender, EventArgs e)
        {
            if (fBuy == null)
            {
                fBuy = new FormBuy();
                fBuy.FormClosed += fBuy_FormClosed;
                fBuy.MdiParent = this;
                fBuy.Dock = DockStyle.Fill;
                fBuy.Show();
            }
            else
            {
                fBuy.Activate();
            }
        }
        private void fBuy_FormClosed(object sender, FormClosedEventArgs e)
        {
            fBuy = null;
        }
        //Nút Phiếu dịch vụ
        private void Service_btn_Click(object sender, EventArgs e)
        {
            if (fService == null)
            {
                fService = new FormService();
                fService.FormClosed += fService_FormClosed;
                fService.MdiParent = this;
                fService.Dock = DockStyle.Fill;
                fService.Show();
            }
            else
            {
                fService.Activate();
            }
        }
        private void fService_FormClosed(object sender, FormClosedEventArgs e)
        {
            fService = null;
        }
        //Nút Tra cứu dịch vụ
        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (fSearch == null)
            {
                fSearch = new FormListServiceReceipt();
                fSearch.FormClosed += fSearch_FormClosed;
                fSearch.MdiParent = this;
                fSearch.Dock = DockStyle.Fill;
                fSearch.Show();
            }
            else
            {
                fSearch.Activate();
            }
        }
        private void fSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            fSearch = null;
        }
        //Nút Báo cáo tồn kho
        private void Inven_btn_Click(object sender, EventArgs e)
        {
            if (fInventory == null)
            {
                fInventory = new FormInventory();
                fInventory.FormClosed += fInventory_FormClosed;
                fInventory.MdiParent = this;
                fInventory.Dock = DockStyle.Fill;
                fInventory.Show();
            }
            else
            {
                fInventory.Activate();
            }
        }
        private void fInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            fInventory = null;
        }
        //Nút Doanh thu
        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            if (fDashboard == null)
            {
                fDashboard = new FormDashboard();
                fDashboard.FormClosed += fDashboard_FormClosed;
                fDashboard.MdiParent = this;
                fDashboard.Dock = DockStyle.Fill;
                fDashboard.Show();
            }
            else
            {
                fDashboard.Activate();
            }
        }
        private void fDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDashboard = null;
        }
    }
}
