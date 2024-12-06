using System.Windows.Forms;
using System.Linq;
using System;

namespace BookManagementSystem_Program
{
    internal class TourBooking : Form
    {
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnTrịViênToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ListView listView1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel6;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;

        public TourBooking()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourBooking));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel6 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2NumericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnTrịViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.guna2CustomGradientPanel5.SuspendLayout();
            this.guna2CustomGradientPanel4.SuspendLayout();
            this.guna2CustomGradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.listView1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 86);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(363, 220);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 217);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.guna2CustomGradientPanel5);
            this.flowLayoutPanel3.Controls.Add(this.guna2CustomGradientPanel4);
            this.flowLayoutPanel3.Controls.Add(this.guna2CustomGradientPanel6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 312);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(363, 90);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.Controls.Add(this.guna2Button2);
            this.guna2CustomGradientPanel5.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel5.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel5.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(120, 87);
            this.guna2CustomGradientPanel5.TabIndex = 2;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button2.Location = new System.Drawing.Point(3, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(900, 540);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Thanh toán";
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2Button4);
            this.guna2CustomGradientPanel4.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(129, 3);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(111, 87);
            this.guna2CustomGradientPanel4.TabIndex = 1;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button4.Location = new System.Drawing.Point(-3, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(114, 84);
            this.guna2Button4.TabIndex = 3;
            this.guna2Button4.Text = "Chuyển bàn";
            // 
            // guna2CustomGradientPanel6
            // 
            this.guna2CustomGradientPanel6.Controls.Add(this.guna2NumericUpDown2);
            this.guna2CustomGradientPanel6.Controls.Add(this.guna2Button3);
            this.guna2CustomGradientPanel6.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel6.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel6.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2CustomGradientPanel6.Location = new System.Drawing.Point(246, 3);
            this.guna2CustomGradientPanel6.Name = "guna2CustomGradientPanel6";
            this.guna2CustomGradientPanel6.Size = new System.Drawing.Size(113, 87);
            this.guna2CustomGradientPanel6.TabIndex = 3;
            // 
            // guna2NumericUpDown2
            // 
            this.guna2NumericUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown2.BorderThickness = 0;
            this.guna2NumericUpDown2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2NumericUpDown2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2NumericUpDown2.FocusedState.UpDownButtonFillColor = System.Drawing.Color.White;
            this.guna2NumericUpDown2.FocusedState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2NumericUpDown2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2NumericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2NumericUpDown2.Location = new System.Drawing.Point(-1, 51);
            this.guna2NumericUpDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2NumericUpDown2.Name = "guna2NumericUpDown2";
            this.guna2NumericUpDown2.Size = new System.Drawing.Size(114, 36);
            this.guna2NumericUpDown2.TabIndex = 1;
            this.guna2NumericUpDown2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2NumericUpDown2.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button3.Location = new System.Drawing.Point(-1, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(114, 51);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Giảm";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.guna2CustomGradientPanel1);
            this.flowLayoutPanel4.Controls.Add(this.guna2CustomGradientPanel2);
            this.flowLayoutPanel4.Controls.Add(this.guna2CustomGradientPanel3);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(363, 77);
            this.flowLayoutPanel4.TabIndex = 5;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox1);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(150, 74);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.White;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(0, 38);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(150, 36);
            this.guna2ComboBox2.TabIndex = 1;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.White;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.White;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(150, 36);
            this.guna2ComboBox1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2Button1);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(159, 3);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(95, 74);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 74);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Thêm món";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2NumericUpDown1);
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(260, 3);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(95, 74);
            this.guna2CustomGradientPanel3.TabIndex = 2;
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderColor = System.Drawing.Color.White;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2NumericUpDown1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2NumericUpDown1.FocusedState.UpDownButtonFillColor = System.Drawing.Color.White;
            this.guna2NumericUpDown1.FocusedState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(4, 5);
            this.guna2NumericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(87, 64);
            this.guna2NumericUpDown1.TabIndex = 0;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2NumericUpDown1.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 406);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel2);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel3);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel4);
            this.guna2Panel1.Location = new System.Drawing.Point(494, 65);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(372, 407);
            this.guna2Panel1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnTrịViênToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 15, 0, 15);
            this.menuStrip1.Size = new System.Drawing.Size(878, 59);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnTrịViênToolStripMenuItem
            // 
            this.quảnTrịViênToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quảnTrịViênToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.quảnTrịViênToolStripMenuItem.Name = "quảnTrịViênToolStripMenuItem";
            this.quảnTrịViênToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.quảnTrịViênToolStripMenuItem.Text = "Quản trị viên";
            this.quảnTrịViênToolStripMenuItem.Click += new System.EventHandler(this.quảnTrịViênToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tàiKhoảnToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.thôngTinTàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(312, 70);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(312, 70);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // TourBooking
            // 
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 484);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "TourBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tour Booking";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.guna2CustomGradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountInfo accountInfo = new AccountInfo();
            accountInfo.ShowDialog();
            this.Hide();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Hide();
        }

        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.ShowDialog();
            this.Hide();
            this.Show();
        }
    }
}
