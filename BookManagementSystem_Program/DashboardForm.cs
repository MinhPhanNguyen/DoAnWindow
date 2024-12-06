using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem_Program
{
    internal class DashboardForm : Form
    {
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button btn_Overall;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvTour;
        private Guna.UI2.WinForms.Guna2Button btn_ShowTour;
        private Guna.UI2.WinForms.Guna2Button btn_AdjustTour;
        private Guna.UI2.WinForms.Guna2Button btn_DeleteTour;
        private Guna.UI2.WinForms.Guna2Button btn_AddTour;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchTour;
        private Guna.UI2.WinForms.Guna2Button btn_SearchTour;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_DescriptionTour;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox txt_UpdateTour;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2TextBox txt_SlotTour;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txt_EndDateTour;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txt_StartDateTour;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_PriceTour;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameTour;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDTour;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel13;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchBookingTour;
        private Guna.UI2.WinForms.Guna2Button btn_SearchBookingTour;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel14;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2TextBox txt_StatusTourBooking;
        private Guna.UI2.WinForms.Guna2TextBox txt_TotalTourBooking;
        private Guna.UI2.WinForms.Guna2TextBox txt_NumberTourBooking;
        private Guna.UI2.WinForms.Guna2TextBox txt_DateTourBooking;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDTourBooking;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel18;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel16;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel15;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView3;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2TextBox txt_NumerphoneUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2TextBox txt_EmailUser;
        private Guna.UI2.WinForms.Guna2TextBox txt_FullnameUser;
        private Guna.UI2.WinForms.Guna2TextBox txt_PasswordUser;
        private Guna.UI2.WinForms.Guna2TextBox txt_AccountUser;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2TextBox txt_PermissionUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel21;
        private Guna.UI2.WinForms.Guna2Button guna2Button13;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel20;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel26;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel27;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel28;
        private Guna.UI2.WinForms.Guna2TextBox txt_ContentFeedback;
        private Guna.UI2.WinForms.Guna2TextBox txt_DateFeedback;
        private Guna.UI2.WinForms.Guna2TextBox txt_RateFeedback;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDFeedback;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel29;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel19;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView4;
        private TabPage tabPage2;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Overall = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_SearchTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_SearchTour = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_ShowTour = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AdjustTour = new Guna.UI2.WinForms.Guna2Button();
            this.btn_DeleteTour = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AddTour = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_DescriptionTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_UpdateTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_SlotTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_EndDateTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_StartDateTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_PriceTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_NameTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_IDTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvTour = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_SearchBookingTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_SearchBookingTour = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel14 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_StatusTourBooking = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TotalTourBooking = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NumberTourBooking = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DateTourBooking = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IDTourBooking = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.guna2Panel18 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel16 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_PermissionUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_NumerphoneUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_EmailUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_FullnameUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_PasswordUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_AccountUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IDUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel15 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView3 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.guna2Panel21 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel20 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel26 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel27 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel28 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_ContentFeedback = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DateFeedback = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_RateFeedback = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IDFeedback = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel29 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel19 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView4 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.guna2Panel13.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.guna2Panel18.SuspendLayout();
            this.guna2Panel16.SuspendLayout();
            this.guna2Panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView3)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.guna2Panel21.SuspendLayout();
            this.guna2Panel20.SuspendLayout();
            this.guna2Panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Controls.Add(this.tabPage4);
            this.guna2TabControl1.Controls.Add(this.tabPage5);
            this.guna2TabControl1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(12, 12);
            this.guna2TabControl1.MaximumSize = new System.Drawing.Size(950, 460);
            this.guna2TabControl1.MinimumSize = new System.Drawing.Size(950, 460);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(950, 460);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guna2Panel2);
            this.tabPage1.Controls.Add(this.guna2Panel1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel2.Controls.Add(this.btn_Overall);
            this.guna2Panel2.Controls.Add(this.guna2DateTimePicker2);
            this.guna2Panel2.Location = new System.Drawing.Point(6, 6);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(750, 64);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(292, 17);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(44, 27);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Đến ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(28, 27);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Từ";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(84, 0);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(186, 64);
            this.guna2DateTimePicker1.TabIndex = 0;
            this.guna2DateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 12, 4, 20, 25, 28, 604);
            // 
            // btn_Overall
            // 
            this.btn_Overall.BackColor = System.Drawing.Color.Transparent;
            this.btn_Overall.BorderColor = System.Drawing.Color.White;
            this.btn_Overall.BorderRadius = 20;
            this.btn_Overall.BorderThickness = 1;
            this.btn_Overall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Overall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Overall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Overall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Overall.FillColor = System.Drawing.Color.Transparent;
            this.btn_Overall.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Overall.ForeColor = System.Drawing.Color.White;
            this.btn_Overall.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Overall.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Overall.Location = new System.Drawing.Point(572, 3);
            this.btn_Overall.Name = "btn_Overall";
            this.btn_Overall.Size = new System.Drawing.Size(175, 58);
            this.btn_Overall.TabIndex = 2;
            this.btn_Overall.Text = "Thống kê";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(360, 0);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(181, 64);
            this.guna2DateTimePicker2.TabIndex = 1;
            this.guna2DateTimePicker2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 12, 4, 20, 25, 47, 33);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel1.Location = new System.Drawing.Point(6, 76);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(653, 373);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(3, 3);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.Size = new System.Drawing.Size(744, 367);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.guna2Panel6);
            this.tabPage2.Controls.Add(this.guna2Panel5);
            this.tabPage2.Controls.Add(this.guna2Panel4);
            this.tabPage2.Controls.Add(this.guna2Panel3);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chuyến đi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.txt_SearchTour);
            this.guna2Panel6.Controls.Add(this.btn_SearchTour);
            this.guna2Panel6.Location = new System.Drawing.Point(418, 6);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(338, 59);
            this.guna2Panel6.TabIndex = 2;
            // 
            // txt_SearchTour
            // 
            this.txt_SearchTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SearchTour.BorderRadius = 20;
            this.txt_SearchTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchTour.DefaultText = "";
            this.txt_SearchTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SearchTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SearchTour.Location = new System.Drawing.Point(5, 6);
            this.txt_SearchTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SearchTour.Name = "txt_SearchTour";
            this.txt_SearchTour.PasswordChar = '\0';
            this.txt_SearchTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SearchTour.PlaceholderText = "";
            this.txt_SearchTour.SelectedText = "";
            this.txt_SearchTour.Size = new System.Drawing.Size(215, 48);
            this.txt_SearchTour.TabIndex = 5;
            // 
            // btn_SearchTour
            // 
            this.btn_SearchTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_SearchTour.BorderRadius = 10;
            this.btn_SearchTour.BorderThickness = 1;
            this.btn_SearchTour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchTour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SearchTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SearchTour.FillColor = System.Drawing.Color.White;
            this.btn_SearchTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_SearchTour.Location = new System.Drawing.Point(227, 6);
            this.btn_SearchTour.Name = "btn_SearchTour";
            this.btn_SearchTour.Size = new System.Drawing.Size(108, 50);
            this.btn_SearchTour.TabIndex = 4;
            this.btn_SearchTour.Text = "Xem";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.Controls.Add(this.btn_ShowTour);
            this.guna2Panel5.Controls.Add(this.btn_AdjustTour);
            this.guna2Panel5.Controls.Add(this.btn_DeleteTour);
            this.guna2Panel5.Controls.Add(this.btn_AddTour);
            this.guna2Panel5.Location = new System.Drawing.Point(6, 6);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(409, 59);
            this.guna2Panel5.TabIndex = 1;
            // 
            // btn_ShowTour
            // 
            this.btn_ShowTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_ShowTour.BorderRadius = 10;
            this.btn_ShowTour.BorderThickness = 1;
            this.btn_ShowTour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowTour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ShowTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ShowTour.FillColor = System.Drawing.Color.White;
            this.btn_ShowTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ShowTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_ShowTour.Location = new System.Drawing.Point(304, 3);
            this.btn_ShowTour.Margin = new System.Windows.Forms.Padding(8);
            this.btn_ShowTour.Name = "btn_ShowTour";
            this.btn_ShowTour.Size = new System.Drawing.Size(102, 53);
            this.btn_ShowTour.TabIndex = 3;
            this.btn_ShowTour.Text = "Xem";
            // 
            // btn_AdjustTour
            // 
            this.btn_AdjustTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_AdjustTour.BorderRadius = 10;
            this.btn_AdjustTour.BorderThickness = 1;
            this.btn_AdjustTour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AdjustTour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AdjustTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AdjustTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AdjustTour.FillColor = System.Drawing.Color.White;
            this.btn_AdjustTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdjustTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_AdjustTour.Location = new System.Drawing.Point(202, 3);
            this.btn_AdjustTour.Margin = new System.Windows.Forms.Padding(8);
            this.btn_AdjustTour.Name = "btn_AdjustTour";
            this.btn_AdjustTour.Size = new System.Drawing.Size(101, 53);
            this.btn_AdjustTour.TabIndex = 2;
            this.btn_AdjustTour.Text = "Sửa";
            // 
            // btn_DeleteTour
            // 
            this.btn_DeleteTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_DeleteTour.BorderRadius = 10;
            this.btn_DeleteTour.BorderThickness = 1;
            this.btn_DeleteTour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DeleteTour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DeleteTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DeleteTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DeleteTour.FillColor = System.Drawing.Color.White;
            this.btn_DeleteTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_DeleteTour.Location = new System.Drawing.Point(101, 3);
            this.btn_DeleteTour.Margin = new System.Windows.Forms.Padding(8);
            this.btn_DeleteTour.Name = "btn_DeleteTour";
            this.btn_DeleteTour.Size = new System.Drawing.Size(100, 53);
            this.btn_DeleteTour.TabIndex = 1;
            this.btn_DeleteTour.Text = "Xóa";
            // 
            // btn_AddTour
            // 
            this.btn_AddTour.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_AddTour.BorderRadius = 10;
            this.btn_AddTour.BorderThickness = 1;
            this.btn_AddTour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddTour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddTour.FillColor = System.Drawing.Color.White;
            this.btn_AddTour.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_AddTour.Location = new System.Drawing.Point(3, 3);
            this.btn_AddTour.Margin = new System.Windows.Forms.Padding(8);
            this.btn_AddTour.Name = "btn_AddTour";
            this.btn_AddTour.Size = new System.Drawing.Size(97, 53);
            this.btn_AddTour.TabIndex = 0;
            this.btn_AddTour.Text = "Thêm";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.Controls.Add(this.txt_DescriptionTour);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel10);
            this.guna2Panel4.Controls.Add(this.txt_UpdateTour);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel4.Controls.Add(this.txt_SlotTour);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel4.Controls.Add(this.txt_EndDateTour);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel4.Controls.Add(this.txt_StartDateTour);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel4.Controls.Add(this.txt_PriceTour);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel4.Controls.Add(this.txt_NameTour);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel4.Controls.Add(this.txt_IDTour);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel4.Location = new System.Drawing.Point(418, 71);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(338, 378);
            this.guna2Panel4.TabIndex = 1;
            // 
            // txt_DescriptionTour
            // 
            this.txt_DescriptionTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_DescriptionTour.BorderRadius = 5;
            this.txt_DescriptionTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DescriptionTour.DefaultText = "";
            this.txt_DescriptionTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DescriptionTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DescriptionTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DescriptionTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DescriptionTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_DescriptionTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DescriptionTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_DescriptionTour.Location = new System.Drawing.Point(116, 298);
            this.txt_DescriptionTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DescriptionTour.Name = "txt_DescriptionTour";
            this.txt_DescriptionTour.Padding = new System.Windows.Forms.Padding(5);
            this.txt_DescriptionTour.PasswordChar = '\0';
            this.txt_DescriptionTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_DescriptionTour.PlaceholderText = "";
            this.txt_DescriptionTour.ReadOnly = true;
            this.txt_DescriptionTour.SelectedText = "";
            this.txt_DescriptionTour.Size = new System.Drawing.Size(209, 60);
            this.txt_DescriptionTour.TabIndex = 15;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(14, 298);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(47, 22);
            this.guna2HtmlLabel10.TabIndex = 14;
            this.guna2HtmlLabel10.Text = "Mô tả:";
            // 
            // txt_UpdateTour
            // 
            this.txt_UpdateTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_UpdateTour.BorderRadius = 5;
            this.txt_UpdateTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UpdateTour.DefaultText = "";
            this.txt_UpdateTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_UpdateTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_UpdateTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UpdateTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UpdateTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_UpdateTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_UpdateTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_UpdateTour.Location = new System.Drawing.Point(116, 258);
            this.txt_UpdateTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UpdateTour.Name = "txt_UpdateTour";
            this.txt_UpdateTour.Padding = new System.Windows.Forms.Padding(5);
            this.txt_UpdateTour.PasswordChar = '\0';
            this.txt_UpdateTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_UpdateTour.PlaceholderText = "";
            this.txt_UpdateTour.ReadOnly = true;
            this.txt_UpdateTour.SelectedText = "";
            this.txt_UpdateTour.Size = new System.Drawing.Size(209, 30);
            this.txt_UpdateTour.TabIndex = 13;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(14, 258);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(72, 22);
            this.guna2HtmlLabel9.TabIndex = 12;
            this.guna2HtmlLabel9.Text = "Cập nhật:";
            // 
            // txt_SlotTour
            // 
            this.txt_SlotTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SlotTour.BorderRadius = 5;
            this.txt_SlotTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SlotTour.DefaultText = "";
            this.txt_SlotTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SlotTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SlotTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SlotTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SlotTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SlotTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SlotTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SlotTour.Location = new System.Drawing.Point(116, 218);
            this.txt_SlotTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SlotTour.Name = "txt_SlotTour";
            this.txt_SlotTour.Padding = new System.Windows.Forms.Padding(5);
            this.txt_SlotTour.PasswordChar = '\0';
            this.txt_SlotTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SlotTour.PlaceholderText = "";
            this.txt_SlotTour.ReadOnly = true;
            this.txt_SlotTour.SelectedText = "";
            this.txt_SlotTour.Size = new System.Drawing.Size(209, 30);
            this.txt_SlotTour.TabIndex = 11;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(14, 218);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(79, 22);
            this.guna2HtmlLabel8.TabIndex = 10;
            this.guna2HtmlLabel8.Text = "Ghế trống:";
            // 
            // txt_EndDateTour
            // 
            this.txt_EndDateTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_EndDateTour.BorderRadius = 5;
            this.txt_EndDateTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EndDateTour.DefaultText = "";
            this.txt_EndDateTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EndDateTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EndDateTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EndDateTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EndDateTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_EndDateTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_EndDateTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_EndDateTour.Location = new System.Drawing.Point(116, 178);
            this.txt_EndDateTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_EndDateTour.Name = "txt_EndDateTour";
            this.txt_EndDateTour.Padding = new System.Windows.Forms.Padding(5);
            this.txt_EndDateTour.PasswordChar = '\0';
            this.txt_EndDateTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_EndDateTour.PlaceholderText = "";
            this.txt_EndDateTour.ReadOnly = true;
            this.txt_EndDateTour.SelectedText = "";
            this.txt_EndDateTour.Size = new System.Drawing.Size(209, 30);
            this.txt_EndDateTour.TabIndex = 9;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(14, 178);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(63, 22);
            this.guna2HtmlLabel7.TabIndex = 8;
            this.guna2HtmlLabel7.Text = "Ngày về:";
            // 
            // txt_StartDateTour
            // 
            this.txt_StartDateTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_StartDateTour.BorderRadius = 5;
            this.txt_StartDateTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StartDateTour.DefaultText = "";
            this.txt_StartDateTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_StartDateTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_StartDateTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StartDateTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StartDateTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_StartDateTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_StartDateTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_StartDateTour.Location = new System.Drawing.Point(116, 139);
            this.txt_StartDateTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_StartDateTour.Name = "txt_StartDateTour";
            this.txt_StartDateTour.Padding = new System.Windows.Forms.Padding(5);
            this.txt_StartDateTour.PasswordChar = '\0';
            this.txt_StartDateTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_StartDateTour.PlaceholderText = "";
            this.txt_StartDateTour.ReadOnly = true;
            this.txt_StartDateTour.SelectedText = "";
            this.txt_StartDateTour.Size = new System.Drawing.Size(209, 30);
            this.txt_StartDateTour.TabIndex = 7;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(14, 139);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(59, 22);
            this.guna2HtmlLabel6.TabIndex = 6;
            this.guna2HtmlLabel6.Text = "Ngày đi:";
            // 
            // txt_PriceTour
            // 
            this.txt_PriceTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_PriceTour.BorderRadius = 5;
            this.txt_PriceTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PriceTour.DefaultText = "";
            this.txt_PriceTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PriceTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PriceTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PriceTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PriceTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_PriceTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PriceTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_PriceTour.Location = new System.Drawing.Point(116, 99);
            this.txt_PriceTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PriceTour.Name = "txt_PriceTour";
            this.txt_PriceTour.Padding = new System.Windows.Forms.Padding(5);
            this.txt_PriceTour.PasswordChar = '\0';
            this.txt_PriceTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_PriceTour.PlaceholderText = "";
            this.txt_PriceTour.ReadOnly = true;
            this.txt_PriceTour.SelectedText = "";
            this.txt_PriceTour.Size = new System.Drawing.Size(209, 30);
            this.txt_PriceTour.TabIndex = 5;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(14, 99);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(32, 22);
            this.guna2HtmlLabel5.TabIndex = 4;
            this.guna2HtmlLabel5.Text = "Giá:";
            // 
            // txt_NameTour
            // 
            this.txt_NameTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_NameTour.BorderRadius = 5;
            this.txt_NameTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameTour.DefaultText = "";
            this.txt_NameTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NameTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NameTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_NameTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NameTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_NameTour.Location = new System.Drawing.Point(116, 59);
            this.txt_NameTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NameTour.Name = "txt_NameTour";
            this.txt_NameTour.Padding = new System.Windows.Forms.Padding(5);
            this.txt_NameTour.PasswordChar = '\0';
            this.txt_NameTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_NameTour.PlaceholderText = "";
            this.txt_NameTour.ReadOnly = true;
            this.txt_NameTour.SelectedText = "";
            this.txt_NameTour.Size = new System.Drawing.Size(209, 30);
            this.txt_NameTour.TabIndex = 3;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(14, 59);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(66, 22);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Tên tour:";
            // 
            // txt_IDTour
            // 
            this.txt_IDTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDTour.BorderRadius = 5;
            this.txt_IDTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDTour.DefaultText = "";
            this.txt_IDTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IDTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDTour.Location = new System.Drawing.Point(116, 19);
            this.txt_IDTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IDTour.Name = "txt_IDTour";
            this.txt_IDTour.Padding = new System.Windows.Forms.Padding(5);
            this.txt_IDTour.PasswordChar = '\0';
            this.txt_IDTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDTour.PlaceholderText = "";
            this.txt_IDTour.ReadOnly = true;
            this.txt_IDTour.SelectedText = "";
            this.txt_IDTour.Size = new System.Drawing.Size(209, 30);
            this.txt_IDTour.TabIndex = 1;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 19);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(24, 22);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "ID:";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.dtgvTour);
            this.guna2Panel3.Location = new System.Drawing.Point(6, 71);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(409, 378);
            this.guna2Panel3.TabIndex = 0;
            // 
            // dtgvTour
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvTour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvTour.ColumnHeadersHeight = 4;
            this.dtgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTour.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvTour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTour.Location = new System.Drawing.Point(0, 0);
            this.dtgvTour.Name = "dtgvTour";
            this.dtgvTour.RowHeadersVisible = false;
            this.dtgvTour.RowHeadersWidth = 62;
            this.dtgvTour.RowTemplate.Height = 28;
            this.dtgvTour.Size = new System.Drawing.Size(406, 378);
            this.dtgvTour.TabIndex = 0;
            this.dtgvTour.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTour.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvTour.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvTour.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvTour.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvTour.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTour.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTour.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvTour.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvTour.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTour.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvTour.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvTour.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvTour.ThemeStyle.ReadOnly = false;
            this.dtgvTour.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTour.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTour.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTour.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvTour.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvTour.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTour.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.guna2Panel13);
            this.tabPage3.Controls.Add(this.guna2Panel11);
            this.tabPage3.Controls.Add(this.guna2Panel9);
            this.tabPage3.Controls.Add(this.guna2Panel7);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(762, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Đặt chuyến đi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // guna2Panel13
            // 
            this.guna2Panel13.Controls.Add(this.txt_SearchBookingTour);
            this.guna2Panel13.Controls.Add(this.btn_SearchBookingTour);
            this.guna2Panel13.Controls.Add(this.guna2Panel14);
            this.guna2Panel13.Location = new System.Drawing.Point(422, 3);
            this.guna2Panel13.Name = "guna2Panel13";
            this.guna2Panel13.Size = new System.Drawing.Size(337, 59);
            this.guna2Panel13.TabIndex = 3;
            // 
            // txt_SearchBookingTour
            // 
            this.txt_SearchBookingTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SearchBookingTour.BorderRadius = 20;
            this.txt_SearchBookingTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchBookingTour.DefaultText = "";
            this.txt_SearchBookingTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchBookingTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchBookingTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchBookingTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchBookingTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchBookingTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchBookingTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchBookingTour.Location = new System.Drawing.Point(4, 6);
            this.txt_SearchBookingTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SearchBookingTour.Name = "txt_SearchBookingTour";
            this.txt_SearchBookingTour.PasswordChar = '\0';
            this.txt_SearchBookingTour.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_SearchBookingTour.PlaceholderText = "";
            this.txt_SearchBookingTour.SelectedText = "";
            this.txt_SearchBookingTour.Size = new System.Drawing.Size(226, 48);
            this.txt_SearchBookingTour.TabIndex = 7;
            // 
            // btn_SearchBookingTour
            // 
            this.btn_SearchBookingTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_SearchBookingTour.BorderRadius = 10;
            this.btn_SearchBookingTour.BorderThickness = 1;
            this.btn_SearchBookingTour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchBookingTour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchBookingTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SearchBookingTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SearchBookingTour.FillColor = System.Drawing.Color.White;
            this.btn_SearchBookingTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchBookingTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_SearchBookingTour.Location = new System.Drawing.Point(237, 3);
            this.btn_SearchBookingTour.Name = "btn_SearchBookingTour";
            this.btn_SearchBookingTour.Size = new System.Drawing.Size(97, 53);
            this.btn_SearchBookingTour.TabIndex = 6;
            this.btn_SearchBookingTour.Text = "Xem";
            // 
            // guna2Panel14
            // 
            this.guna2Panel14.Location = new System.Drawing.Point(474, 3);
            this.guna2Panel14.Name = "guna2Panel14";
            this.guna2Panel14.Size = new System.Drawing.Size(282, 72);
            this.guna2Panel14.TabIndex = 1;
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.Controls.Add(this.guna2HtmlLabel14);
            this.guna2Panel11.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel11.Controls.Add(this.guna2HtmlLabel11);
            this.guna2Panel11.Controls.Add(this.guna2HtmlLabel12);
            this.guna2Panel11.Controls.Add(this.txt_StatusTourBooking);
            this.guna2Panel11.Controls.Add(this.txt_TotalTourBooking);
            this.guna2Panel11.Controls.Add(this.txt_NumberTourBooking);
            this.guna2Panel11.Controls.Add(this.txt_DateTourBooking);
            this.guna2Panel11.Controls.Add(this.txt_IDTourBooking);
            this.guna2Panel11.Controls.Add(this.guna2HtmlLabel18);
            this.guna2Panel11.Controls.Add(this.guna2Panel12);
            this.guna2Panel11.Location = new System.Drawing.Point(422, 65);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(340, 384);
            this.guna2Panel11.TabIndex = 2;
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(15, 182);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(78, 22);
            this.guna2HtmlLabel14.TabIndex = 32;
            this.guna2HtmlLabel14.Text = "Trạng thái:";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(15, 143);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(68, 22);
            this.guna2HtmlLabel13.TabIndex = 31;
            this.guna2HtmlLabel13.Text = "Tổng giá:";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(15, 103);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(70, 22);
            this.guna2HtmlLabel11.TabIndex = 30;
            this.guna2HtmlLabel11.Text = "Số người:";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(15, 63);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(70, 22);
            this.guna2HtmlLabel12.TabIndex = 28;
            this.guna2HtmlLabel12.Text = "Ngày đặt:";
            // 
            // txt_StatusTourBooking
            // 
            this.txt_StatusTourBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_StatusTourBooking.BorderRadius = 5;
            this.txt_StatusTourBooking.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StatusTourBooking.DefaultText = "";
            this.txt_StatusTourBooking.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_StatusTourBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_StatusTourBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StatusTourBooking.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_StatusTourBooking.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StatusTourBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_StatusTourBooking.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_StatusTourBooking.Location = new System.Drawing.Point(117, 182);
            this.txt_StatusTourBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_StatusTourBooking.Name = "txt_StatusTourBooking";
            this.txt_StatusTourBooking.Padding = new System.Windows.Forms.Padding(5);
            this.txt_StatusTourBooking.PasswordChar = '\0';
            this.txt_StatusTourBooking.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_StatusTourBooking.PlaceholderText = "";
            this.txt_StatusTourBooking.ReadOnly = true;
            this.txt_StatusTourBooking.SelectedText = "";
            this.txt_StatusTourBooking.Size = new System.Drawing.Size(209, 30);
            this.txt_StatusTourBooking.TabIndex = 25;
            // 
            // txt_TotalTourBooking
            // 
            this.txt_TotalTourBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_TotalTourBooking.BorderRadius = 5;
            this.txt_TotalTourBooking.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TotalTourBooking.DefaultText = "";
            this.txt_TotalTourBooking.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TotalTourBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TotalTourBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TotalTourBooking.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TotalTourBooking.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TotalTourBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TotalTourBooking.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TotalTourBooking.Location = new System.Drawing.Point(117, 143);
            this.txt_TotalTourBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TotalTourBooking.Name = "txt_TotalTourBooking";
            this.txt_TotalTourBooking.Padding = new System.Windows.Forms.Padding(5);
            this.txt_TotalTourBooking.PasswordChar = '\0';
            this.txt_TotalTourBooking.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_TotalTourBooking.PlaceholderText = "";
            this.txt_TotalTourBooking.ReadOnly = true;
            this.txt_TotalTourBooking.SelectedText = "";
            this.txt_TotalTourBooking.Size = new System.Drawing.Size(209, 30);
            this.txt_TotalTourBooking.TabIndex = 23;
            // 
            // txt_NumberTourBooking
            // 
            this.txt_NumberTourBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_NumberTourBooking.BorderRadius = 5;
            this.txt_NumberTourBooking.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NumberTourBooking.DefaultText = "";
            this.txt_NumberTourBooking.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NumberTourBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NumberTourBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NumberTourBooking.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NumberTourBooking.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NumberTourBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NumberTourBooking.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NumberTourBooking.Location = new System.Drawing.Point(117, 103);
            this.txt_NumberTourBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NumberTourBooking.Name = "txt_NumberTourBooking";
            this.txt_NumberTourBooking.Padding = new System.Windows.Forms.Padding(5);
            this.txt_NumberTourBooking.PasswordChar = '\0';
            this.txt_NumberTourBooking.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_NumberTourBooking.PlaceholderText = "";
            this.txt_NumberTourBooking.ReadOnly = true;
            this.txt_NumberTourBooking.SelectedText = "";
            this.txt_NumberTourBooking.Size = new System.Drawing.Size(209, 30);
            this.txt_NumberTourBooking.TabIndex = 21;
            // 
            // txt_DateTourBooking
            // 
            this.txt_DateTourBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_DateTourBooking.BorderRadius = 5;
            this.txt_DateTourBooking.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DateTourBooking.DefaultText = "";
            this.txt_DateTourBooking.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DateTourBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DateTourBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DateTourBooking.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DateTourBooking.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DateTourBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DateTourBooking.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DateTourBooking.Location = new System.Drawing.Point(117, 63);
            this.txt_DateTourBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DateTourBooking.Name = "txt_DateTourBooking";
            this.txt_DateTourBooking.Padding = new System.Windows.Forms.Padding(5);
            this.txt_DateTourBooking.PasswordChar = '\0';
            this.txt_DateTourBooking.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_DateTourBooking.PlaceholderText = "";
            this.txt_DateTourBooking.ReadOnly = true;
            this.txt_DateTourBooking.SelectedText = "";
            this.txt_DateTourBooking.Size = new System.Drawing.Size(209, 30);
            this.txt_DateTourBooking.TabIndex = 19;
            // 
            // txt_IDTourBooking
            // 
            this.txt_IDTourBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDTourBooking.BorderRadius = 5;
            this.txt_IDTourBooking.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDTourBooking.DefaultText = "";
            this.txt_IDTourBooking.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDTourBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDTourBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDTourBooking.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDTourBooking.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDTourBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IDTourBooking.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDTourBooking.Location = new System.Drawing.Point(117, 23);
            this.txt_IDTourBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IDTourBooking.Name = "txt_IDTourBooking";
            this.txt_IDTourBooking.Padding = new System.Windows.Forms.Padding(5);
            this.txt_IDTourBooking.PasswordChar = '\0';
            this.txt_IDTourBooking.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDTourBooking.PlaceholderText = "";
            this.txt_IDTourBooking.ReadOnly = true;
            this.txt_IDTourBooking.SelectedText = "";
            this.txt_IDTourBooking.Size = new System.Drawing.Size(209, 30);
            this.txt_IDTourBooking.TabIndex = 17;
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(15, 23);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(24, 22);
            this.guna2HtmlLabel18.TabIndex = 16;
            this.guna2HtmlLabel18.Text = "ID:";
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.Location = new System.Drawing.Point(474, 3);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(282, 72);
            this.guna2Panel12.TabIndex = 1;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.Controls.Add(this.guna2Button3);
            this.guna2Panel9.Controls.Add(this.guna2Button4);
            this.guna2Panel9.Controls.Add(this.guna2Button5);
            this.guna2Panel9.Controls.Add(this.guna2Button6);
            this.guna2Panel9.Controls.Add(this.guna2Panel10);
            this.guna2Panel9.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(416, 59);
            this.guna2Panel9.TabIndex = 2;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button3.Location = new System.Drawing.Point(306, 1);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(102, 53);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "Xem";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button4.Location = new System.Drawing.Point(204, 1);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(101, 53);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "Sửa";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button5.BorderRadius = 10;
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.White;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button5.Location = new System.Drawing.Point(102, 1);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(100, 53);
            this.guna2Button5.TabIndex = 5;
            this.guna2Button5.Text = "Xóa";
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button6.BorderRadius = 10;
            this.guna2Button6.BorderThickness = 1;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.White;
            this.guna2Button6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button6.Location = new System.Drawing.Point(3, 1);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(97, 53);
            this.guna2Button6.TabIndex = 4;
            this.guna2Button6.Text = "Thêm";
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.Location = new System.Drawing.Point(474, 3);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Size = new System.Drawing.Size(282, 72);
            this.guna2Panel10.TabIndex = 1;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Controls.Add(this.guna2DataGridView2);
            this.guna2Panel7.Controls.Add(this.guna2Panel8);
            this.guna2Panel7.Location = new System.Drawing.Point(3, 65);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(416, 384);
            this.guna2Panel7.TabIndex = 0;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView2.ColumnHeadersHeight = 4;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(3, 0);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.RowHeadersWidth = 62;
            this.guna2DataGridView2.RowTemplate.Height = 28;
            this.guna2DataGridView2.Size = new System.Drawing.Size(410, 389);
            this.guna2DataGridView2.TabIndex = 2;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.Location = new System.Drawing.Point(474, 3);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(282, 72);
            this.guna2Panel8.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.guna2Panel18);
            this.tabPage4.Controls.Add(this.guna2Panel16);
            this.tabPage4.Controls.Add(this.guna2Panel15);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(762, 452);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Người dùng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // guna2Panel18
            // 
            this.guna2Panel18.Controls.Add(this.guna2Button8);
            this.guna2Panel18.Controls.Add(this.guna2Button9);
            this.guna2Panel18.Controls.Add(this.guna2Button10);
            this.guna2Panel18.Controls.Add(this.guna2Button11);
            this.guna2Panel18.Location = new System.Drawing.Point(6, 3);
            this.guna2Panel18.Name = "guna2Panel18";
            this.guna2Panel18.Size = new System.Drawing.Size(415, 56);
            this.guna2Panel18.TabIndex = 3;
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button8.BorderRadius = 10;
            this.guna2Button8.BorderThickness = 1;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.White;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button8.Location = new System.Drawing.Point(308, 2);
            this.guna2Button8.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(102, 53);
            this.guna2Button8.TabIndex = 11;
            this.guna2Button8.Text = "Xem";
            // 
            // guna2Button9
            // 
            this.guna2Button9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button9.BorderRadius = 10;
            this.guna2Button9.BorderThickness = 1;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.White;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button9.Location = new System.Drawing.Point(206, 2);
            this.guna2Button9.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(101, 53);
            this.guna2Button9.TabIndex = 10;
            this.guna2Button9.Text = "Sửa";
            // 
            // guna2Button10
            // 
            this.guna2Button10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button10.BorderRadius = 10;
            this.guna2Button10.BorderThickness = 1;
            this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button10.FillColor = System.Drawing.Color.White;
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button10.Location = new System.Drawing.Point(104, 2);
            this.guna2Button10.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(100, 53);
            this.guna2Button10.TabIndex = 9;
            this.guna2Button10.Text = "Xóa";
            // 
            // guna2Button11
            // 
            this.guna2Button11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button11.BorderRadius = 10;
            this.guna2Button11.BorderThickness = 1;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.White;
            this.guna2Button11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button11.Location = new System.Drawing.Point(5, 2);
            this.guna2Button11.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(97, 53);
            this.guna2Button11.TabIndex = 8;
            this.guna2Button11.Text = "Thêm";
            // 
            // guna2Panel16
            // 
            this.guna2Panel16.Controls.Add(this.guna2HtmlLabel22);
            this.guna2Panel16.Controls.Add(this.txt_PermissionUser);
            this.guna2Panel16.Controls.Add(this.guna2HtmlLabel21);
            this.guna2Panel16.Controls.Add(this.txt_NumerphoneUser);
            this.guna2Panel16.Controls.Add(this.guna2HtmlLabel15);
            this.guna2Panel16.Controls.Add(this.guna2HtmlLabel16);
            this.guna2Panel16.Controls.Add(this.guna2HtmlLabel17);
            this.guna2Panel16.Controls.Add(this.guna2HtmlLabel19);
            this.guna2Panel16.Controls.Add(this.txt_EmailUser);
            this.guna2Panel16.Controls.Add(this.txt_FullnameUser);
            this.guna2Panel16.Controls.Add(this.txt_PasswordUser);
            this.guna2Panel16.Controls.Add(this.txt_AccountUser);
            this.guna2Panel16.Controls.Add(this.txt_IDUser);
            this.guna2Panel16.Controls.Add(this.guna2HtmlLabel20);
            this.guna2Panel16.Location = new System.Drawing.Point(427, 62);
            this.guna2Panel16.Name = "guna2Panel16";
            this.guna2Panel16.Size = new System.Drawing.Size(332, 387);
            this.guna2Panel16.TabIndex = 1;
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(16, 256);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(53, 22);
            this.guna2HtmlLabel22.TabIndex = 46;
            this.guna2HtmlLabel22.Text = "Quyền:";
            // 
            // txt_PermissionUser
            // 
            this.txt_PermissionUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_PermissionUser.BorderRadius = 5;
            this.txt_PermissionUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PermissionUser.DefaultText = "";
            this.txt_PermissionUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PermissionUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PermissionUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PermissionUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PermissionUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PermissionUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PermissionUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PermissionUser.Location = new System.Drawing.Point(122, 256);
            this.txt_PermissionUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PermissionUser.Name = "txt_PermissionUser";
            this.txt_PermissionUser.Padding = new System.Windows.Forms.Padding(5);
            this.txt_PermissionUser.PasswordChar = '\0';
            this.txt_PermissionUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_PermissionUser.PlaceholderText = "";
            this.txt_PermissionUser.ReadOnly = true;
            this.txt_PermissionUser.SelectedText = "";
            this.txt_PermissionUser.Size = new System.Drawing.Size(192, 30);
            this.txt_PermissionUser.TabIndex = 45;
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(16, 216);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(79, 22);
            this.guna2HtmlLabel21.TabIndex = 44;
            this.guna2HtmlLabel21.Text = "Điện thoại:";
            // 
            // txt_NumerphoneUser
            // 
            this.txt_NumerphoneUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_NumerphoneUser.BorderRadius = 5;
            this.txt_NumerphoneUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NumerphoneUser.DefaultText = "";
            this.txt_NumerphoneUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NumerphoneUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NumerphoneUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NumerphoneUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NumerphoneUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NumerphoneUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NumerphoneUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NumerphoneUser.Location = new System.Drawing.Point(122, 216);
            this.txt_NumerphoneUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NumerphoneUser.Name = "txt_NumerphoneUser";
            this.txt_NumerphoneUser.Padding = new System.Windows.Forms.Padding(5);
            this.txt_NumerphoneUser.PasswordChar = '\0';
            this.txt_NumerphoneUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_NumerphoneUser.PlaceholderText = "";
            this.txt_NumerphoneUser.ReadOnly = true;
            this.txt_NumerphoneUser.SelectedText = "";
            this.txt_NumerphoneUser.Size = new System.Drawing.Size(192, 30);
            this.txt_NumerphoneUser.TabIndex = 43;
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(16, 176);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(46, 22);
            this.guna2HtmlLabel15.TabIndex = 42;
            this.guna2HtmlLabel15.Text = "Email:";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(16, 137);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(55, 22);
            this.guna2HtmlLabel16.TabIndex = 41;
            this.guna2HtmlLabel16.Text = "Họ tên:";
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(16, 97);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(73, 22);
            this.guna2HtmlLabel17.TabIndex = 40;
            this.guna2HtmlLabel17.Text = "Mật khẩu:";
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(16, 57);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(76, 22);
            this.guna2HtmlLabel19.TabIndex = 39;
            this.guna2HtmlLabel19.Text = "Tài khoản:";
            // 
            // txt_EmailUser
            // 
            this.txt_EmailUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_EmailUser.BorderRadius = 5;
            this.txt_EmailUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmailUser.DefaultText = "";
            this.txt_EmailUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EmailUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EmailUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmailUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmailUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmailUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_EmailUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmailUser.Location = new System.Drawing.Point(122, 176);
            this.txt_EmailUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_EmailUser.Name = "txt_EmailUser";
            this.txt_EmailUser.Padding = new System.Windows.Forms.Padding(5);
            this.txt_EmailUser.PasswordChar = '\0';
            this.txt_EmailUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_EmailUser.PlaceholderText = "";
            this.txt_EmailUser.ReadOnly = true;
            this.txt_EmailUser.SelectedText = "";
            this.txt_EmailUser.Size = new System.Drawing.Size(192, 30);
            this.txt_EmailUser.TabIndex = 38;
            // 
            // txt_FullnameUser
            // 
            this.txt_FullnameUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_FullnameUser.BorderRadius = 5;
            this.txt_FullnameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FullnameUser.DefaultText = "";
            this.txt_FullnameUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_FullnameUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_FullnameUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FullnameUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FullnameUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FullnameUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_FullnameUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FullnameUser.Location = new System.Drawing.Point(122, 137);
            this.txt_FullnameUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FullnameUser.Name = "txt_FullnameUser";
            this.txt_FullnameUser.Padding = new System.Windows.Forms.Padding(5);
            this.txt_FullnameUser.PasswordChar = '\0';
            this.txt_FullnameUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_FullnameUser.PlaceholderText = "";
            this.txt_FullnameUser.ReadOnly = true;
            this.txt_FullnameUser.SelectedText = "";
            this.txt_FullnameUser.Size = new System.Drawing.Size(192, 30);
            this.txt_FullnameUser.TabIndex = 37;
            // 
            // txt_PasswordUser
            // 
            this.txt_PasswordUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_PasswordUser.BorderRadius = 5;
            this.txt_PasswordUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PasswordUser.DefaultText = "";
            this.txt_PasswordUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PasswordUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PasswordUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PasswordUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PasswordUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PasswordUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PasswordUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PasswordUser.Location = new System.Drawing.Point(122, 97);
            this.txt_PasswordUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PasswordUser.Name = "txt_PasswordUser";
            this.txt_PasswordUser.Padding = new System.Windows.Forms.Padding(5);
            this.txt_PasswordUser.PasswordChar = '\0';
            this.txt_PasswordUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_PasswordUser.PlaceholderText = "";
            this.txt_PasswordUser.ReadOnly = true;
            this.txt_PasswordUser.SelectedText = "";
            this.txt_PasswordUser.Size = new System.Drawing.Size(192, 30);
            this.txt_PasswordUser.TabIndex = 36;
            // 
            // txt_AccountUser
            // 
            this.txt_AccountUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_AccountUser.BorderRadius = 5;
            this.txt_AccountUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AccountUser.DefaultText = "";
            this.txt_AccountUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AccountUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AccountUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AccountUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AccountUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AccountUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_AccountUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AccountUser.Location = new System.Drawing.Point(122, 57);
            this.txt_AccountUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AccountUser.Name = "txt_AccountUser";
            this.txt_AccountUser.Padding = new System.Windows.Forms.Padding(5);
            this.txt_AccountUser.PasswordChar = '\0';
            this.txt_AccountUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_AccountUser.PlaceholderText = "";
            this.txt_AccountUser.ReadOnly = true;
            this.txt_AccountUser.SelectedText = "";
            this.txt_AccountUser.Size = new System.Drawing.Size(192, 30);
            this.txt_AccountUser.TabIndex = 35;
            // 
            // txt_IDUser
            // 
            this.txt_IDUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDUser.BorderRadius = 5;
            this.txt_IDUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDUser.DefaultText = "";
            this.txt_IDUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IDUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDUser.Location = new System.Drawing.Point(122, 17);
            this.txt_IDUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IDUser.Name = "txt_IDUser";
            this.txt_IDUser.Padding = new System.Windows.Forms.Padding(5);
            this.txt_IDUser.PasswordChar = '\0';
            this.txt_IDUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDUser.PlaceholderText = "";
            this.txt_IDUser.ReadOnly = true;
            this.txt_IDUser.SelectedText = "";
            this.txt_IDUser.Size = new System.Drawing.Size(192, 30);
            this.txt_IDUser.TabIndex = 34;
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(16, 17);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(24, 22);
            this.guna2HtmlLabel20.TabIndex = 33;
            this.guna2HtmlLabel20.Text = "ID:";
            // 
            // guna2Panel15
            // 
            this.guna2Panel15.Controls.Add(this.guna2DataGridView3);
            this.guna2Panel15.Location = new System.Drawing.Point(3, 62);
            this.guna2Panel15.Name = "guna2Panel15";
            this.guna2Panel15.Size = new System.Drawing.Size(418, 390);
            this.guna2Panel15.TabIndex = 0;
            // 
            // guna2DataGridView3
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView3.ColumnHeadersHeight = 4;
            this.guna2DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView3.DefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.Location = new System.Drawing.Point(3, 3);
            this.guna2DataGridView3.Name = "guna2DataGridView3";
            this.guna2DataGridView3.RowHeadersVisible = false;
            this.guna2DataGridView3.RowHeadersWidth = 62;
            this.guna2DataGridView3.RowTemplate.Height = 28;
            this.guna2DataGridView3.Size = new System.Drawing.Size(410, 387);
            this.guna2DataGridView3.TabIndex = 3;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView3.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView3.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView3.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.guna2Panel21);
            this.tabPage5.Controls.Add(this.guna2Panel20);
            this.tabPage5.Controls.Add(this.guna2Panel19);
            this.tabPage5.ForeColor = System.Drawing.Color.White;
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(762, 452);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Phản hồi";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // guna2Panel21
            // 
            this.guna2Panel21.Controls.Add(this.guna2Button13);
            this.guna2Panel21.Controls.Add(this.guna2Button14);
            this.guna2Panel21.Controls.Add(this.guna2Button15);
            this.guna2Panel21.Controls.Add(this.guna2Button16);
            this.guna2Panel21.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel21.Name = "guna2Panel21";
            this.guna2Panel21.Size = new System.Drawing.Size(417, 55);
            this.guna2Panel21.TabIndex = 6;
            // 
            // guna2Button13
            // 
            this.guna2Button13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button13.BorderRadius = 10;
            this.guna2Button13.BorderThickness = 1;
            this.guna2Button13.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button13.FillColor = System.Drawing.Color.White;
            this.guna2Button13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button13.Location = new System.Drawing.Point(309, 1);
            this.guna2Button13.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.Size = new System.Drawing.Size(102, 53);
            this.guna2Button13.TabIndex = 15;
            this.guna2Button13.Text = "Xem";
            // 
            // guna2Button14
            // 
            this.guna2Button14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button14.BorderRadius = 10;
            this.guna2Button14.BorderThickness = 1;
            this.guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button14.FillColor = System.Drawing.Color.White;
            this.guna2Button14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button14.Location = new System.Drawing.Point(207, 1);
            this.guna2Button14.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.Size = new System.Drawing.Size(101, 53);
            this.guna2Button14.TabIndex = 14;
            this.guna2Button14.Text = "Sửa";
            // 
            // guna2Button15
            // 
            this.guna2Button15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button15.BorderRadius = 10;
            this.guna2Button15.BorderThickness = 1;
            this.guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button15.FillColor = System.Drawing.Color.White;
            this.guna2Button15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button15.Location = new System.Drawing.Point(105, 1);
            this.guna2Button15.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(100, 53);
            this.guna2Button15.TabIndex = 13;
            this.guna2Button15.Text = "Xóa";
            // 
            // guna2Button16
            // 
            this.guna2Button16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button16.BorderRadius = 10;
            this.guna2Button16.BorderThickness = 1;
            this.guna2Button16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button16.FillColor = System.Drawing.Color.White;
            this.guna2Button16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2Button16.Location = new System.Drawing.Point(6, 1);
            this.guna2Button16.Margin = new System.Windows.Forms.Padding(8);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(97, 53);
            this.guna2Button16.TabIndex = 12;
            this.guna2Button16.Text = "Thêm";
            // 
            // guna2Panel20
            // 
            this.guna2Panel20.Controls.Add(this.guna2HtmlLabel26);
            this.guna2Panel20.Controls.Add(this.guna2HtmlLabel27);
            this.guna2Panel20.Controls.Add(this.guna2HtmlLabel28);
            this.guna2Panel20.Controls.Add(this.txt_ContentFeedback);
            this.guna2Panel20.Controls.Add(this.txt_DateFeedback);
            this.guna2Panel20.Controls.Add(this.txt_RateFeedback);
            this.guna2Panel20.Controls.Add(this.txt_IDFeedback);
            this.guna2Panel20.Controls.Add(this.guna2HtmlLabel29);
            this.guna2Panel20.Location = new System.Drawing.Point(422, 61);
            this.guna2Panel20.Name = "guna2Panel20";
            this.guna2Panel20.Size = new System.Drawing.Size(337, 388);
            this.guna2Panel20.TabIndex = 5;
            // 
            // guna2HtmlLabel26
            // 
            this.guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel26.Location = new System.Drawing.Point(20, 153);
            this.guna2HtmlLabel26.Name = "guna2HtmlLabel26";
            this.guna2HtmlLabel26.Size = new System.Drawing.Size(70, 22);
            this.guna2HtmlLabel26.TabIndex = 55;
            this.guna2HtmlLabel26.Text = "Nội dung:";
            // 
            // guna2HtmlLabel27
            // 
            this.guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel27.Location = new System.Drawing.Point(20, 113);
            this.guna2HtmlLabel27.Name = "guna2HtmlLabel27";
            this.guna2HtmlLabel27.Size = new System.Drawing.Size(43, 22);
            this.guna2HtmlLabel27.TabIndex = 54;
            this.guna2HtmlLabel27.Text = "Ngày:";
            // 
            // guna2HtmlLabel28
            // 
            this.guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel28.Location = new System.Drawing.Point(20, 73);
            this.guna2HtmlLabel28.Name = "guna2HtmlLabel28";
            this.guna2HtmlLabel28.Size = new System.Drawing.Size(71, 22);
            this.guna2HtmlLabel28.TabIndex = 53;
            this.guna2HtmlLabel28.Text = "Đánh giá:";
            // 
            // txt_ContentFeedback
            // 
            this.txt_ContentFeedback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_ContentFeedback.BorderRadius = 5;
            this.txt_ContentFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ContentFeedback.DefaultText = "";
            this.txt_ContentFeedback.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ContentFeedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ContentFeedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ContentFeedback.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ContentFeedback.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ContentFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ContentFeedback.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ContentFeedback.Location = new System.Drawing.Point(126, 153);
            this.txt_ContentFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ContentFeedback.Name = "txt_ContentFeedback";
            this.txt_ContentFeedback.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ContentFeedback.PasswordChar = '\0';
            this.txt_ContentFeedback.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_ContentFeedback.PlaceholderText = "";
            this.txt_ContentFeedback.ReadOnly = true;
            this.txt_ContentFeedback.SelectedText = "";
            this.txt_ContentFeedback.Size = new System.Drawing.Size(192, 74);
            this.txt_ContentFeedback.TabIndex = 51;
            // 
            // txt_DateFeedback
            // 
            this.txt_DateFeedback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_DateFeedback.BorderRadius = 5;
            this.txt_DateFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DateFeedback.DefaultText = "";
            this.txt_DateFeedback.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DateFeedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DateFeedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DateFeedback.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DateFeedback.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DateFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DateFeedback.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DateFeedback.Location = new System.Drawing.Point(126, 113);
            this.txt_DateFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DateFeedback.Name = "txt_DateFeedback";
            this.txt_DateFeedback.Padding = new System.Windows.Forms.Padding(5);
            this.txt_DateFeedback.PasswordChar = '\0';
            this.txt_DateFeedback.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_DateFeedback.PlaceholderText = "";
            this.txt_DateFeedback.ReadOnly = true;
            this.txt_DateFeedback.SelectedText = "";
            this.txt_DateFeedback.Size = new System.Drawing.Size(192, 30);
            this.txt_DateFeedback.TabIndex = 50;
            // 
            // txt_RateFeedback
            // 
            this.txt_RateFeedback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_RateFeedback.BorderRadius = 5;
            this.txt_RateFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RateFeedback.DefaultText = "";
            this.txt_RateFeedback.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_RateFeedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_RateFeedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RateFeedback.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RateFeedback.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RateFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_RateFeedback.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RateFeedback.Location = new System.Drawing.Point(126, 73);
            this.txt_RateFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_RateFeedback.Name = "txt_RateFeedback";
            this.txt_RateFeedback.Padding = new System.Windows.Forms.Padding(5);
            this.txt_RateFeedback.PasswordChar = '\0';
            this.txt_RateFeedback.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_RateFeedback.PlaceholderText = "";
            this.txt_RateFeedback.ReadOnly = true;
            this.txt_RateFeedback.SelectedText = "";
            this.txt_RateFeedback.Size = new System.Drawing.Size(192, 30);
            this.txt_RateFeedback.TabIndex = 49;
            // 
            // txt_IDFeedback
            // 
            this.txt_IDFeedback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDFeedback.BorderRadius = 5;
            this.txt_IDFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDFeedback.DefaultText = "";
            this.txt_IDFeedback.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDFeedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDFeedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDFeedback.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDFeedback.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IDFeedback.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDFeedback.Location = new System.Drawing.Point(126, 33);
            this.txt_IDFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IDFeedback.Name = "txt_IDFeedback";
            this.txt_IDFeedback.Padding = new System.Windows.Forms.Padding(5);
            this.txt_IDFeedback.PasswordChar = '\0';
            this.txt_IDFeedback.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_IDFeedback.PlaceholderText = "";
            this.txt_IDFeedback.ReadOnly = true;
            this.txt_IDFeedback.SelectedText = "";
            this.txt_IDFeedback.Size = new System.Drawing.Size(192, 30);
            this.txt_IDFeedback.TabIndex = 48;
            // 
            // guna2HtmlLabel29
            // 
            this.guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2HtmlLabel29.Location = new System.Drawing.Point(20, 33);
            this.guna2HtmlLabel29.Name = "guna2HtmlLabel29";
            this.guna2HtmlLabel29.Size = new System.Drawing.Size(24, 22);
            this.guna2HtmlLabel29.TabIndex = 47;
            this.guna2HtmlLabel29.Text = "ID:";
            // 
            // guna2Panel19
            // 
            this.guna2Panel19.Controls.Add(this.guna2DataGridView4);
            this.guna2Panel19.Location = new System.Drawing.Point(3, 61);
            this.guna2Panel19.Name = "guna2Panel19";
            this.guna2Panel19.Size = new System.Drawing.Size(417, 388);
            this.guna2Panel19.TabIndex = 0;
            // 
            // guna2DataGridView4
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.guna2DataGridView4.ColumnHeadersHeight = 4;
            this.guna2DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView4.DefaultCellStyle = dataGridViewCellStyle15;
            this.guna2DataGridView4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView4.Location = new System.Drawing.Point(3, 3);
            this.guna2DataGridView4.Name = "guna2DataGridView4";
            this.guna2DataGridView4.RowHeadersVisible = false;
            this.guna2DataGridView4.RowHeadersWidth = 62;
            this.guna2DataGridView4.RowTemplate.Height = 28;
            this.guna2DataGridView4.Size = new System.Drawing.Size(410, 394);
            this.guna2DataGridView4.TabIndex = 4;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView4.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView4.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView4.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView4.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView4.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView4.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DashboardForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 484);
            this.Controls.Add(this.guna2TabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 540);
            this.MinimumSize = new System.Drawing.Size(1000, 540);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang quản trị";
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.guna2Panel13.ResumeLayout(false);
            this.guna2Panel11.ResumeLayout(false);
            this.guna2Panel11.PerformLayout();
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.guna2Panel18.ResumeLayout(false);
            this.guna2Panel16.ResumeLayout(false);
            this.guna2Panel16.PerformLayout();
            this.guna2Panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.guna2Panel21.ResumeLayout(false);
            this.guna2Panel20.ResumeLayout(false);
            this.guna2Panel20.PerformLayout();
            this.guna2Panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

    }
}
