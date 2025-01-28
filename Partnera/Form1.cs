using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Partnera
{
    public partial class Form1 : Form
    {
        private const string BaseUrl = "";
        private const string ServiceUri = "";
        private const string Username = "";
        private const string Password = "";



        public Form1()
        {
            InitializeComponent();
        }

        private async void Button_List_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    
                    string requestUri = $"{BaseUrl}{ServiceUri}";
                                      
                    string productCode = string.Empty;
                    string startDate = "2020-01-01";
                    string endDate = "2024-01-31";
                   
                    string queryString = $"?product={productCode}&startdate={startDate}&enddate={endDate}";

                 
                    requestUri += queryString;

                 
                    string authInfo = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{Username}:{Password}"));
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authInfo);

                    
                    HttpResponseMessage response = await client.GetAsync(requestUri);

                   
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                      
                        string jsonResult = ConvertXmlToJson(responseBody);
                        
                        List<Batch> batches = ParseJsonData(jsonResult);
                      
                        dataGridView1.DataSource = batches;
                    }
                    else
                    {
                        Console.WriteLine($"Hata Kodu: {response.StatusCode}\nHata Mesajı: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }

        private string ConvertXmlToJson(string xmlString)
        {
            try
            {
                // XML verisini JSON formatına çeviriyoruz
                string jsonString = JsonConvert.SerializeXmlNode(new XmlDocument { InnerXml = xmlString }, Newtonsoft.Json.Formatting.Indented, true);
                return jsonString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"XML'den JSON'a dönüştürme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private List<Batch> ParseJsonData(string jsonResult)
        {
            try
            {
                // JSON verisi parse 
                JObject root = JObject.Parse(jsonResult);

                List<Batch> batches = new List<Batch>();

               
                foreach (var batchNode in root["batch"])
                {
                    Batch batch = new Batch
                    {
                        CompanyCode = batchNode["company_code"]?.ToString(),
                        OrganizationId = batchNode["organization_id"]?.ToString(),
                        OrganizationCode = batchNode["organization_code"]?.ToString(),
                        BatchNo = batchNode["batch_no"]?.ToString(),
                        Product = batchNode["product"]?.ToString(),
                        Description = batchNode["description"]?.ToString(),
                        PlanQty = batchNode["plan_qty"]?.ToString(),
                        ActualQty = batchNode["actual_qty"]?.ToString(),
                        DtlUm = batchNode["dtl_um"]?.ToString(),
                        Subinventory = batchNode["subinventory"]?.ToString(),
                        BatchStatus = batchNode["batch_status"]?.ToString(),
                        PlanStartDate = batchNode["plan_start_date"]?.ToString(),
                        ActualStartDate = batchNode["actual_start_date"]?.ToString(),
                        DueDate = batchNode["due_date"]?.ToString()
                    };

                    batches.Add(batch);
                }

                
                foreach (var batch in batches)
                {
                    Console.WriteLine($"Batch Verileri:\nCompany Code: {batch.CompanyCode}\nBatch No: {batch.BatchNo}\nProduct: {batch.Product}");
                }

                return batches;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"JSON verisi parse edilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private async void Button_Uretim_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];

                    string lastBatchNo = lastRow.Cells["BatchNo"].Value.ToString();

                    Uretim wipRequest = new Uretim
                    {
                        CompanyCode = "01",
                        BatchNo = lastBatchNo,
                        ItemCode = "80001224",
                        LotNumber = "L01",
                        Quantity = "125",
                        SubinventoryCode = "F1",
                        UomCode = "KL",
                        TransactionType = "WIP_COMPLETE",
                        Attribute1 = "ATR1",
                        Attribute2 = "ATR2",
                        Attribute3 = "ATR3",
                        Attribute4 = "ATR4",
                        Attribute5 = "ATR5"
                    };

                    using (HttpClient client = new HttpClient())
                    {
                        string requestUri = $"{BaseUrl}/ic/api/integration/v1/flows/rest/SAVTR_AXATA_WIP_COMPLETE/1.0/axata/wip_complete/";

                        string authInfo = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{Username}:{Password}"));
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authInfo);

                        StringContent content = new StringContent(wipRequest.ToXmlString(), Encoding.UTF8, "application/xml");

                        HttpResponseMessage response = await client.PostAsync(requestUri, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            Console.WriteLine("İstek başarıyla tamamlandı." + responseBody);
                        }
                        else
                        {
                            Console.WriteLine($"Hata Kodu: {response.StatusCode}\nHata Mesajı: {response.ReasonPhrase}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("DataGridView boş.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }
        }
}