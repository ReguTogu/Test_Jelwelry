namespace QuanLyKinhDoanhVangBacDaQuy
{
    partial class fManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            tcManager = new TabControl();
            tbThanhToan = new TabPage();
            panel5 = new Panel();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            listView1 = new ListView();
            panel4 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            labelPhieuBH = new Label();
            nmJewelryCount = new NumericUpDown();
            btnAddJewelry = new Button();
            cbJewelry = new ComboBox();
            cbCategory = new ComboBox();
            panel3 = new Panel();
            btnCheckOut = new Button();
            panel2 = new Panel();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            lsvBill = new ListView();
            tpPhieuBanHang = new TabPage();
            listView2 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            tpPhieuNhapHang = new TabPage();
            listView3 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            tpTraCuuDichVu = new TabPage();
            listView4 = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            tpPhieuDichVu = new TabPage();
            listView5 = new ListView();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            tpBaoCaoTonKho = new TabPage();
            listView6 = new ListView();
            columnHeader25 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
            columnHeader29 = new ColumnHeader();
            columnHeader30 = new ColumnHeader();
            tpKhachHang = new TabPage();
            panel47 = new Panel();
            panel49 = new Panel();
            textBox5 = new TextBox();
            label32 = new Label();
            panel50 = new Panel();
            txbServiceName = new TextBox();
            label33 = new Label();
            panel52 = new Panel();
            txbSearchService = new TextBox();
            btnSearchService = new Button();
            panel53 = new Panel();
            dtgvService = new DataGridView();
            panel54 = new Panel();
            btnShowService = new Button();
            btnAddService = new Button();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader31 = new ColumnHeader();
            columnHeader32 = new ColumnHeader();
            columnHeader33 = new ColumnHeader();
            columnHeader34 = new ColumnHeader();
            columnHeader35 = new ColumnHeader();
            columnHeader36 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            tcManager.SuspendLayout();
            tbThanhToan.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmJewelryCount).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tpPhieuBanHang.SuspendLayout();
            tpPhieuNhapHang.SuspendLayout();
            tpTraCuuDichVu.SuspendLayout();
            tpPhieuDichVu.SuspendLayout();
            tpBaoCaoTonKho.SuspendLayout();
            tpKhachHang.SuspendLayout();
            panel47.SuspendLayout();
            panel49.SuspendLayout();
            panel50.SuspendLayout();
            panel52.SuspendLayout();
            panel53.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvService).BeginInit();
            panel54.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1244, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(81, 29);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(182, 29);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // thôngCáNhânToolStripMenuItem
            // 
            thôngCáNhânToolStripMenuItem.Name = "thôngCáNhânToolStripMenuItem";
            thôngCáNhânToolStripMenuItem.Size = new Size(256, 34);
            thôngCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngCáNhânToolStripMenuItem.Click += thôngCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(256, 34);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // tcManager
            // 
            tcManager.Controls.Add(tbThanhToan);
            tcManager.Controls.Add(tpPhieuBanHang);
            tcManager.Controls.Add(tpPhieuNhapHang);
            tcManager.Controls.Add(tpTraCuuDichVu);
            tcManager.Controls.Add(tpPhieuDichVu);
            tcManager.Controls.Add(tpBaoCaoTonKho);
            tcManager.Controls.Add(tpKhachHang);
            tcManager.Location = new Point(0, 36);
            tcManager.Name = "tcManager";
            tcManager.SelectedIndex = 0;
            tcManager.Size = new Size(1222, 650);
            tcManager.TabIndex = 0;
            // 
            // tbThanhToan
            // 
            tbThanhToan.Controls.Add(panel5);
            tbThanhToan.Controls.Add(panel4);
            tbThanhToan.Controls.Add(panel3);
            tbThanhToan.Controls.Add(panel2);
            tbThanhToan.Location = new Point(4, 34);
            tbThanhToan.Name = "tbThanhToan";
            tbThanhToan.Size = new Size(1214, 612);
            tbThanhToan.TabIndex = 4;
            tbThanhToan.Text = "Thanh toán";
            tbThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(listView1);
            panel5.Location = new Point(511, 117);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(489, 332);
            panel5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 31);
            textBox4.TabIndex = 3;
            textBox4.Text = "Thành tiền";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 298);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 31);
            textBox2.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader33, columnHeader34, columnHeader35, columnHeader36 });
            listView1.Location = new Point(25, 19);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(441, 275);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(nmJewelryCount);
            panel4.Controls.Add(btnAddJewelry);
            panel4.Controls.Add(cbJewelry);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(9, 15);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(995, 98);
            panel4.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(502, 64);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(120, 34);
            button2.TabIndex = 8;
            button2.Text = "Mã dịch vụ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(25, 64);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 7;
            button1.Text = "Mã sản phẩm";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelPhieuBH);
            panel1.Location = new Point(823, 15);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 51);
            panel1.TabIndex = 6;
            // 
            // labelPhieuBH
            // 
            labelPhieuBH.AutoSize = true;
            labelPhieuBH.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhieuBH.ForeColor = SystemColors.WindowText;
            labelPhieuBH.Location = new Point(14, 1);
            labelPhieuBH.Margin = new Padding(4, 0, 4, 0);
            labelPhieuBH.Name = "labelPhieuBH";
            labelPhieuBH.Size = new Size(139, 32);
            labelPhieuBH.TabIndex = 5;
            labelPhieuBH.Text = "Thanh toán";
            labelPhieuBH.Click += labelPhieuBH_Click;
            // 
            // nmJewelryCount
            // 
            nmJewelryCount.Location = new Point(572, 15);
            nmJewelryCount.Margin = new Padding(2);
            nmJewelryCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmJewelryCount.Name = "nmJewelryCount";
            nmJewelryCount.Size = new Size(65, 31);
            nmJewelryCount.TabIndex = 3;
            // 
            // btnAddJewelry
            // 
            btnAddJewelry.Location = new Point(386, 15);
            btnAddJewelry.Margin = new Padding(2);
            btnAddJewelry.Name = "btnAddJewelry";
            btnAddJewelry.Size = new Size(154, 34);
            btnAddJewelry.TabIndex = 2;
            btnAddJewelry.Text = "Thêm";
            btnAddJewelry.UseVisualStyleBackColor = true;
            // 
            // cbJewelry
            // 
            cbJewelry.FormattingEnabled = true;
            cbJewelry.Location = new Point(159, 66);
            cbJewelry.Margin = new Padding(2);
            cbJewelry.Name = "cbJewelry";
            cbJewelry.Size = new Size(157, 33);
            cbJewelry.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(626, 64);
            cbCategory.Margin = new Padding(2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(152, 33);
            cbCategory.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(7, 453);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(995, 51);
            panel3.TabIndex = 9;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(825, 9);
            btnCheckOut.Margin = new Padding(2);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(154, 34);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(9, 117);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 332);
            panel2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 298);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 31);
            textBox3.TabIndex = 2;
            textBox3.Text = "Thành tiền";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 298);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader18, columnHeader31, columnHeader32 });
            lsvBill.Location = new Point(25, 19);
            lsvBill.Margin = new Padding(2);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(441, 275);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // tpPhieuBanHang
            // 
            tpPhieuBanHang.Controls.Add(listView2);
            tpPhieuBanHang.Location = new Point(4, 34);
            tpPhieuBanHang.Name = "tpPhieuBanHang";
            tpPhieuBanHang.Size = new Size(1214, 612);
            tpPhieuBanHang.TabIndex = 0;
            tpPhieuBanHang.Text = "Phiếu bán hàng";
            tpPhieuBanHang.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader1 });
            listView2.GridLines = true;
            listView2.Location = new Point(8, 49);
            listView2.Name = "listView2";
            listView2.Size = new Size(994, 447);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã phiếu";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mã khách hàng";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mã nhân viên";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã sản phẩm";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số lượng";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ngày bán";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 150;
            // 
            // tpPhieuNhapHang
            // 
            tpPhieuNhapHang.Controls.Add(listView3);
            tpPhieuNhapHang.Location = new Point(4, 34);
            tpPhieuNhapHang.Name = "tpPhieuNhapHang";
            tpPhieuNhapHang.Size = new Size(1214, 612);
            tpPhieuNhapHang.TabIndex = 0;
            tpPhieuNhapHang.Text = "Phiếu nhập hàng";
            tpPhieuNhapHang.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView3.GridLines = true;
            listView3.Location = new Point(8, 36);
            listView3.Name = "listView3";
            listView3.Size = new Size(994, 447);
            listView3.TabIndex = 1;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            listView3.SelectedIndexChanged += listView3_SelectedIndexChanged_1;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Mã phiếu";
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Mã nhà cung cấp";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Mã sản phẩm";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Ngày mua";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Số lượng";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Đơn giá";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 150;
            // 
            // tpTraCuuDichVu
            // 
            tpTraCuuDichVu.Controls.Add(listView4);
            tpTraCuuDichVu.Location = new Point(4, 34);
            tpTraCuuDichVu.Name = "tpTraCuuDichVu";
            tpTraCuuDichVu.Size = new Size(1214, 612);
            tpTraCuuDichVu.TabIndex = 1;
            tpTraCuuDichVu.Text = "Tra cứu dịch vụ";
            tpTraCuuDichVu.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15 });
            listView4.GridLines = true;
            listView4.Location = new Point(30, 32);
            listView4.Name = "listView4";
            listView4.Size = new Size(504, 447);
            listView4.TabIndex = 2;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Mã dịch vụ";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Tên dịch vụ";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            columnHeader14.Width = 200;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Đơn giá";
            columnHeader15.TextAlign = HorizontalAlignment.Center;
            columnHeader15.Width = 200;
            // 
            // tpPhieuDichVu
            // 
            tpPhieuDichVu.Controls.Add(listView5);
            tpPhieuDichVu.Location = new Point(4, 34);
            tpPhieuDichVu.Name = "tpPhieuDichVu";
            tpPhieuDichVu.Size = new Size(1214, 612);
            tpPhieuDichVu.TabIndex = 2;
            tpPhieuDichVu.Text = "Phiếu dịch vụ";
            tpPhieuDichVu.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            listView5.Columns.AddRange(new ColumnHeader[] { columnHeader19, columnHeader20, columnHeader21, columnHeader22, columnHeader23, columnHeader24, columnHeader16 });
            listView5.GridLines = true;
            listView5.Location = new Point(18, 35);
            listView5.Name = "listView5";
            listView5.Size = new Size(964, 447);
            listView5.TabIndex = 3;
            listView5.UseCompatibleStateImageBehavior = false;
            listView5.View = View.Details;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Mã hóa đơn";
            columnHeader19.Width = 110;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Mã khách hàng";
            columnHeader20.TextAlign = HorizontalAlignment.Center;
            columnHeader20.Width = 150;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Mã nhân viên";
            columnHeader21.TextAlign = HorizontalAlignment.Center;
            columnHeader21.Width = 150;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Mã dịch vụ";
            columnHeader22.TextAlign = HorizontalAlignment.Center;
            columnHeader22.Width = 150;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Số lượng";
            columnHeader23.TextAlign = HorizontalAlignment.Center;
            columnHeader23.Width = 100;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Đơn giá";
            columnHeader24.TextAlign = HorizontalAlignment.Center;
            columnHeader24.Width = 150;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Ngày bán";
            columnHeader16.TextAlign = HorizontalAlignment.Center;
            columnHeader16.Width = 150;
            // 
            // tpBaoCaoTonKho
            // 
            tpBaoCaoTonKho.Controls.Add(listView6);
            tpBaoCaoTonKho.Location = new Point(4, 34);
            tpBaoCaoTonKho.Name = "tpBaoCaoTonKho";
            tpBaoCaoTonKho.Size = new Size(1214, 612);
            tpBaoCaoTonKho.TabIndex = 3;
            tpBaoCaoTonKho.Text = "Báo cáo tồn kho";
            tpBaoCaoTonKho.UseVisualStyleBackColor = true;
            // 
            // listView6
            // 
            listView6.Columns.AddRange(new ColumnHeader[] { columnHeader25, columnHeader26, columnHeader27, columnHeader28, columnHeader29, columnHeader30 });
            listView6.GridLines = true;
            listView6.Location = new Point(8, 36);
            listView6.Name = "listView6";
            listView6.Size = new Size(994, 447);
            listView6.TabIndex = 3;
            listView6.UseCompatibleStateImageBehavior = false;
            listView6.View = View.Details;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "     Mã ";
            columnHeader25.Width = 90;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Mã sản phẩm";
            columnHeader26.TextAlign = HorizontalAlignment.Center;
            columnHeader26.Width = 200;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Loại giao dịch";
            columnHeader27.TextAlign = HorizontalAlignment.Center;
            columnHeader27.Width = 200;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Ngày";
            columnHeader28.TextAlign = HorizontalAlignment.Center;
            columnHeader28.Width = 200;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Số lượng trước";
            columnHeader29.TextAlign = HorizontalAlignment.Center;
            columnHeader29.Width = 150;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Số lượng sau";
            columnHeader30.TextAlign = HorizontalAlignment.Center;
            columnHeader30.Width = 150;
            // 
            // tpKhachHang
            // 
            tpKhachHang.Controls.Add(panel47);
            tpKhachHang.Controls.Add(panel52);
            tpKhachHang.Controls.Add(panel53);
            tpKhachHang.Controls.Add(panel54);
            tpKhachHang.Location = new Point(4, 34);
            tpKhachHang.Name = "tpKhachHang";
            tpKhachHang.Padding = new Padding(3);
            tpKhachHang.Size = new Size(1214, 612);
            tpKhachHang.TabIndex = 5;
            tpKhachHang.Text = "Khách hàng";
            tpKhachHang.UseVisualStyleBackColor = true;
            // 
            // panel47
            // 
            panel47.Controls.Add(panel49);
            panel47.Controls.Add(panel50);
            panel47.Location = new Point(604, 159);
            panel47.Margin = new Padding(2);
            panel47.Name = "panel47";
            panel47.Size = new Size(608, 407);
            panel47.TabIndex = 19;
            // 
            // panel49
            // 
            panel49.Controls.Add(textBox5);
            panel49.Controls.Add(label32);
            panel49.Location = new Point(4, 95);
            panel49.Margin = new Padding(2);
            panel49.Name = "panel49";
            panel49.Size = new Size(595, 81);
            panel49.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(174, 25);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(344, 31);
            textBox5.TabIndex = 2;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(28, 31);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(38, 25);
            label32.TabIndex = 0;
            label32.Text = "Tên";
            // 
            // panel50
            // 
            panel50.Controls.Add(txbServiceName);
            panel50.Controls.Add(label33);
            panel50.Location = new Point(2, 10);
            panel50.Margin = new Padding(2);
            panel50.Name = "panel50";
            panel50.Size = new Size(595, 81);
            panel50.TabIndex = 3;
            // 
            // txbServiceName
            // 
            txbServiceName.Location = new Point(176, 25);
            txbServiceName.Margin = new Padding(2);
            txbServiceName.Name = "txbServiceName";
            txbServiceName.Size = new Size(344, 31);
            txbServiceName.TabIndex = 1;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(2, 31);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(117, 25);
            label33.TabIndex = 0;
            label33.Text = "Số điện thoại";
            // 
            // panel52
            // 
            panel52.Controls.Add(txbSearchService);
            panel52.Controls.Add(btnSearchService);
            panel52.Location = new Point(604, 5);
            panel52.Margin = new Padding(2);
            panel52.Name = "panel52";
            panel52.Size = new Size(593, 150);
            panel52.TabIndex = 20;
            // 
            // txbSearchService
            // 
            txbSearchService.Location = new Point(61, 62);
            txbSearchService.Margin = new Padding(2);
            txbSearchService.Name = "txbSearchService";
            txbSearchService.Size = new Size(374, 31);
            txbSearchService.TabIndex = 5;
            // 
            // btnSearchService
            // 
            btnSearchService.Location = new Point(472, 59);
            btnSearchService.Margin = new Padding(2);
            btnSearchService.Name = "btnSearchService";
            btnSearchService.Size = new Size(112, 34);
            btnSearchService.TabIndex = 4;
            btnSearchService.Text = "Tìm kiếm";
            btnSearchService.UseVisualStyleBackColor = true;
            // 
            // panel53
            // 
            panel53.Controls.Add(dtgvService);
            panel53.Location = new Point(10, 159);
            panel53.Margin = new Padding(2);
            panel53.Name = "panel53";
            panel53.Size = new Size(590, 407);
            panel53.TabIndex = 21;
            // 
            // dtgvService
            // 
            dtgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvService.Location = new Point(17, 10);
            dtgvService.Margin = new Padding(2);
            dtgvService.Name = "dtgvService";
            dtgvService.RowHeadersWidth = 62;
            dtgvService.Size = new Size(559, 383);
            dtgvService.TabIndex = 0;
            // 
            // panel54
            // 
            panel54.Controls.Add(btnShowService);
            panel54.Controls.Add(btnAddService);
            panel54.Location = new Point(10, 5);
            panel54.Margin = new Padding(2);
            panel54.Name = "panel54";
            panel54.Size = new Size(590, 150);
            panel54.TabIndex = 18;
            // 
            // btnShowService
            // 
            btnShowService.Location = new Point(464, 97);
            btnShowService.Margin = new Padding(2);
            btnShowService.Name = "btnShowService";
            btnShowService.Size = new Size(112, 34);
            btnShowService.TabIndex = 3;
            btnShowService.Text = "Xem";
            btnShowService.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(327, 97);
            btnAddService.Margin = new Padding(2);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(112, 34);
            btnAddService.TabIndex = 0;
            btnAddService.Text = "Thêm";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Mã sản phẩm";
            columnHeader17.Width = 125;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Tên ";
            columnHeader18.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader31
            // 
            columnHeader31.Text = "Số lượng";
            columnHeader31.TextAlign = HorizontalAlignment.Center;
            columnHeader31.Width = 100;
            // 
            // columnHeader32
            // 
            columnHeader32.Text = "Đơn giá";
            columnHeader32.Width = 100;
            // 
            // columnHeader33
            // 
            columnHeader33.Text = "Mã dịch vụ";
            // 
            // columnHeader34
            // 
            columnHeader34.Text = "Tên dịch vụ";
            columnHeader34.Width = 100;
            // 
            // columnHeader35
            // 
            columnHeader35.Text = "Số lượng";
            columnHeader35.TextAlign = HorizontalAlignment.Center;
            columnHeader35.Width = 100;
            // 
            // columnHeader36
            // 
            columnHeader36.Text = "Đơn giá";
            columnHeader36.TextAlign = HorizontalAlignment.Center;
            columnHeader36.Width = 100;
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 650);
            Controls.Add(tcManager);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
            Name = "fManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý kinh doanh vàng bạc đá quý";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tcManager.ResumeLayout(false);
            tbThanhToan.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmJewelryCount).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tpPhieuBanHang.ResumeLayout(false);
            tpPhieuNhapHang.ResumeLayout(false);
            tpTraCuuDichVu.ResumeLayout(false);
            tpPhieuDichVu.ResumeLayout(false);
            tpBaoCaoTonKho.ResumeLayout(false);
            tpKhachHang.ResumeLayout(false);
            panel47.ResumeLayout(false);
            panel49.ResumeLayout(false);
            panel49.PerformLayout();
            panel50.ResumeLayout(false);
            panel50.PerformLayout();
            panel52.ResumeLayout(false);
            panel52.PerformLayout();
            panel53.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvService).EndInit();
            panel54.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private TabControl tcManager;
        private TabPage tpPhieuBanHang;
        private TabPage tpPhieuNhapHang;
        private TabPage tpTraCuuDichVu;
        private TabPage tpPhieuDichVu;
        private TabPage tpBaoCaoTonKho;
        private TabPage tbThanhToan;
        private Panel panel4;
        private Panel panel1;
        private Label labelPhieuBH;
        private NumericUpDown nmJewelryCount;
        private Button btnAddJewelry;
        private ComboBox cbJewelry;
        private ComboBox cbCategory;
        private Panel panel3;
        private Button btnCheckOut;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel5;
        private ListView listView1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ListView listView2;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private ListView listView3;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView listView4;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ListView listView5;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ListView listView6;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader16;
        private TabPage tpKhachHang;
        private Panel panel47;
        private Panel panel49;
        private Label label32;
        private Panel panel50;
        private TextBox txbServiceName;
        private Label label33;
        private Panel panel52;
        private TextBox txbSearchService;
        private Button btnSearchService;
        private Panel panel53;
        private DataGridView dtgvService;
        private Panel panel54;
        private Button btnShowService;
        private Button btnAddService;
        private TextBox textBox5;
        private ColumnHeader columnHeader33;
        private ColumnHeader columnHeader34;
        private ColumnHeader columnHeader35;
        private ColumnHeader columnHeader36;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
    }
}