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
    public partial class ReadLoyaltyCard : Form
    {
        public ReadLoyaltyCard()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        System.Boolean clear;

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera2.Items.Add(device.Name);
            cboCamera2.SelectedIndex = 0;

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera2.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

            clear = true;

            cardNo.Clear();
            name.Clear();
            phoneNo.Clear();
            value.Clear();
            btnSave.Enabled = false;
            textChangeValue.Enabled = false;
            TextError.Visible = false;
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                cardNo.Invoke(new MethodInvoker(delegate ()
                {
                    cardNo.Text = result.ToString();

                }));
            }
            pictureBox1.Image = bitmap;
        }

        private void cardNo_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new addloyalty().getLoyaltyCardByCardNo(cardNo.Text);

            if (clear != true) //should be add condion for empty card read
            {
                name.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                phoneNo.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                value.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                btnSave.Enabled = true;
                textChangeValue.Enabled = true;

            }
            else
            {
                clear = false;
                TextError.Visible = true;
                TextError.Text = "Card Is not Registerd";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addloyalty cs = new addloyalty();

            cs.phoneNo = Integer.parseInt(phoneNo.Text);
            cs.name = name.Text;
            cs.loyaltyCardNo = cardNo.Text;
            cs.amount = Integer.parseInt(value.Text) + Integer.parseInt(textChangeValue.Text);
            cs.status = 1;
            cs.addedUser = "User";
            cs.lastModifyDate = DateTime.Now;

            if (cs.editLoyaltyCard(cs.phoneNo) == true)
            {
                MessageBox.Show("Succesfully Updated");
                btnClear.PerformClick();
                textChangeValue.Clear();
            }
            else
            {
                MessageBox.Show("Not updated");
            }
        }

        private void ReadLoyaltyCard_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera2.Items.Add(device.Name);
            cboCamera2.SelectedIndex = 0;

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera2.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

            TextError.Visible = false;
            cardNo.Enabled = false;
            phoneNo.Enabled = false;
            name.Enabled = false;
            value.Enabled = false;
            textChangeValue.Enabled = false;
        }

        private void ReadLoyaltyCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
            TextError.Visible = true;
        }
    }
}
