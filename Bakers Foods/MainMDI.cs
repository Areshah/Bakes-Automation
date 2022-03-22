using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakers_Foods
{
    public partial class MainMDI : Form
    {
        private int childFormNumber = 0;

        public MainMDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Ts_ManageUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers mgusr = new frmManageUsers();
            mgusr.Show();

        }

        private void Ts_stocks_Click(object sender, EventArgs e)
        {
            frmPOS frmPos = new frmPOS();
            frmPos.Show();
        }

        private void InventoryReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInnventoryReports frninvrpt = new frmInnventoryReports();
            frninvrpt.Show();

        }

        private void InventoryRportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInnventoryReports invrpt = new frmInnventoryReports();
            invrpt.Show();

        }

        private void PurchaseInvoiceAalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvAnalys prchnvAnalysis = new InvAnalys();
            prchnvAnalysis.Show();

        }

        private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrint prvw = new frmPrint();
            prvw.Show();
        }

        private void LowPriceAalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lowprice lpr = new Lowprice();
            lpr.Show();
        }

        private void PurchaseOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchOvrView prv = new PurchOvrView();
            prv.Show();
        }

        private void AboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fabt = new frmAbout();
            fabt.Show();

        }

        private void BillingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBillingReport frbilrpt = new frmBillingReport();
            frbilrpt.Show();

        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frcstmr = new frmCustomer();
            frcstmr.Show();

        }

        private void CustomerRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersRecord frmcstreco = new frmCustomersRecord();
            frmcstreco.Show();

        }

        private void FCustomersRecord2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersRecord1 csrec = new frmCustomersRecord1();
            csrec.Show();

        }

        private void ProductCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventoryCategory prcat = new frmInventoryCategory();
            prcat.Show();
        }

        private void ProductCategoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventoryCategoryRecord procatlst = new frmInventoryCategoryRecord();
            procatlst.Show();

        }

        private void InvoicePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInVoiceNo invprnt = new frmInVoiceNo();
            invprnt.Show();
        }

        private void OrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder frordr = new frmOrder();
            frordr.Show();

        }

        private void OrderRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderRecord orrec = new frmOrderRecord();
            orrec.Show();

        }

        private void OrderRecord2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderRecord1 ordet = new frmOrderRecord1();
            ordet.Show();

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOrders ordr = new frmOrders();
            ordr.Show();
        }

        private void UserRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration frmreg = new frmRegistration();
            frmreg.Show();

        }

        private void UserRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrationDetails usrdet = new frmRegistrationDetails();
            usrdet.Show();
                       
        }

        private void OrdersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdersReport ord = new frmOrdersReport();
        }

        private void PasswordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasswordRecovery psrec = new frmPasswordRecovery();
            psrec.Show();

        }

        private void PrinTOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintOptions prop = new frmPrintOptions();
            prop.Show();

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProduct prod = new frmProduct();
            prod.Show();
        }

        private void FrmProductsRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsRecord PRODrwc = new frmProductsRecord();
            PRODrwc.Show();
        }

        private void ProductsRecord1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsRecord1 prRec = new frmProductsRecord1();
            prRec.Show();

        }

        private void ProductsRecord2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsRecord2 proRec2 = new frmProductsRecord2();
            proRec2.Show();

        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmSales prsale = new frmSales();
            prsale.Show();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmSalesRecord slRec = new frmSalesRecord();
            slRec.Show();

        }

        private void SaleRecord2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesRecord1 salrEc = new frmSalesRecord1();
            salrEc.Show();


        }

        private void SalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReport slrprt = new frmSalesReport();
            slrprt.Show();
        }

        private void SearchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchProduct SrcProd = new frmSearchProduct();
            SrcProd.Show();

        }

        private void StockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock frmstoc = new frmStock();
            frmstoc.Show();

        }

        private void FrmStockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockDetails stoksr = new frmStockDetails();
            stoksr.Show();
        }

        private void VendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendor drp = new frmVendor();
            drp.Show();
        }

        private void FrmVendorRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendorRecords SRCH = new frmVendorRecords();
            SRCH.Show();

        }
    }
}
