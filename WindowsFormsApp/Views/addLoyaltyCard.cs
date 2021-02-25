using AForge.Video.DirectShow;
using java.lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Controller;
using ZXing;

namespace WindowsFormsApp.Views
{
    public partial class addLoyaltyCard : Form
    {
        public addLoyaltyCard()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void loaditem()
        {
            dgvItemData.Rows.Clear();
            DataSet ds = new addloyalty().getLoyaltyCards();
            int rowCount = 0;
            try
            {
                rowCount = ds.Tables[0].Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            for (int currentRow = 0; currentRow < rowCount; currentRow++)
            {
                if (ds.Tables[0].Rows[currentRow].ItemArray[4].Equals(1))
                {
                    string phoneNo = ds.Tables[0].Rows[currentRow].ItemArray[0].ToString();
                    string name = ds.Tables[0].Rows[currentRow].ItemArray[1].ToString();
                    string loyaltyCardNo = ds.Tables[0].Rows[currentRow].ItemArray[2].ToString();
                    string amount = ds.Tables[0].Rows[currentRow].ItemArray[3].ToString();
                    string status = ds.Tables[0].Rows[currentRow].ItemArray[4].ToString();
                    string modifyDate = ds.Tables[0].Rows[currentRow].ItemArray[5].ToString();
                    string AddedUser = ds.Tables[0].Rows[currentRow].ItemArray[6].ToString();

                    dgvItemData.Rows.Add(currentRow + 1, phoneNo, name, loyaltyCardNo, amount, status, AddedUser, modifyDate);
                    //AccNo.Add(acono.ToLower());
                }

            }
        }

        public static int saveType = 1;
        int selectedID = -1;
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;

            txtName.Enabled = true;
            txtPhoneNo.Enabled = true;
            txtCardNo.Enabled = true;
            txtAmount.Enabled = true;
            //textUser.Enabled = true;

            dgvItemData.Enabled = false;

            saveType = 1;

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtCardNo.Invoke(new MethodInvoker(delegate ()
                {
                    txtCardNo.Text = result.ToString();
                }));
            }
            pictureBox.Image = bitmap;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;

            txtPhoneNo.Enabled = true;
            txtName.Enabled = true;
            txtCardNo.Enabled = true;
            txtAmount.Enabled = true;
            //textUser.Enabled = true;

            dgvItemData.Enabled = false;

            saveType = 2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;

            dgvItemData.Enabled = true;

            txtPhoneNo.Clear();
            txtName.Clear();
            txtCardNo.Clear();
            txtAmount.Clear();

            txtPhoneNo.Enabled = false;
            txtName.Enabled = false;
            txtCardNo.Enabled = false;
            txtAmount.Enabled = false;


            dgvItemData.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvItemData.Enabled = true;

            addloyalty cs = new addloyalty();
            cs.phoneNo = Integer.parseInt(txtPhoneNo.Text);
            cs.name = txtName.Text;
            cs.loyaltyCardNo = txtCardNo.Text;
            cs.amount = Integer.parseInt(txtAmount.Text);
            cs.status = 0;
            cs.addedUser = "User";
            cs.lastModifyDate = DateTime.Now;

            if (cs.editLoyaltyCard(selectedID) == true)
            {

                MessageBox.Show("Succesfully Deleted");
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;

                dgvItemData.Enabled = true;

                txtPhoneNo.Clear();
                txtName.Clear();
                txtCardNo.Clear();
                txtAmount.Clear();

                txtPhoneNo.Enabled = false;
                txtName.Enabled = false;
                txtCardNo.Enabled = false;
                txtAmount.Enabled = false;


                dgvItemData.Enabled = true;
                loaditem();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvItemData.Enabled = true;

            addloyalty cs = new addloyalty();
            cs.phoneNo = Integer.parseInt(txtPhoneNo.Text);
            cs.name = txtName.Text;
            cs.loyaltyCardNo = txtCardNo.Text;
            cs.amount = Integer.parseInt(txtAmount.Text);
            cs.status = 1;
            cs.addedUser = "User";
            cs.lastModifyDate = DateTime.Now;

            if (saveType == 1)
            {
                if (cs.addLoyaltyCard() == true)
                {
                    MessageBox.Show("Inserted Succesfully");
                    loaditem();
                    btnClear.PerformClick();
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;

                    txtName.Clear();
                    txtPhoneNo.Clear();
                    txtCardNo.Clear();
                    txtAmount.Clear();

                    txtName.Enabled = false;
                    txtPhoneNo.Enabled = false;
                    txtCardNo.Enabled = false;
                    txtAmount.Enabled = false;
                    if (videoCaptureDevice != null)
                    {
                        if (videoCaptureDevice.IsRunning)
                            videoCaptureDevice.Stop();
                    }
                }
                else
                {
                    MessageBox.Show("Not Inserted");
                }
            }

            if (saveType == 2)
            {
                if (cs.editLoyaltyCard(selectedID) == true)
                {
                    MessageBox.Show("Succesfully Updated");
                    loaditem();
                    btnClear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Not updated");
                }
            }
        }

        private void addLoyaltyCard_Load(object sender, EventArgs e)
        {
            lblOnline.Text = "User";
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            loaditem();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera.Items.Add(device.Name);
            cboCamera.SelectedIndex = 0;
        }

        private void dgvItemData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnClear.Enabled = true;
            btnNew.Enabled = false;
            btnDelete.Enabled = true;

            selectedID = Int32.Parse(dgvItemData.CurrentRow.Cells[1].Value.ToString());
            txtPhoneNo.Text = dgvItemData.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgvItemData.CurrentRow.Cells[2].Value.ToString();
            txtCardNo.Text = dgvItemData.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = dgvItemData.CurrentRow.Cells[4].Value.ToString();

            saveType = 2;

            loaditem();
        }
    }
}
