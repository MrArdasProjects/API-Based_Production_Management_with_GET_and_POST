using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partnera
{
    public class Uretim
    {
        public string CompanyCode { get; set; }
        public string BatchNo { get; set; }
        public string ItemCode { get; set; }
        public string LotNumber { get; set; }
        public string Quantity { get; set; }
        public string SubinventoryCode { get; set; }
        public string UomCode { get; set; }
        public string TransactionType { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        public string Attribute5 { get; set; }

        public string ToXmlString()
        {
            return $@"<?xml version=""1.0"" encoding=""UTF-8""?>
            <GET_BATCH_RETURN_Input>
                <InputParameters>
                    <P_SIRKET_KODU>{CompanyCode}</P_SIRKET_KODU>
                    <P_BATCH>{BatchNo}</P_BATCH>
                    <P_ITEM_CODE>{ItemCode}</P_ITEM_CODE>
                    <P_LOT_NUMBER>{LotNumber}</P_LOT_NUMBER>
                    <P_QUANTITY>{Quantity}</P_QUANTITY>
                    <P_SUBINVENTORY_CODE>{SubinventoryCode}</P_SUBINVENTORY_CODE>
                    <P_UOM_CODE>{UomCode}</P_UOM_CODE>
                    <P_TRANSACTION_TYPE>{TransactionType}</P_TRANSACTION_TYPE>
                    <P_ATTRIBUTE1>{Attribute1}</P_ATTRIBUTE1>
                    <P_ATTRIBUTE2>{Attribute2}</P_ATTRIBUTE2>
                    <P_ATTRIBUTE3>{Attribute3}</P_ATTRIBUTE3>
                    <P_ATTRIBUTE4>{Attribute4}</P_ATTRIBUTE4>
                    <P_ATTRIBUTE5>{Attribute5}</P_ATTRIBUTE5>
                </InputParameters>
            </GET_BATCH_RETURN_Input>";
        }

    }
}
