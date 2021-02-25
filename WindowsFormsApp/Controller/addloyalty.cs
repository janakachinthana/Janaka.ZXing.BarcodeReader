using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.DBService;

namespace WindowsFormsApp.Controller
{
    public class addloyalty
    {
        public DataSet getLoyaltyCards()
        {
            return new DB_Operations().selData("select * from tblLoyaltyCard");
        }

        public DataSet getLoyaltyCardByCardNo(string cardNo)
        {

            return new DB_Operations().selData("select * from tblLoyaltyCard where loyaltyCardNo = '" + cardNo + "'");
        }
        public int phoneNo { get; set; }
        public string name { get; set; }
        public string loyaltyCardNo { get; set; }
        public float amount { get; set; }
        public float status { get; set; }
        public DateTime lastModifyDate { get; set; }
        public string addedUser { get; set; }

        public bool addLoyaltyCard()
        {
            try
            {
                var x = new DB_Operations().exeQuery("insert into tblLoyaltyCard (phoneNo,name,loyaltyCardNo,amount,status,lastModifyDate,addedUser) values('" + phoneNo + "','" + name + "','" + loyaltyCardNo + "','" + amount + "','" + status + "','" + lastModifyDate + "','" + addedUser + "')");

                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool editLoyaltyCard(int phoneNo)
        {
            try
            {
                return new DB_Operations().exeQuery("Update tblLoyaltyCard set name='" + name + "',loyaltyCardNo='" + loyaltyCardNo + "',amount='" + amount + "',status='" + status + "',lastModifyDate='" + lastModifyDate + "',addedUser='" + addedUser + "' where phoneNo='" + phoneNo + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
